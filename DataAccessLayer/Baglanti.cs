using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-HBC1R06;Initial Catalog=DB_Personel;Integrated Security=True");
    }
}
