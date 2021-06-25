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

namespace Restoran
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Giris.GirisVT girisVT = new Giris.GirisVT();
            int rolid = girisVT.GirisYap(txKullaniciAdi.Text, txSifre.Text);
            if ( rolid== 0)
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre. Lütfen yeniden deneyin.", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rolid == 1)
            {
                frmYetkiliPanel frmYetkiliPanel = new frmYetkiliPanel();
                frmYetkiliPanel.Show();
                this.Hide();
            }
            else if (rolid == 2)
            {
                frmGarsonSiparisPanel frmGarsonSiparisPanel = new frmGarsonSiparisPanel();
                frmGarsonSiparisPanel.GarsonID = girisVT.GarsonIDSorgula(txKullaniciAdi.Text, txSifre.Text);
                frmGarsonSiparisPanel.Show();
                this.Hide();
            }
            else if (rolid == 3)
            {
                frmKasiyerPanel frmKasiyerPanel = new frmKasiyerPanel();
                frmKasiyerPanel.Show();
                this.Hide();
            }
        }

        //EVENTS
        private void pictureKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("***PROGRAM HAKKINDA***","***PROGRAM HAKKINDA***", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("*SINIF BAĞLANTISI:* 102", "***PROGRAM HAKKINDA***", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("*KAYNAK KODU SATIRLARI*: 3.621", "***PROGRAM HAKKINDA***", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("*TOPLAM ÇALIŞMA SÜRESİ* (Kaynak:Bitbucket Branches):       40 SAAT 18 DAKİKA", "***PROGRAM HAKKINDA***", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("*EMEĞİ GEÇENLER* GÖRKEM KAZAK                        copyright 2020 all rights reserved", "***EMEĞİ GEÇENLER***", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
