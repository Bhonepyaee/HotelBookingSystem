using System.Data;
using System.Data.SqlClient;
using CRUD1.Config;
using CRUD1.Queries;

namespace CRUD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            CreateBlogForm createBlogForm = new();
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

                CreateBlogForm createBlogForm = new();
                createBlogForm.Show();
                this.Hide();
            }

            //if(e.ColumnIndex == 5)
            //{
            //    try
            //    {
            //        DialogResult dialogResult = MessageBox.Show
            //        ("Are you sure delete it?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            //        if(dialogResult == DialogResult.OK)
            //        {
            //            string query =
            //            @"DELETE FROM Tbl_Blog WHERE BlogId = @BlogId";

            //            SqlParameter parameter = new SqlParameter("@BlogId", id);

            //            SqlConnection connection = new SqlConnection(DbConfig._connectionString);
            //            await connection.OpenAsync();

            //            SqlCommand command = new SqlCommand(query, connection);
            //            command.Parameters.Add(parameter);

            //            int result = await command.ExecuteNonQueryAsync();
            //            await connection.CloseAsync();

            //            if(result == 1)
            //            {
            //                MessageBox.Show("Deleting Successful.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //                await LoadData();
            //                return;
            //            }
            //            MessageBox.Show("Deleting Fail.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //        }
                   

            //    }catch(Exception ex)
            //    {
            //        throw new Exception(ex.Message);
            //    }
            //}


        }

        public async Task LoadData()
        {
            try
            {
                string query = BlogQuery.GetBlogListQuery;
                SqlConnection connection = new SqlConnection(DbConfig._connectionString);

                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                await connection.CloseAsync();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
