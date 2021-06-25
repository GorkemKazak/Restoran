using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Yetkili
{
    class CalisanIslemleri
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int Rol { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public bool CikisDurumu { get; set; }
        public int kullaniciId { get; set; }
    }
}
