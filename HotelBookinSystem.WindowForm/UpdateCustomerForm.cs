namespace HotelBookinSystem.WindowForm;

public partial class UpdateCustomerForm : Form
{
    private readonly int _customerId;
    private readonly string _firstName = string.Empty;
    private readonly string _lastName = string.Empty;
    private readonly string _phoneNo = string.Empty;
    private readonly string _email = string.Empty;
    private readonly string _address = string.Empty;
    private readonly string _dateOfBirth = string.Empty;

    public UpdateCustomerForm(
        int customerId,
        string firstName,
        string lastName,
        string phoneNo,
        string email,
        string address
    )
    {
        InitializeComponent();
        _firstName = firstName;
        _lastName = lastName;
        _phoneNo = phoneNo;
        _email = email;
        _address = address;
        _customerId = customerId;
    }

    private void UpdateCustomerForm_Load(object sender, EventArgs e)
    {
        txtFirstName.Text = _firstName;
        txtLastName.Text = _lastName;
        txtPhoneNo.Text = _phoneNo;
        txtEmail.Text = _email;
        txtAddress.Text = _address;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        CustomerListForm customerListForm = new CustomerListForm();
        customerListForm.Show();
        this.Hide();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNo = txtPhoneNo.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            string query = CustomerQuery.UpdateCustomerQuery;
            List<SqlParameter> parameters = new()
            {
                new("@CustomerId", _customerId),
                new("@FirstName", firstName),
                new("@LastName", lastName),
                new("@Phone", phoneNo),
                new("@Email", email),
                new("@Address", address),
            };

            SqlConnection connection = new(DbConfig._connectionString);
            await connection.OpenAsync();

            SqlCommand command = new(query, connection);
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

                CustomerListForm customerListForm = new();
                customerListForm.Show();
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
}
