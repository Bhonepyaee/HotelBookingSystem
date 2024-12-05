using HotelBookinSystem.WindowForm.AppDbContextModels;
using HotelBookinSystem.WindowForm.Exrtensions;
using HotelBookinSystem.WindowForm.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookinSystem.WindowForm
{
    public partial class OTP_CODE : Form
    {
        internal string _otpId;
        internal readonly string _email;
        internal readonly string _userId;
        internal readonly AppDbContext _context;
        private System.Windows.Forms.Timer timer;
        private int timeRemaining = 60; // One minute (in seconds)
        internal readonly OtpService _otpService;
        internal readonly string _subject;

        public OTP_CODE(string email, string userId, string otpId)
        {
            InitializeComponent();
            this._email = email;
            _userId = userId;
            _context = new();
            _otpId = otpId;
            _otpService = Program.ServiceProvider.GetRequiredService<OtpService>();
            _subject = "Reset Password OTP Code";
        }

        private void OTP_CODE_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += (s, args) =>
            {
                lblResend.Enabled = false;
                timeRemaining--;
                lblOneMinute.Text = $"{timeRemaining} seconds"; // Update the label

                if (timeRemaining <= 0)
                {
                    timer.Stop();
                    lblResend.Enabled = true;
                }
            };

            timer.Start();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string otpValue = txtOtp.Text;

                if (!otpValue.IsNullOrEmpty())
                {
                    var otp = await _context.TblOtps
                        .FirstOrDefaultAsync(x => x.UserId == _userId && x.Id == _otpId && x.OtpValue == Convert.ToInt32(otpValue));
                    if (otp is null)
                    {
                        MessageBox.Show("Error", "Invalid OTP.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                    if (otp.CreatedAt.AddMinutes(3) < DateTime.Now)
                    {
                        MessageBox.Show("Error", "OTP has expired.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                    otp.IsDeleted = true;
                    _context.TblOtps.Update(otp);

                    await _context.SaveChangesAsync();

                    ChangePassword changePassword = new(_email, _userId);
                    changePassword.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async void lblResend_LinkClickedAsync(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string otpValue = _otpService.GetSixDigitRandomNumber();
            string otpId = await _otpService.SendOtpViaEmailAsync(_userId, otpValue, _email, _subject);

            _otpId = otpId;
            MessageBox.Show("OTP Resent!", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
