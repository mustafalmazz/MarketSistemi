using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace MarketSistemi.Classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection connect = new SqlConnection("Data Source =DESKTOP-I5GQS4M\\SQLEXPRESS; Initial Catalog=MarketDb; Integrated Security=True; Encrypt=False;TrustServerCertificate=True");

        public static void CheckConneciton(SqlConnection tempConneciton)
        {
            if (tempConneciton.State == System.Data.ConnectionState.Closed)
            {
                tempConneciton.Open();
            }
            else
            {

            }
        }
    }
}
