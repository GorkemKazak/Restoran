using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran.Yetkili
{
    public partial class frmUrunIslemleri : Form
    {
        public frmUrunIslemleri()
        {
            InitializeComponent();
        }
        UrunIslemleriVT urunIslemleriVT = new UrunIslemleriVT();
        int SecilenUrunID;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunIslemleri urun = new UrunIslemleri();
            urun.UrunAdi = txUrunAdi.Text;
            urun.UrunKategorisi = cmbUrunKategorisi.SelectedIndex + 1;
            urun.UrunFiyati = txUrunFiyati.Text;
            urunIslemleriVT.Ekle(urun);
            dtgvUrunListesi.DataSource = urunIslemleriVT.Listele(cbSatisIptal.Checked);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dtgvUrunListesi.CurrentRow.Cells[4].Value.ToString()) == false)
                urunIslemleriVT.Sil(SecilenUrunID, true);

            else
                urunIslemleriVT.Sil(SecilenUrunID, false);

            dtgvUrunListesi.DataSource = urunIslemleriVT.Listele(cbSatisIptal.Checked);

        }

        private void dtgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenUrunID = int.Parse(dtgvUrunListesi.CurrentRow.Cells[0].Value.ToString());
            txUrunAdi.Text = dtgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
            cmbUrunKategorisi.SelectedItem= dtgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
            txUrunFiyati.Text= dtgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
            cbSatisIptal.Checked = Convert.ToBoolean(dtgvUrunListesi.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunIslemleri urun = new UrunIslemleri();
            urun.UrunID = SecilenUrunID;
            urun.UrunAdi = txUrunAdi.Text;
            urun.UrunKategorisi = cmbUrunKategorisi.SelectedIndex + 1;
            urun.UrunFiyati = txUrunFiyati.Text;
            urunIslemleriVT.Guncelle(urun);
            dtgvUrunListesi.DataSource = urunIslemleriVT.Listele(cbSatisIptal.Checked);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dtgvUrunListesi.DataSource = urunIslemleriVT.Listele(cbSatisIptal.Checked);
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            dtgvUrunListesi.DataSource=urunIslemleriVT.Ara(txUrunAdi.Text, cbSatisIptal.Checked);
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

        private void frmUrunIslemleri_Load(object sender, EventArgs e)
        {
            dtgvUrunListesi.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dtgvUrunListesi.DefaultCellStyle.SelectionForeColor = Color.White;
            cmbUrunKategorisi.Items.AddRange(urunIslemleriVT.KategoriCek());
        }

  
    }
}
