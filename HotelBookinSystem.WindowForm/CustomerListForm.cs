using System.Data;
using System.Data.SqlClient;
using HotelBookinSystem.WindowForm.Config;
using HotelBookinSystem.WindowForm.Query;

namespace HotelBookinSystem.WindowForm;

public partial class CustomerListForm : Form
{
    public CustomerListForm()
    {
        InitializeComponent();
    }


    private async void label1_Click(object sender, EventArgs e)
    {

    }

    private async void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
    {
        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

        if (e.ColumnIndex == 6)
        {
            string firstName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value)!;
            string lastName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value)!;
            string phoneNo = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value)!;
            string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value)!;
            string address = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value)!;

            UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(id, firstName, lastName, phoneNo, email, address);
            updateCustomerForm.Show();
            this.Hide();

        }

        if (e.ColumnIndex == 7)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you deleting that?", "Warninig!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK)
                {
                    string query =
                        @"DELETE FROM Customer_Table WHERE CustomerId = @CustomerId";
                    SqlParameter parameter = new SqlParameter("@CustomerId", id);

                    SqlConnection connection = new SqlConnection(DbConfig._connectionString);
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add(parameter);

                    int result = await command.ExecuteNonQueryAsync();
                    await connection.CloseAsync();

                    if (result > 0)
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

    private async void CustomerListForm_Load(object sender, EventArgs e)
    {
        try
        {
            await LoadData();

            DataGridViewButtonColumn editBtn =
                new() { Text = "Edit", UseColumnTextForButtonValue = true };
            editBtn.DefaultCellStyle.BackColor = Color.Green;
            dataGridView1.Columns.Add(editBtn);

            DataGridViewButtonColumn deleteBtn =
                new() { Text = "Delete", UseColumnTextForButtonValue = true };
            deleteBtn.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Columns.Add(deleteBtn);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private void btn_create_Click(object sender, EventArgs e)
    {
        CreatCustomerForm creatCustomerForm = new CreatCustomerForm();
        creatCustomerForm.Show();
        this.Hide();
    }

    private async Task LoadData()
    {
        string query = CustomerQuery.GetCustomerQuery;
        SqlConnection connection = new SqlConnection(DbConfig._connectionString);
        await connection.OpenAsync();

        SqlCommand command = new SqlCommand(query, connection);

        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataTable dt = new();
        adapter.Fill(dt);

        await connection.CloseAsync();
        dataGridView1.DataSource = dt;
    }

    private void button6_Click(object sender, EventArgs e)
    {

    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        MenuForm menuForm = new MenuForm();
        menuForm.Show();
        this.Hide();
    }
}
