namespace HotelBookinSystem.WindowForm.Query;

public class RoomQuery
{
    public static string GetRoomQuery { get; } =
        @"SELECT RoomId, RoomNumber, RoomType, MaxOccupants, Availability
          FROM Room_Table ORDER BY RoomId DESC";
}
