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
    public partial class frmSiparisIslemleri : Form
    {
        public frmSiparisIslemleri()
        {
            InitializeComponent();
        }
        SiparisIslemleriVT SiparisIslemleriVT = new SiparisIslemleriVT();
        private void btnSiparisleriGoruntule_Click(object sender, EventArgs e)
        {
            dtgvTumSiparisler.DataSource = SiparisIslemleriVT.TumSiparisleriGoruntule();
            lblToplamDeger.Text = ToplamKazanc().ToString();
        }

        public int ToplamKazanc()
        {
            int satirsayisi = dtgvTumSiparisler.Rows.Count;
            int toplam = 0;
            for (int i = 0; i < satirsayisi; i++)
            {
                toplam = toplam + int.Parse(dtgvTumSiparisler.Rows[i].Cells[4].Value.ToString());
            }
            return toplam;
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

        private void pictureGeri_Click(object sender, EventArgs e)
        {
            frmYetkiliPanel frmYetkiliPanel = new frmYetkiliPanel();
            frmYetkiliPanel.Show();
            this.Close();
        }

        private void frmSiparisIslemleri_Load(object sender, EventArgs e)
        {
            dtgvTumSiparisler.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dtgvTumSiparisler.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void txSiparisID_TextChanged(object sender, EventArgs e)
        {
            if (txSiparisID.Text.Trim() != "")
            {
                dtgvTumSiparisler.DataSource = SiparisIslemleriVT.TumSiparisleriGoruntule(long.Parse(txSiparisID.Text));
                lblToplamDeger.Text = ToplamKazanc().ToString();
            }
            else
            {
                dtgvTumSiparisler.DataSource = SiparisIslemleriVT.TumSiparisleriGoruntule();
            }
                  
        }
    }
}
