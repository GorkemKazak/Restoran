using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran.Garson
{
    class GarsonSiparis
    {
        //Siparişler
        public int SiparisID { get; set; }
        public string MusteriAdi { get; set; }
        public int GarsonID { get; set; }
        public DateTime Tarih { get; set; }

        //SiparişDetay
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public int ToplamFiyat { get; set; }
        public bool Indirim { get; set; }

 

    }
}
