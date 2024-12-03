using HotelBookinSystem.WindowForm.AppDbContextModels;
using HotelBookinSystem.WindowForm.Exrtensions;
using HotelBookinSystem.WindowForm.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBookinSystem.WindowForm;

public partial class LoginForm : Form
{
    internal readonly AppDbContext _context;
    internal readonly string _path;

    public LoginForm(AppDbContext context)
    {
        InitializeComponent();
        _context = context;
        _path = Path.Combine(Directory.GetCurrentDirectory(), "Data/UserInfo.json");
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool isRememberMeChecked = cboRememberMe.Checked;

            if (!email.IsNullOrEmpty() && !password.IsNullOrEmpty())
            {
                var item = await _context.TblAdmins.FirstOrDefaultAsync(x => x.Email == email);

                if (item is null)
                {
                    MessageBox.Show(
                        "Login Fail.",
                        "Warning",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (item.FailCount >= 3)
                {
                    MessageBox.Show(
                        "Account Locked.",
                        "Warning",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (!item.Password.Equals(password))
                {
                    MessageBox.Show(
                        "Incorrect Password.",
                        "Warning",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning
                    );

                    item.FailCount += 1;
                    _context.TblAdmins.Update(item);
                    await _context.SaveChangesAsync();

                    return;
                }

                if (isRememberMeChecked)
                {
                    var userInfo = new UserInfoModel()
                    {
                        UserId = item.UserId,
                        Email = item.Email,
                        Password = item.Password,
                    };
                    await File.WriteAllTextAsync(_path, userInfo.ToJson());
                }

                MessageBox.Show(
                    "Login Successful.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private async void LoginForm_Load(object sender, EventArgs e)
    {
        string jsonStr = await File.ReadAllTextAsync(_path);
        var userInfoModel = jsonStr.ToObject<UserInfoModel>();
        if (userInfoModel is not null)
        {
            txtEmail.Text = userInfoModel.Email;
            txtPassword.Text = userInfoModel.Password;
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Forgot_PSW forgot_PSW = new();
        forgot_PSW.Show();
        this.Hide();
    }
}