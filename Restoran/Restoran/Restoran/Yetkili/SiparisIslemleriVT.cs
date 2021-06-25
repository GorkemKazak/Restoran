using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restoran.Yetkili
{
    class SiparisIslemleriVT
    {
        sqlBaglanti sqlBaglanti = new sqlBaglanti();
        public DataTable TumSiparisleriGoruntule()
        {
            SqlCommand DetayGor = new SqlCommand("select s.SiparisID,kd.Adi as 'Garson Adı',u.UrunAdi,sd.Adet,sd.ToplamFiyat,sd.Indırım from Siparisler s inner join SiparisDetay sd on s.SiparisID = sd.SiparisID inner join Urunler u on sd.UrunID = u.UrunID inner join Kullanicilar k on s.GarsonID = k.KullaniciID inner join KullaniciDetay kd on k.KullaniciID = kd.KullaniciID", sqlBaglanti.Baglan());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(DetayGor);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            sqlBaglanti.Baglan().Close();
            return dataTable;
        }
        public DataTable TumSiparisleriGoruntule(long SiparisID)
        {
            SqlCommand DetayGor = new SqlCommand("select s.SiparisID,kd.Adi as 'Garson Adı',u.UrunAdi,sd.Adet,sd.ToplamFiyat,sd.Indırım from Siparisler s inner join SiparisDetay sd on s.SiparisID = sd.SiparisID inner join Urunler u on sd.UrunID = u.UrunID inner join Kullanicilar k on s.GarsonID = k.KullaniciID inner join KullaniciDetay kd on k.KullaniciID = kd.KullaniciID where s.SiparisID=@p1", sqlBaglanti.Baglan());
            DetayGor.Parameters.AddWithValue("@p1", SiparisID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(DetayGor);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            sqlBaglanti.Baglan().Close();
            return dataTable;
        }
        //public int ToplamGelirGoster()
        //{
        //    SqlCommand ToplamGelirGor = new SqlCommand("select sum(ToplamFiyat) from Siparisler s inner join SiparisDetay sd on s.SiparisID = sd.SiparisID inner join Urunler u on sd.UrunID = u.UrunID inner join Kullanicilar k on s.GarsonID = k.KullaniciID inner join KullaniciDetay kd on k.KullaniciID = kd.KullaniciID ", sqlBaglanti.Baglan());
        //    SqlDataReader gelirOku = ToplamGelirGor.ExecuteReader();
        //    while (gelirOku.Read())
        //    {
        //        return int.Parse(gelirOku[0].ToString());
        //    }
        //    return 0;

        //}
        
    }
}
