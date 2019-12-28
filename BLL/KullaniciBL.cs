using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KullaniciBL
    {
        LetGooContext ctx = null;

        public bool KullaniciEkle(Kullanici k)
        {
            using (ctx = new LetGooContext())
            {
                ctx.Kullanicilar.Add(k);
                return ctx.SaveChanges() > 0;
            }
        }

        public bool KullaniciVarMi(string k)
        {
            using (ctx = new LetGooContext())
            {
                return 0 == ctx.Kullanicilar.Where(kul => kul.KullaniciAd == k).Count();
            }
        }

        public List<Kullanici> GirisKontrol(Kullanici k)
        {
            using (ctx = new LetGooContext())
            {
                List <Kullanici> kl = null;
                kl = ctx.Kullanicilar.Where(kul => kul.KullaniciAd == k.KullaniciAd && kul.Sifre == k.Sifre).ToList(); 
               
                return kl;
            }
        }

        public bool KullaniciVarMiGuncelle(string k,int id)
        {
            using (ctx = new LetGooContext())
            {
                return 0 == ctx.Kullanicilar.Where(kul => kul.KullaniciAd == k && kul.KullaniciId!=id).Count();
            }
        }

        public bool KullaniciGuncelle(Kullanici k)
        {
            using (ctx = new LetGooContext())
            {
                Kullanici kullanici=ctx.Kullanicilar.Find(k.KullaniciId);
                kullanici.KullaniciAd = k.KullaniciAd;
                kullanici.Sifre = k.Sifre;
                return ctx.SaveChanges() > 0;
            }
        }

        public bool KullaniciSil(int id)
        {
            using (ctx = new LetGooContext())
            {
                Kullanici kullanici = ctx.Kullanicilar.Find(id);
                ctx.Kullanicilar.Remove(kullanici);
                return ctx.SaveChanges() > 0;
            }
        }
    }
}
