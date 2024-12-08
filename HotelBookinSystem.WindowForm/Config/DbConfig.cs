using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinSystem.WindowForm.Config
{
    public class DbConfig
    {
        public static string _connectionString { get; } =
            "Server=.;DataBase=HotelBookingSystem;User ID=sa;Password=sasa@123;TrustServerCertificate=True;";
    }
}
