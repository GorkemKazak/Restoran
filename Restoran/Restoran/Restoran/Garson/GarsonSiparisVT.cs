using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restoran.Garson
{
    class GarsonSiparisVT
    {
        sqlBaglanti sqlBaglanti = new sqlBaglanti();
        public int SiparisIDCek()
        {
            SqlCommand SiparisIDCek = new SqlCommand("select max(SiparisID) from Siparisler", sqlBaglanti.Baglan());
            SqlDataReader IDoku = SiparisIDCek.ExecuteReader();
            while (IDoku.Read())
            {
                return int.Parse(IDoku[0].ToString())+1;
            }
            return 0;
        }
        public string[] CmbDoldur(int KategoriID)
        {
            string[] Urun = new string[2];
            List<string> Urunler = new List<string>();
            SqlCommand doldur = new SqlCommand("select UrunAdi,UrunFiyat from Urunler where KategoriID='" + KategoriID + "'", sqlBaglanti.Baglan());
            SqlDataReader oku = doldur.ExecuteReader();

            while (oku.Read())
            {
                Urun[0] = oku["UrunAdi"].ToString();
                Urun[1] = oku["UrunFiyat"].ToString();
                Urunler.Add(Urun[0] + " " + Urun[1]);
            }
            return Urunler.ToArray();
        }
        public int UrunIDCek(string UrunIsım)
        {
            SqlCommand IDCek = new SqlCommand("Select UrunID from Urunler where UrunAdi='" + UrunIsım + "'", sqlBaglanti.Baglan());
            SqlDataReader IDOku = IDCek.ExecuteReader();
            while (IDOku.Read())
            {
                return int.Parse(IDOku[0].ToString());
            }
            sqlBaglanti.Baglan().Close();
            return 0;
        
        }

        public void Gonder(GarsonSiparis Siparis)
        {
            SqlCommand SiparisEkle = new SqlCommand("insert into Siparisler (MusteriAdi,GarsonID,Tarih) values (@p1,@p2,@p3)",sqlBaglanti.Baglan());
            SiparisEkle.Parameters.AddWithValue("@p1", Siparis.MusteriAdi);
            SiparisEkle.Parameters.AddWithValue("@p2", Siparis.GarsonID);
            SiparisEkle.Parameters.AddWithValue("@p3", DateTime.Now);
            SiparisEkle.ExecuteNonQuery();

            SqlCommand SiparisDetayEkle = new SqlCommand("insert into SiparisDetay (SiparisID,UrunID,Adet,ToplamFiyat,Indırım) values(@p1,@p2,@p3,@p4,@p5)",sqlBaglanti.Baglan());
            SiparisDetayEkle.Parameters.AddWithValue("@p1", Siparis.SiparisID);
            SiparisDetayEkle.Parameters.AddWithValue("@p2",Siparis.UrunID);
            SiparisDetayEkle.Parameters.AddWithValue("@p3",Siparis.Adet);
            SiparisDetayEkle.Parameters.AddWithValue("@p4",Siparis.ToplamFiyat);
            SiparisDetayEkle.Parameters.AddWithValue("@p5",Siparis.Indirim);
            SiparisDetayEkle.ExecuteNonQuery();
            sqlBaglanti.Baglan().Close();
        }
    }
}
