using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public ICollection<Urun> Urunler { get; set; }

        public override string ToString()
        {
            return KullaniciAd;
        }
    }
}
