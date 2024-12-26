using System.Data.SqlClient;
using HotelBookinSystem.WindowForm.Config;

namespace HotelBookinSystem.WindowForm
{
    public partial class CreatCustomerForm : Form
    {
        public CreatCustomerForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string phoneNo = txtPhoneNo.Text;
                string email = txtEmail.Text;
                string address = txtEmail.Text;
                string dateOfBirth = txtDateOfBirth.Text;


                string query =
                    @"INSERT INTO Customer_Table(FirstName, LastName, Phone, Email, Address, DateOfBirth)
                      VALUES(@FirstName, @LastName, @Phone, @Email, @Address, @DateOfBirth)";

                List<SqlParameter> parameters = new()
                {
                    new("@FirstName",firstName),
                    new("@LastName",lastName),
                    new("@Phone",phoneNo),
                    new("@Email",email),
                    new("@Address",address),
                    new("@DateOfBirth",dateOfBirth)

                };

                SqlConnection connection = new SqlConnection(DbConfig._connectionString);
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(parameters.ToArray());

                int result = await command.ExecuteNonQueryAsync();
                await connection.CloseAsync();

                if (result == 1)
                {
                    MessageBox.Show("Saving Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CustomerListForm customerListForm = new();
                    customerListForm.Show();
                    this.Hide();

                    return;
                }
                MessageBox.Show("Saving Fail.", "Fail", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CreatCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerListForm customerListForm = new CustomerListForm();
            customerListForm.Show();
            this.Hide();
        }
    }
}
