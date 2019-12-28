using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int Fiyat { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Satici { get; set; }
    }
}
