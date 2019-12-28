using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UrunBL
    {
        LetGooContext ctx = null;

        public List<Urun> UrunListesi()
        {
            List<Urun> urunler;
            using (ctx = new LetGooContext())
            {
                urunler = ctx.Urunler.Include("Satici").ToList();
            }
            return urunler;
        }

        public List<Urun> BenimUrunlerim(int id)
        {
            List<Urun> urunler;
            using (ctx = new LetGooContext())
            {
                urunler = ctx.Urunler.Where(u => u.KullaniciId == id).ToList();
            }
            return urunler;
        }

        public bool UrunEkle(Urun u)
        {
            using (ctx = new LetGooContext())
            {
                ctx.Urunler.Add(u);
                return ctx.SaveChanges() > 0;
            }
        }

        public bool UrunGuncelle(Urun u)
        {
            using (ctx = new LetGooContext())
            {
                Urun urun = ctx.Urunler.Find(u.UrunId);
                urun.UrunAd = u.UrunAd;
                urun.Fiyat = u.Fiyat;
                return ctx.SaveChanges() > 0;
            }
        }

        public bool UrunSil(int id)
        {
            using (ctx=new LetGooContext())
            {
                Urun urun=ctx.Urunler.Find(id);
                ctx.Urunler.Remove(urun);
                return ctx.SaveChanges() > 0;
            }
        }
    }
}
