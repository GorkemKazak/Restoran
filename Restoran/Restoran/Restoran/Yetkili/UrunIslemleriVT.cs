using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
namespace Restoran.Yetkili
{
    class UrunIslemleriVT
    {
        sqlBaglanti sqlBaglanti = new sqlBaglanti();
        public void Ekle(UrunIslemleri urun)
        {
            SqlCommand ekle = new SqlCommand("Insert into Urunler (UrunAdi,UrunFiyat,KategoriID) values (@p1,@p2,@p3)",sqlBaglanti.Baglan());
            ekle.Parameters.AddWithValue("@p1", urun.UrunAdi);
            ekle.Parameters.AddWithValue("@p2", urun.UrunFiyati);
            ekle.Parameters.AddWithValue("@p3", urun.UrunKategorisi);
            ekle.ExecuteNonQuery();
            sqlBaglanti.Baglan().Close();
        }
        public void Sil(int UrunID,bool Silindimi)
        {
            SqlCommand sil = new SqlCommand("Update Urunler set SatisIptal=@p1 where UrunID=@p2", sqlBaglanti.Baglan());
            sil.Parameters.AddWithValue("@p1", Silindimi);
            sil.Parameters.AddWithValue("@p2", UrunID);
            sil.ExecuteNonQuery();
        }
        public void Guncelle(UrunIslemleri urun)
        {
            SqlCommand guncelle = new SqlCommand("update Urunler set UrunAdi=@p1, UrunFiyat=@p2,KategoriID=@p3 where UrunID=@P4",sqlBaglanti.Baglan());
            guncelle.Parameters.AddWithValue("@p1", urun.UrunAdi);
            guncelle.Parameters.AddWithValue("@p2", urun.UrunFiyati);
            guncelle.Parameters.AddWithValue("@p3", urun.UrunKategorisi);
            guncelle.Parameters.AddWithValue("@p4", urun.UrunID);
            guncelle.ExecuteNonQuery();
        }
        public DataTable Listele(bool SatisIptal)
        {
            SqlCommand listele = new SqlCommand("select UrunID,UrunAdi,UrunFiyat,Kategoriler.KategoriAdi,Urunler.SatisIptal  from Urunler inner join Kategoriler on urunler.KategoriID=Kategoriler.KategoriID where SatisIptal=@p1", sqlBaglanti.Baglan());
            listele.Parameters.AddWithValue("@p1", SatisIptal);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listele);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable Ara(string UrunAdi,bool SatisIptal)
        {
            SqlCommand ara = new SqlCommand("select UrunID,UrunAdi,UrunFiyat,Kategoriler.KategoriAdi from Urunler inner join Kategoriler on urunler.KategoriID=Kategoriler.KategoriID where SatisIptal=@p1 and UrunAdi like '%"+UrunAdi+"%'", sqlBaglanti.Baglan());
            ara.Parameters.AddWithValue("@p1", SatisIptal);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ara);
            DataTable aramasonucu = new DataTable();
            dataAdapter.Fill(aramasonucu);
            sqlBaglanti.Baglan().Close();
            return aramasonucu;
        }
        public string[] KategoriCek()
        {
            List<string> Kategoriler = new List<string>();

            SqlCommand kategoriCek = new SqlCommand("select KategoriAdi from Kategoriler", sqlBaglanti.Baglan());
            SqlDataReader kategoriOku = kategoriCek.ExecuteReader();
            while (kategoriOku.Read())
            {
                Kategoriler.Add(kategoriOku[0].ToString());
            }
            sqlBaglanti.Baglan().Close();
            return Kategoriler.ToArray();
           
        }
            
    }
    
}
