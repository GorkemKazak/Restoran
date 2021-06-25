using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace Restoran.Yetkili
{
    class CalisanIslemleriVT
    {
        sqlBaglanti sqlBaglanti = new sqlBaglanti();
        public DataTable Listele(bool istencikanlar)
        {
            SqlCommand listele = new SqlCommand("select Kullanicilar.KullaniciID,Kullanicilar.KullaniciAdi,Kullanicilar.KullaniciSifre,Roller.RolAdi,KullaniciDetay.Adi,KullaniciDetay.Soyadi,KullaniciDetay.TelefonNo,KullaniciDetay.Email,KullaniciDetay.Adres,Kullanicilar.IstenCiktimi from KullaniciDetay RIGHT Join Kullanicilar on KullaniciDetay.KullaniciID = Kullanicilar.KullaniciID INNER JOIN Roller on Roller.RolID = Kullanicilar.RolID where IstenCiktimi=@p1", sqlBaglanti.Baglan());
            listele.Parameters.AddWithValue("@p1", istencikanlar);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(listele);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            sqlBaglanti.Baglan().Close();
            return dataTable;
        }
        public void Guncelle(CalisanIslemleri calisan, int CalisanID)
        {
            SqlCommand Kguncelle = new SqlCommand("update Kullanicilar set KullaniciAdi=@p1,KullaniciSifre=@p2,RolID=@p3 where KullaniciID=@p4", sqlBaglanti.Baglan());
            Kguncelle.Parameters.AddWithValue("@p1", calisan.KullaniciAdi);
            Kguncelle.Parameters.AddWithValue("@p2", calisan.Sifre);
            Kguncelle.Parameters.AddWithValue("@p3", calisan.Rol);
            Kguncelle.Parameters.AddWithValue("@p4", CalisanID);
            Kguncelle.ExecuteNonQuery();

            SqlCommand KDetayguncelle = new SqlCommand("update KullaniciDetay set Adi = @p1, Soyadi = @p2, TelefonNo = @p3, Email = @p4, Adres = @p5 where KullaniciID=@p6", sqlBaglanti.Baglan());
            KDetayguncelle.Parameters.AddWithValue("@p1", calisan.Ad);
            KDetayguncelle.Parameters.AddWithValue("@p2", calisan.Soyad);
            KDetayguncelle.Parameters.AddWithValue("@p3", calisan.TelNo);
            KDetayguncelle.Parameters.AddWithValue("@p4", calisan.Email);
            KDetayguncelle.Parameters.AddWithValue("@p5", calisan.Adres);
            KDetayguncelle.Parameters.AddWithValue("@p6", CalisanID);
            KDetayguncelle.ExecuteNonQuery();
            sqlBaglanti.Baglan().Close();
        }
        public void Sil(bool IstenCiktimi, int KullaniciID)
        {
            SqlCommand sil = new SqlCommand("update Kullanicilar set IstenCiktimi=@p1 where KullaniciID=@p2", sqlBaglanti.Baglan());
            if (IstenCiktimi == false)
            {
                sil.Parameters.AddWithValue("@p1", true);
            }
            sil.Parameters.AddWithValue("@p2", KullaniciID);
            sil.ExecuteNonQuery();
            sqlBaglanti.Baglan().Close();
        }
        public void Ekle(CalisanIslemleri calisan)
        {
            sqlBaglanti sqlBaglanti = new sqlBaglanti();         
            



            SqlCommand Kullaniciekle = new SqlCommand("insert into Kullanicilar (KullaniciAdi,KullaniciSifre,RolID) Values(@p1, @p2, @p3)", sqlBaglanti.Baglan());
            Kullaniciekle.Parameters.AddWithValue("@p1", calisan.KullaniciAdi);
            Kullaniciekle.Parameters.AddWithValue("@p2", calisan.Sifre);
            Kullaniciekle.Parameters.AddWithValue("@p3", calisan.Rol);
            Kullaniciekle.ExecuteNonQuery();

            SqlCommand KullaniciDetayEkle = new SqlCommand("insert into KullaniciDetay (Adi,Soyadi,TelefonNo,Email,Adres) Values (@p1,@p2,@p3,@p4,@p5)", sqlBaglanti.Baglan());

            KullaniciDetayEkle.Parameters.AddWithValue("@p1", calisan.Ad);
            KullaniciDetayEkle.Parameters.AddWithValue("@p2", calisan.Soyad);
            KullaniciDetayEkle.Parameters.AddWithValue("@p3", calisan.TelNo);
            KullaniciDetayEkle.Parameters.AddWithValue("@p4", calisan.Email);
            KullaniciDetayEkle.Parameters.AddWithValue("@p5", calisan.Adres);

            KullaniciDetayEkle.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı başarıyla eklendi");
            sqlBaglanti.Baglan().Close();

        }
    }
}
