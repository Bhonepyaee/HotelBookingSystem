namespace HotelBookinSystem.WindowForm;

public partial class RoomForm : Form
{
    public RoomForm()
    {
        InitializeComponent();
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
            string roomNumber = txtRoomNumber.Text;
            string roomType = txtRoomType.Text;
            string maxOccupants = txtMaxOccupants.Text;

            string query =
              @"INSERT INTO Room_Table(RoomNumber, RoomType, MaxOccupants)
                    VALUES(@RoomNumber, @RoomType, @MaxOccupants)";

            List<SqlParameter> parameters = new()
            {
                new("@RoomNumber",roomNumber),
                new("@RoomType",roomType),
                new("@MaxOccupants",maxOccupants)
            };

            SqlConnection connection = new SqlConnection(DbConfig._connectionString);
            await connection.OpenAsync();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters.ToArray());

            int result = await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();

            if (result > 0)
            {
                MessageBox.Show("Saving Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RoomListForm roomListForm = new RoomListForm();
                roomListForm.Show();
                this.Hide();
                return;
            }
            MessageBox.Show(
              "Saving Fail.",
               "Fail",
               MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        RoomListForm roomListForm = new RoomListForm();
        roomListForm.Show();
        this.Hide();
    }

    private void RoomForm_Load(object sender, EventArgs e)
    {

    }
}
