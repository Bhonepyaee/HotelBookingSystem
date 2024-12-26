namespace HotelBookinSystem.WindowForm.Query;

public class BookingQuery
{
    public static string GetBookingQuery { get; } =
        @"SELECT BookingId, CustomerId, RoomId, CheckInDate, CheckOutDate, BookingDate, Status
             FROM Booking_Table ORDER BY BookingId DESC";
}
