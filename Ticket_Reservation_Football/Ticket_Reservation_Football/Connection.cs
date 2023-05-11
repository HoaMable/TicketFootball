using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticket_Reservation_Football
{
    class Connection
    {
       static string strConnectionString = @"Data Source=HOAPRO\SQLEXPRESS;Initial Catalog=UEFA_Ticket;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnectionString);
        }
    }
}
