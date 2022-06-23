using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
   public class Sql_Connection
    {
        public SqlConnection Connection ()
        {
             SqlConnection connect = new SqlConnection (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
