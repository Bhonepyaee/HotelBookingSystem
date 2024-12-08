 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinSystem.WindowForm.Query
{
    public class BookingQuery
    {
        public static string GetBookingQuery { get; } =
            @"SELECT BookingId, CustomerId, RoomId, CheckInDate, CheckOutDate, BookingDate, Status
             FROM Booking_Table ORDER BY BookingId DESC";
    }
}
