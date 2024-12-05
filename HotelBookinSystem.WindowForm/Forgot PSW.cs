using HotelBookinSystem.WindowForm.AppDbContextModels;
using HotelBookinSystem.WindowForm.Exrtensions;
using HotelBookinSystem.WindowForm.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookinSystem.WindowForm;

public partial class Forgot_PSW : Form
{
    internal readonly AppDbContext _context;
    internal readonly string _subject;
    internal readonly OtpService _otpService;

    public Forgot_PSW()
    {
        InitializeComponent();
        _context = Program.ServiceProvider.GetRequiredService<AppDbContext>();
        _otpService = Program.ServiceProvider.GetRequiredService<OtpService>();
        _subject = "Reset Password OTP Code";
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

                string otpValue = _otpService.GetSixDigitRandomNumber();
                string otpId = await _otpService.SendOtpViaEmailAsync(
                    user.UserId,
                    otpValue,
                    user.Email,
                    _subject
                );

                if (otpId.IsNullOrEmpty())
                {
                    MessageBox.Show(
                        "Error occured.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                OTP_CODE oTP_CODE = new(user.Email, user.UserId, otpId);
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
