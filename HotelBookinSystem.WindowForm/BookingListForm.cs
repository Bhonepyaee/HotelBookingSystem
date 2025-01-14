namespace HotelBookinSystem.WindowForm;

public partial class BookingListForm : Form
{
    public BookingListForm()
    {
        InitializeComponent();
    }

    private async void BookingListForm_Load(object sender, EventArgs e)
    {
        try
        {
            await LoadData();

            DataGridViewButtonColumn deleteBtn =
               new() { Text = "Change Status", UseColumnTextForButtonValue = true };
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
        BookingForm bookingForm = new BookingForm();
        bookingForm.Show();
        this.Hide();
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        MenuForm menuForm = new MenuForm();
        menuForm.Show();
        this.Hide();
    }

    private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

        if(e.ColumnIndex == 7)
        {
            string query = "UPDATE Room_Table SET Availability = 1 WHERE RoomId = @RoomId";
            SqlParameter parameter = new("@RoomId",id);
            SqlConnection connection = new SqlConnection(DbConfig._connectionString);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(parameter);

            int result = await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();

            if(result == 1)
            {
                MessageBox.Show("Room is available","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                await LoadData();
                return;
            }
           
        }
    }

    private async Task LoadData()
    {

        string query = BookingQuery.GetBookingQuery;

        SqlConnection connection = new SqlConnection(DbConfig._connectionString);
        await connection.OpenAsync();

        SqlCommand command = new SqlCommand(query, connection);
        SqlDataAdapter adapter = new SqlDataAdapter(command);

        DataTable dt = new DataTable();
        adapter.Fill(dt);

        await connection.CloseAsync();
        dataGridView1.DataSource = dt;
    }
}
