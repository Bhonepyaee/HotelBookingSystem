using FluentEmail.Core;
using HotelBookinSystem.WindowForm.AppDbContextModels;
using HotelBookinSystem.WindowForm.Exrtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookinSystem.WindowForm
{
    public partial class Forgot_PSW : Form
    {
        internal readonly AppDbContext _context;
        internal readonly IFluentEmail _email;
        internal readonly string _subject;

        public Forgot_PSW()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _subject = "Reset Password OTP Code";

            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddFluentEmail("lth1212001@gmail.com")
                .AddSmtpSender(
                    "smtp.gmail.com",
                    587,
                    "lth1212001@gmail.com",
                    "evzd omax jylb pdzn"
                );
            var sericeProvider = serviceCollection.BuildServiceProvider();

            var _fluentEmail = sericeProvider.GetRequiredService<IFluentEmail>();
            _email = _fluentEmail;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                if (!email.IsNullOrEmpty())
                {
                    var user = await _context.TblAdmins.FirstOrDefaultAsync(x =>
                        x.Email == email && !x.IsDeleted
                    );
                    if (user is null)
                    {
                        MessageBox.Show(
                            "Invalid Email",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }

                    string otpValue = GetSixDigitRandomNumber();
                    var otp = new TblOtp()
                    {
                        Id = Guid.NewGuid().ToString(),
                        OtpValue = Convert.ToInt32(otpValue),
                        CreatedAt = DateTime.Now,
                        UserId = user.UserId,
                        IsDeleted = false,
                    };
                    await _context.TblOtps.AddAsync(otp);
                    await _context.SaveChangesAsync();

                    string body =
                        $"Here is your OTP Code: {otpValue}. This Code will be expired within 3 minutes.";
                    await _email.To(user.Email).Subject(_subject).Body(body).SendAsync();

                    OTP_CODE oTP_CODE = new(user.Email, user.UserId, otp.Id);
                    oTP_CODE.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string GetSixDigitRandomNumber()
        {
            Random r = new();
            int randNum = r.Next(100000, 1000000);
            return randNum.ToString();
        }
    }
}
