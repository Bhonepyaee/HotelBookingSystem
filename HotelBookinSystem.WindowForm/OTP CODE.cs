using HotelBookinSystem.WindowForm.AppDbContextModels;
using HotelBookinSystem.WindowForm.Exrtensions;
using Microsoft.EntityFrameworkCore;
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
    public partial class OTP_CODE : Form
    {
        internal readonly string _otpId;
        internal readonly string _email;
        internal readonly string _userId;
        internal readonly AppDbContext _context;

        public OTP_CODE(string email, string userId, string otpId)
        {
            InitializeComponent();
            this._email = email;
            _userId = userId;
            _context = new();
            _otpId = otpId;
        }

        private void OTP_CODE_Load(object sender, EventArgs e)
        {

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
    }
}
