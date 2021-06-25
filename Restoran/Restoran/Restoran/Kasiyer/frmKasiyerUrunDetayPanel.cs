using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran.Kasiyer
{
    public partial class frmKasiyerUrunDetayPanel : Form
    {
        public frmKasiyerUrunDetayPanel()
        {
            InitializeComponent();
        }
        private void pictureKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmKasiyerUrunDetayPanel_Load(object sender, EventArgs e)
        {
            dtgvSiparisDetay.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dtgvSiparisDetay.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
