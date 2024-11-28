using HotelBookinSystem.WindowForm.AppDbContextModels;
using HotelBookinSystem.WindowForm.Exrtensions;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace HotelBookinSystem.WindowForm
{
    public partial class LoginForm : Form
    {
        internal readonly AppDbContext _context;
        public LoginForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (!email.IsNullOrEmpty() && !password.IsNullOrEmpty())
                {
                    var item = await _context.TblAdmins
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
                    if (item is null)
                    {
                        MessageBox.Show("Login Fail.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show("Login Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
