using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinSystem.WindowForm.Query
{
    public class CustomerQuery
    {
        public static string GetCustomerQuery { get; } =
            @"SELECT CustomerId, FirstName, LastName, Phone, Email, Address 
             FROM Customer_Table ORDER BY CustomerId DESC";

        public static string UpdateCustomerQuery { get; } =
            @"UPDATE Customer_Table SET FirstName = @FirstName, LastName = @LastName,
              Phone = @Phone, Email = @Email, Address = @Address WHERE CustomerId = @CustomerId";
    }
}
