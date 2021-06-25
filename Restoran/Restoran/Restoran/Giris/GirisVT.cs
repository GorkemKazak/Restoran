using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restoran.Giris
{
    class GirisVT
    {
        sqlBaglanti sqlBaglanti = new sqlBaglanti();
        public int GirisYap(string KullaniciAdi,string Sifre)
        {

           
            SqlCommand girisYap = new SqlCommand("select *from Kullanicilar where KullaniciAdi=@p1 and KullaniciSifre=@p2", sqlBaglanti.Baglan());
            girisYap.Parameters.AddWithValue("@p1", KullaniciAdi);
            girisYap.Parameters.AddWithValue("@p2", Sifre);

            using (var oku = girisYap.ExecuteReader())
            {
                if (oku.HasRows)
                {
                    while (oku.Read())
                    {
                        return int.Parse(oku["RolID"].ToString());
                    }
                    sqlBaglanti.Baglan().Close();
                    return 0;
                }
                else
                {
                    sqlBaglanti.Baglan().Close();
                    return 0;
                }
            }

            
        }
        public int GarsonIDSorgula(string Kadi, string Ksifre)
        {
            SqlCommand garsonIDSorgula = new SqlCommand("select KullaniciID from Kullanicilar where KullaniciAdi=@p1 and KullaniciSifre=@p2", sqlBaglanti.Baglan());
            SqlParameter p1 = new SqlParameter("@p1", Kadi);
            SqlParameter p2 = new SqlParameter("@p2", Ksifre);
            garsonIDSorgula.Parameters.Add(p1);
            garsonIDSorgula.Parameters.Add(p2);
            SqlDataReader IDoku = garsonIDSorgula.ExecuteReader();
            while (IDoku.Read())
            {
                return int.Parse(IDoku[0].ToString());
            }
            sqlBaglanti.Baglan().Close();
            return 0;

        }
    }
}
