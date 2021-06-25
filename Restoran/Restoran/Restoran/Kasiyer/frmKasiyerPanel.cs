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
    public partial class frmKasiyerPanel : Form
    {
        public frmKasiyerPanel()
        {
            InitializeComponent();
        }
        long secilenID;
 
        Kasiyer.KasiyerVT kasiyerVT = new Kasiyer.KasiyerVT();
        private void frmKasiyerPanel_Load(object sender, EventArgs e)
        {
            dtgvSiparisler.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dtgvSiparisler.DefaultCellStyle.SelectionForeColor = Color.White;
            Siparisgetir();
        }
       
        public void Siparisgetir()
        {
            dtgvSiparisler.DataSource = kasiyerVT.Siparisler();
        }


        

        private void btnDetayGoruntule_Click(object sender, EventArgs e)
        {
            Kasiyer.frmKasiyerUrunDetayPanel frmKasiyerUrunDetayPanel = new Kasiyer.frmKasiyerUrunDetayPanel();
            frmKasiyerUrunDetayPanel.Show();
            frmKasiyerUrunDetayPanel.dtgvSiparisDetay.DataSource= kasiyerVT.DetayGoruntule(secilenID);
            

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
        private void HarfEngel(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void pictureKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txSiparisID_TextChanged(object sender, EventArgs e)
        {
            if (txSiparisID.Text.Trim() != "")
            {
                dtgvSiparisler.DataSource = kasiyerVT.Siparisler(long.Parse(txSiparisID.Text));
            }
            else
            {
                Siparisgetir();
            }
        }

        private void dtgvSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = long.Parse(dtgvSiparisler.CurrentRow.Cells[0].Value.ToString());
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
