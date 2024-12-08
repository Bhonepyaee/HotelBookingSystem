using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinSystem.WindowForm.Query
{
    public class RoomQuery
    {
        public static string GetRoomQuery { get; } =
         @"SELECT RoomId, RoomNumber, RoomType, MaxOccupants, Availability
          FROM Room_Table ORDER BY RoomId DESC";
    }
}
