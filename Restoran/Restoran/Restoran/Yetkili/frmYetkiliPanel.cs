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
    public partial class frmYetkiliPanel : Form
    {
        public frmYetkiliPanel()
        {
            InitializeComponent();
        }

        private void btnCalisanIslemleri_Click(object sender, EventArgs e)
        {
            Yetkili.frmCalisanIslemleri frmCalisanIslemleri = new Yetkili.frmCalisanIslemleri();
            frmCalisanIslemleri.Show();
            this.Hide();
        }

        private void btnSiparisIslemleri_Click(object sender, EventArgs e)
        {
            Yetkili.frmSiparisIslemleri frmSiparisIslemleri = new Yetkili.frmSiparisIslemleri();
            frmSiparisIslemleri.Show();
            this.Hide();

        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            Yetkili.frmUrunIslemleri frmUrunIslemleri = new Yetkili.frmUrunIslemleri();
            frmUrunIslemleri.Show();
            this.Hide();
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
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Close();
        }
    }
}
