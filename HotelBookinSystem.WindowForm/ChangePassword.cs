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
        internal readonly string email;
        internal readonly string _userId;

        public ChangePassword(string email, string userId)
        {
            InitializeComponent();
            this.email = email;
            _userId = userId;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
