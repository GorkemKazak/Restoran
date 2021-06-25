using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class frmGarsonSiparisPanel : Form
    {
        public frmGarsonSiparisPanel()
        {
            InitializeComponent();
        }
        sqlBaglanti sqlBaglanti = new sqlBaglanti();
        Garson.GarsonSiparisVT GarsonSiparisVT = new Garson.GarsonSiparisVT();
        public int GarsonID;
        int SiparisID;
        int KategoriID;
        string KategoriIsim;
        private void frmGarsonSiparisPanel_Load(object sender, EventArgs e)
        {
            dtgvUrunListesi.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dtgvUrunListesi.DefaultCellStyle.SelectionForeColor = Color.White;
            //GARSON ID
            lblGarsonIDdeger.Text = GarsonID.ToString();
            //SİPARİŞ ID ÇEKME
            SiparisID = GarsonSiparisVT.SiparisIDCek();
            //COMBOBOX ÜRÜN DOLDURMA
            for (int i = 1; i < 9; i++)
            {
                switch (i)
                {
                    case 1:
                        cmbEtler.Items.AddRange(GarsonSiparisVT.CmbDoldur(i));
                        break;
                    case 2:
                        cmbTavuklar.Items.AddRange(GarsonSiparisVT.CmbDoldur(i));
                        break;
                    case 3:
                        cmbBaliklar.Items.AddRange(GarsonSiparisVT.CmbDoldur(i));
                        break;
                    case 4:
                        cmbSalatalar.Items.AddRange(GarsonSiparisVT.CmbDoldur(i));
                        break;
                    case 5:
                        cmbPizzalar.Items.AddRange(GarsonSiparisVT.CmbDoldur(i));
                        break;
                    case 6:
                        cmbTatlilar.Items.AddRange(GarsonSiparisVT.CmbDoldur(i));
                        break;
                    case 7:
                        cmbIcecekler.Items.AddRange(GarsonSiparisVT.CmbDoldur(i));
                        break;
                    case 8:
                        cmbMakarnalar.Items.AddRange(GarsonSiparisVT.CmbDoldur(i));
                        break;
                }
            }
            dtgvUrunListesi.Columns.Add("Urunler", "Urunler");
            dtgvUrunListesi.Columns.Add("Adet", "Adet");
            dtgvUrunListesi.Columns.Add("Fiyatlar", "Fiyatlar");
            dtgvUrunListesi.Columns.Add("Kategori", "Kategori");
            dtgvUrunListesi.Columns.Add("ToplamFiyat", "Toplam Fiyat");
            dtgvUrunListesi.Columns.Add("KategoriID", "KategoriID");
            dtgvUrunListesi.Columns.Add("UrunID", "UrunID");
            dtgvUrunListesi.Columns[5].Visible = false;
            dtgvUrunListesi.Columns[6].Visible = false;
        }
        private void UrunBilgiAta(object sender, EventArgs e)
        {
            Garson.GarsonSiparisVT garsonSiparisVT = new Garson.GarsonSiparisVT();
            Button btn = (Button)sender;
            string[] UrunIsımdizi = new string[2];
            if (btn.Name == btnEtEkle.Name)
            {
                KategoriID = 1;
                KategoriIsim = "Et";
                UrunIsımdizi = cmbEtler.Text.Split(' ');

                ListeyeEkle(int.Parse(txEtAdet.Text), cmbEtler, KategoriIsim, KategoriID, garsonSiparisVT.UrunIDCek(UrunIsımdizi[0]));
            }
            else if (btn.Name == btnTavukEkle.Name)
            {
                KategoriID = 2;
                KategoriIsim = "Tavuk";
                UrunIsımdizi = cmbTavuklar.Text.Split(' ');
                ListeyeEkle(int.Parse(txTavukAdet.Text), cmbTavuklar, KategoriIsim, KategoriID, garsonSiparisVT.UrunIDCek(UrunIsımdizi[0]));
            }
            else if (btn.Name == btnBalikEkle.Name)
            {
                KategoriID = 3;
                KategoriIsim = "Balık";
                UrunIsımdizi = cmbBaliklar.Text.Split(' ');
                ListeyeEkle(int.Parse(txBalikAdet.Text), cmbBaliklar, KategoriIsim, KategoriID, garsonSiparisVT.UrunIDCek(UrunIsımdizi[0]));
            }
            else if (btn.Name == btnSalataEkle.Name)
            {
                KategoriID = 4;
                KategoriIsim = "Salata";
                UrunIsımdizi = cmbSalatalar.Text.Split(' ');
                ListeyeEkle(int.Parse(txSalataAdet.Text), cmbSalatalar, KategoriIsim, KategoriID, garsonSiparisVT.UrunIDCek(UrunIsımdizi[0]));
            }
            else if (btn.Name == btnPizzaEkle.Name)
            {
                KategoriID = 5;
                KategoriIsim = "Pizza";
                UrunIsımdizi = cmbPizzalar.Text.Split(' ');
                ListeyeEkle(int.Parse(txPizzaAdet.Text), cmbPizzalar, KategoriIsim, KategoriID, garsonSiparisVT.UrunIDCek(UrunIsımdizi[0]));
            }
            else if (btn.Name == btnTatliEkle.Name)
            {
                KategoriID = 6;
                KategoriIsim = "Tatlı";
                UrunIsımdizi = cmbTatlilar.Text.Split(' ');
                ListeyeEkle(int.Parse(txTatliAdet.Text), cmbTatlilar, KategoriIsim, KategoriID, garsonSiparisVT.UrunIDCek(UrunIsımdizi[0]));
            }
            else if (btn.Name == btnIcecekEkle.Name)
            {
                KategoriID = 7;
                KategoriIsim = "İçecek";
                UrunIsımdizi = cmbIcecekler.Text.Split(' ');
                ListeyeEkle(int.Parse(txIcecekAdet.Text), cmbIcecekler, KategoriIsim, KategoriID, garsonSiparisVT.UrunIDCek(UrunIsımdizi[0]));
            }
            else if (btn.Name == btnMakarnaEkle.Name)
            {
                KategoriID = 8;
                KategoriIsim = "Makarna";
                UrunIsımdizi = cmbMakarnalar.Text.Split(' ');
                ListeyeEkle(int.Parse(txMakarnaAdet.Text), cmbMakarnalar, KategoriIsim, KategoriID, garsonSiparisVT.UrunIDCek(UrunIsımdizi[0]));
            }
        }
        public void ListeyeEkle(int Adet, ComboBox cmb, string KategoriAdi, int KategoriID, int UrunID)
        {
            int toplam;
            string[] AdiveFiyat = new string[2];
            AdiveFiyat = cmb.Text.Split(' ');
            dtgvUrunListesi.Rows.Add();
            dtgvUrunListesi.Rows[dtgvUrunListesi.Rows.Count - 1].Cells[0].Value = AdiveFiyat[0];
            dtgvUrunListesi.Rows[dtgvUrunListesi.Rows.Count - 1].Cells[1].Value = Adet;
            dtgvUrunListesi.Rows[dtgvUrunListesi.Rows.Count - 1].Cells[2].Value = AdiveFiyat[1];
            dtgvUrunListesi.Rows[dtgvUrunListesi.Rows.Count - 1].Cells[3].Value = KategoriIsim;
            dtgvUrunListesi.Rows[dtgvUrunListesi.Rows.Count - 1].Cells[5].Value = KategoriID;
            dtgvUrunListesi.Rows[dtgvUrunListesi.Rows.Count - 1].Cells[6].Value = UrunID;
            toplam = int.Parse(AdiveFiyat[1]) * Adet;
            if (cbOgrencimi.Checked)
            {
                toplam = toplam - ((toplam * 25) / 100);
            }
            dtgvUrunListesi.Rows[dtgvUrunListesi.Rows.Count - 1].Cells[4].Value = toplam;
        }
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgvUrunListesi.Rows.Count; i++)
            {
                Garson.GarsonSiparis garsonSiparis = new Garson.GarsonSiparis();
                garsonSiparis.SiparisID = SiparisID;
                garsonSiparis.MusteriAdi = txMusteriAdi.Text;
                garsonSiparis.GarsonID = int.Parse(lblGarsonIDdeger.Text);
                garsonSiparis.Tarih = DateTime.Now;

                garsonSiparis.UrunID = int.Parse(dtgvUrunListesi.Rows[i].Cells[6].Value.ToString());
                garsonSiparis.Adet = int.Parse(dtgvUrunListesi.Rows[i].Cells[2].Value.ToString());
                garsonSiparis.ToplamFiyat = int.Parse(dtgvUrunListesi.Rows[i].Cells[4].Value.ToString());
                garsonSiparis.Indirim = cbOgrencimi.Checked;

                GarsonSiparisVT.Gonder(garsonSiparis);
            }

            SiparisID++;

        }



        //EVENTS
        private void pictureKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HarfEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void SayiEngelle(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }

        int Moves;
        int Mouse_X;
        int Mouse_Y;
        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            Moves = 0;
        }
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            Moves = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Moves == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void pictureAltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureGeri_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Close();
        }
    }
}
