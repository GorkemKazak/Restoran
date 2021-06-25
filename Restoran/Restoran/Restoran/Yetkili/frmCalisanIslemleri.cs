using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Restoran.Giris;
namespace Restoran.Yetkili
{
    public partial class frmCalisanIslemleri : Form
    {
        CalisanIslemleriVT CalisanIslemleriVT = new CalisanIslemleriVT();
        int secilenID;
        bool IstenCiktimi;
        public frmCalisanIslemleri()
        {
            InitializeComponent();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            CalisanIslemleriVT.Sil(IstenCiktimi,secilenID);
            dtgvListe.DataSource = CalisanIslemleriVT.Listele(chxIstenCikanlariListele.Checked);
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            dtgvListe.DataSource=CalisanIslemleriVT.Listele(chxIstenCikanlariListele.Checked);
        }

        private void dtgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = int.Parse(dtgvListe.CurrentRow.Cells[0].Value.ToString());
            IstenCiktimi = Convert.ToBoolean(dtgvListe.CurrentRow.Cells[9].Value.ToString());
            
            txKullaniciAdi.Text = dtgvListe.CurrentRow.Cells[1].Value.ToString();
            txSifre.Text = dtgvListe.CurrentRow.Cells[2].Value.ToString();
            cmbRol.Text = dtgvListe.CurrentRow.Cells[3].Value.ToString();
            txAdSoyad.Text = dtgvListe.CurrentRow.Cells[4].Value.ToString() + " " + dtgvListe.CurrentRow.Cells[5].Value.ToString();
            msktxTelefonNo.Text = dtgvListe.CurrentRow.Cells[6].Value.ToString();
            txEmail.Text = dtgvListe.CurrentRow.Cells[7].Value.ToString();
            chxCikisDurumu.Checked = Convert.ToBoolean(dtgvListe.CurrentRow.Cells[9].Value.ToString());
            txAdres.Text = dtgvListe.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CalisanIslemleri calisan = new CalisanIslemleri();
            CalisanIslemleriVT calisanIslemleriVT = new CalisanIslemleriVT();

            calisan.KullaniciAdi = txKullaniciAdi.Text;
            calisan.Sifre = txSifre.Text;
            calisan.Rol = cmbRol.SelectedIndex + 1;           
            string[] advesoyad = new string[2];
            advesoyad = txAdSoyad.Text.Split(' ');
            calisan.Ad = advesoyad[0];
            calisan.Soyad = advesoyad[1];
            calisan.TelNo = msktxTelefonNo.Text;
            calisan.Email = txEmail.Text;
            calisan.CikisDurumu = chxCikisDurumu.Checked;
            calisan.Adres = txAdres.Text;
            calisanIslemleriVT.Ekle(calisan);
            dtgvListe.DataSource = CalisanIslemleriVT.Listele(chxIstenCikanlariListele.Checked);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CalisanIslemleri calisan = new CalisanIslemleri();
            calisan.KullaniciAdi = txKullaniciAdi.Text;
            calisan.Sifre = txSifre.Text;
            calisan.Rol = cmbRol.SelectedIndex + 1;
            string adsoyad = txAdSoyad.Text;
            string[] advesoyad = new string[2];
            advesoyad = adsoyad.Split(' ');
            calisan.Ad = advesoyad[0];
            calisan.Soyad = advesoyad[1];
            calisan.TelNo = msktxTelefonNo.Text;
            calisan.Email = txEmail.Text;
            calisan.CikisDurumu = chxCikisDurumu.Checked;
            calisan.Adres = txAdres.Text;
            CalisanIslemleriVT.Guncelle(calisan, secilenID);
            dtgvListe.DataSource = CalisanIslemleriVT.Listele(chxIstenCikanlariListele.Checked);

        }

        //EVENTS
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
        private void pictureKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureAltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureGeri_Click(object sender, EventArgs e)
        {
            frmYetkiliPanel frmYetkiliPanel = new frmYetkiliPanel();
            frmYetkiliPanel.Show();
            this.Close();
        }

        private void frmCalisanIslemleri_Load(object sender, EventArgs e)
        {
            dtgvListe.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235,222,180);
            dtgvListe.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
