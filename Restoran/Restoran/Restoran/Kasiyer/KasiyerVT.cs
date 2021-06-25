using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restoran.Kasiyer
{
    class KasiyerVT
    {
        sqlBaglanti sqlBaglanti = new sqlBaglanti();
        public DataTable Siparisler()
        {
            SqlCommand SiparisleriCek = new SqlCommand("select S.SiparisID,sum(ToplamFiyat) as 'Toplam Tutar' from Siparisler s inner join SiparisDetay sd on s.SiparisID = sd.SiparisID group by s.SiparisID ", sqlBaglanti.Baglan());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SiparisleriCek);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            sqlBaglanti.Baglan().Close();
            return dataTable;
        }
        public DataTable Siparisler(long SiparisID)
        {
            SqlCommand SiparisleriCek = new SqlCommand("select S.SiparisID,sum(ToplamFiyat) as 'Toplam Tutar' from Siparisler s inner join SiparisDetay sd on s.SiparisID = sd.SiparisID where s.SiparisID = @p1 group by s.SiparisID ", sqlBaglanti.Baglan());
            SiparisleriCek.Parameters.AddWithValue("@p1", SiparisID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SiparisleriCek);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            sqlBaglanti.Baglan().Close();
            return dataTable;
        }

        public DataTable DetayGoruntule(long SiparisID)
        {
            SqlCommand DetayGor = new SqlCommand("select s.SiparisID,u.UrunAdi,u.UrunFiyat,sd.Adet,sd.ToplamFiyat,sd.Indırım from Siparisler s inner join SiparisDetay sd on s.SiparisID = sd.SiparisID inner join Urunler u on sd.UrunID = u.UrunID where s.SiparisID=@p1",sqlBaglanti.Baglan());
            DetayGor.Parameters.AddWithValue("@p1",SiparisID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(DetayGor);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            sqlBaglanti.Baglan().Close();
            return dataTable;
        }

    }
}
