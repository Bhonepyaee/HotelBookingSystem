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
using CRUD1.Config;
using CRUD1.Queries;

namespace CRUD1
{
    public partial class UpdateBlogForm : Form
    {
        private readonly int _blogId;
        private readonly string _blogTitle = string.Empty;
        private readonly string _blogAuthor = string.Empty;
        private readonly string _blogContent = string.Empty;
        public UpdateBlogForm(int blogId, string blogTitle, string blogAuthor, string blogContent)
        {
            InitializeComponent();
            _blogId = blogId;
            _blogTitle = blogTitle;
            _blogAuthor = blogAuthor;
            _blogContent = blogContent;
        }

        private void UpdateBlogForm_Load(object sender, EventArgs e)
        {
            txtBlogTitle.Text = _blogTitle;
            txtBlogAuthor.Text = _blogAuthor;
            txtBlogContent.Text = _blogContent;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string blogTitle = txtBlogTitle.Text;
                string blogAuthor = txtBlogAuthor.Text;
                string blogContent = txtBlogContent.Text;

                string query = BlogQuery.UpdateBlogQuery;
                List<SqlParameter> parameters = new()
                {
                    new("@BlogId",_blogId),
                    new("@BlogTitle",blogTitle),
                    new("@BlogAuthor",blogAuthor),
                    new("@BlogContent",blogContent)
                };
                SqlConnection connection = new SqlConnection(DbConfig._connectionString);
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters.ToArray());

                int result = await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();


                if (result > 0)
                {
                    MessageBox.Show(
                        "Saving Successful.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    Form1 form1 = new();
                    form1.Show();
                    this.Hide();

                    return;
                }

                MessageBox.Show(
                    "Saving Fail.",
                    "Fail",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                );

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new();
            form1.Show();
            this.Hide();
        }
    }
}
