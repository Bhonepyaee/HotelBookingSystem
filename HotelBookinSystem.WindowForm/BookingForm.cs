using System.Data.SqlClient;
using HotelBookinSystem.WindowForm.Services;

namespace HotelBookinSystem.WindowForm;

public partial class BookingForm : Form
{
    internal readonly AdoDotNetService _service;
    public BookingForm()
    {
        InitializeComponent();
        _service = new();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
            string customerId = txtCustomerId.Text;
            string roomId = txtRoomId.Text;
            string checkInDate = txtCheckInDate.Text;
            string checkOutDate = txtCheckOutDate.Text;
            string bookingDate = txtBookingDate.Text;
            string status = txtStatus.Text;

            #region Check Room Available

            string checkRoomAvailableQuery = "SELECT Availability FROM Room_Table WHERE RoomId = @RoomId";
            var checkRoomAvailableParameters = new[]
            {
                new SqlParameter("@RoomId", roomId)
            };
            var checkRoomAvailableDt = await _service.QueryFirstOrDefaultAsync(checkRoomAvailableQuery, checkRoomAvailableParameters);

            if (checkRoomAvailableDt.Rows.Count == 0)
            {
                MessageBox.Show("Room is not available for booking now", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            #region Book

            string query =
             @"INSERT INTO Booking_Table(CustomerId, RoomId, CheckInDate, CheckOutDate, BookingDate, Status)
                    VALUES(@CustomerId, @RoomId, @CheckInDate, @CheckOutDate, @BookingDate, @Status)";

            List<SqlParameter> parameters = new()
            {
                new("@CustomerId",customerId),
                new("@RoomId",roomId),
                new("@CheckInDate",checkInDate),
                new("@CheckOutDate",checkOutDate),
                new("@BookingDate",bookingDate),
                new("@Status",status)
            };
            int createBookingResult = await _service.ExecuteAsync(query, parameters.ToArray());

            if (createBookingResult <= 0)
            {
                MessageBox.Show("Creating Booking Fail.");
                return;
            }

            #endregion

            #region Update Availability

            string updateRoomQuery = "UPDATE Room_Table SET Availability = 0 WHERE RoomId = @RoomId";
            List<SqlParameter> updateRoomParameters = new()
            {
                new("@RoomId", roomId),
                new("@Availability", 0)
            };
            int updateRoomResult = await _service.ExecuteAsync(updateRoomQuery, updateRoomParameters.ToArray());

            if (updateRoomResult <= 0)
            {
                MessageBox.Show("Booking Fail.");
                return;
            }

            #endregion

            if (createBookingResult > 1 && updateRoomResult > 1)
            {
                MessageBox.Show("Saving Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BookingListForm bookingListForm = new BookingListForm();
                bookingListForm.Show();
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
        BookingListForm bookingListForm = new BookingListForm();
        bookingListForm.Show();
        this.Hide();
    }
}
