using HotelBookinSystem.WindowForm.AppDbContextModels;
using HotelBookinSystem.WindowForm.Exrtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookinSystem.WindowForm
{
    public partial class ChangePassword : Form
    {
        internal readonly string _email;
        internal readonly string _userId;
        internal readonly AppDbContext _context;

        public ChangePassword(string email, string userId)
        {
            InitializeComponent();
            _email = email;
            _userId = userId;
            _context = Program.ServiceProvider.GetRequiredService<AppDbContext>();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = txtNewPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (!newPassword.IsNullOrEmpty() && !confirmPassword.IsNullOrEmpty())
                {
                    if (!newPassword.Equals(confirmPassword))
                    {
                        MessageBox.Show("Error", "Passwords must be the same.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var user = await _context.TblAdmins.FirstOrDefaultAsync(x => x.UserId == _userId && x.Email == _email && !x.IsDeleted);
                    ArgumentNullException.ThrowIfNull(user, nameof(user));

                    user.Password = newPassword;
                    _context.Update(user);
                    await _context.SaveChangesAsync();

                    LoginForm loginForm = new();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
