using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Config;

namespace CRUD
{
    public partial class CreateBlogForm : Form
    {
        public CreateBlogForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new();
            form1.Show();
            this.Hide();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string blogTitle = txtBlogTitle.Text;
                string blogAuthor = txtBlogAuthor.Text;
                string blogContent = txtBlogContent.Text;

                string query =
                    @"INSERT INTO Tbl_Blog (BlogTitle,BlogAuthor,BlogContent)
                    VALUES (@BlogTitle,@BlogAuthor,@BlogContent)";
                List<SqlParameter> parameters = new()
                {
                    new("@BlogTitle",blogTitle),
                    new("@BlogAuthor",blogAuthor),
                    new("@BlogContent",blogContent)
                };

                SqlConnection connection = new(DbConfig._connectionString);
                await connection.OpenAsync();

                SqlCommand command = new(query, connection);
                command.Parameters.AddRange(parameters.ToArray());

                int result = await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();

                if(result > 0)
                {
                    MessageBox.Show("Saving Successful.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 form1 = new();
                    form1.Show();
                    this.Hide();

                    return;
                }
                MessageBox.Show("Saving Fail.","Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CreateBlogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
