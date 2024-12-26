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
using HotelBookinSystem.WindowForm.Config;
using HotelBookinSystem.WindowForm.Services;

namespace HotelBookinSystem.WindowForm
{
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

                string updateRoomQuery = "UPDATE Room_Table SET Availability = 0 WHERE RoomId = @RoomId";
                SqlConnection connection2 = new SqlConnection(DbConfig._connectionString);
                await connection2.OpenAsync();

                SqlCommand command2 = new(updateRoomQuery, connection2);
                command2.Parameters.AddWithValue("@Availability", 0);
                int result = await command2.ExecuteNonQueryAsync();
                if (result == 1)
                {
                    MessageBox.Show("");
                }

                await connection2.CloseAsync();


                SqlConnection connection1 = new SqlConnection(DbConfig._connectionString);
                await connection1.OpenAsync();

                SqlCommand command1 = new SqlCommand(query, connection1);
                command1.Parameters.AddRange(parameters.ToArray());

                int result1 = await command1.ExecuteNonQueryAsync();
                await connection1.CloseAsync();

                if (result1 == 1)
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
}
