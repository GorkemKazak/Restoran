using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restoran
{
    class sqlBaglanti
    {
        public SqlConnection Baglan()
        {
           SqlConnection baglanti = new SqlConnection(@"Data Source=APEX\APEX;Initial Catalog=Restoran;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
