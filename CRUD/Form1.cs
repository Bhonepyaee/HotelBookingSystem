using System.Data;
using System.Data.SqlClient;
using CRUD.Config;
using CRUD.Queries;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadData();
                #region Add Buttons

                DataGridViewButtonColumn editBtn =
                    new() { Text = "Edit", UseColumnTextForButtonValue = true };
                editBtn.DefaultCellStyle.BackColor = Color.Green;
                dataGridView1.Columns.Add(editBtn);

                DataGridViewButtonColumn deleteBtn =
                    new() { Text = "Delete", UseColumnTextForButtonValue = true };
                deleteBtn.DefaultCellStyle.BackColor = Color.Red;
                dataGridView1.Columns.Add(deleteBtn);

                #endregion

              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateBlogForm createBlogForm = new CreateBlogForm();
            createBlogForm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            if(e.ColumnIndex == 4)
            {
                string blogTitle = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value)!;
                string blogAuthor = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value)!;
                string blogContent = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value)!;

                UpdateBlogForm updateBlogForm = new(id, blogTitle, blogAuthor, blogContent);
                updateBlogForm.Show();
                this.Hide();
            }

            if(e.ColumnIndex == 5)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show
                    ("Are you sure,Do u wanna delete this?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if(dialogResult == DialogResult.OK)
                    {
                        string query =
                        @"DELETE FROM Tbl_Blog WHERE BlogId = @BlogId";

                        SqlParameter parameter = new("@BlogId",id);

                        SqlConnection connection = new(DbConfig._connectionString);
                        await connection.OpenAsync();

                        SqlCommand command = new(query, connection);
                        command.Parameters.Add(parameter);

                        int result = await command.ExecuteNonQueryAsync();
                        await connection.CloseAsync();

                        if(result > 0)
                        {
                            MessageBox.Show("Deleting Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            await LoadData();

                            return;

                        }
                        MessageBox.Show("Deleting Fail.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);



                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private async Task LoadData()
        {
            string query = BlogQuery.GetBlogListQuery;

            SqlConnection connection = new SqlConnection(DbConfig._connectionString);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new(command);

            DataTable dt = new();
            adapter.Fill(dt);

            await connection.CloseAsync();
            dataGridView1.DataSource = dt;
        }
    }
}
