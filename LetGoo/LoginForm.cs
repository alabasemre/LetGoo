using BLL;
using MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetGoo
{
    public partial class LoginForm : Form
    {
        KullaniciBL kullaniciBL = null;
        Kullanici kullanici = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            kullaniciBL = new KullaniciBL();
            kullanici = new Kullanici();

            kullanici.KullaniciAd = txtAd.Text.Trim();
            kullanici.Sifre = txtSifre.Text.Trim();

            if (kullaniciBL.KullaniciVarMi(txtAd.Text.Trim()))
            {
                if (kullaniciBL.KullaniciEkle(kullanici))
                {
                    MessageBox.Show("Kayıt Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Aynı isimde kullanıcı var!!!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciBL = new KullaniciBL();
            kullanici = new Kullanici();

            kullanici.KullaniciAd = txtAd.Text.Trim();
            kullanici.Sifre = txtSifre.Text.Trim();

            if (kullaniciBL.GirisKontrol(kullanici).Count!=0)
            {
                txtAd.Text = String.Empty;
                txtSifre.Text = String.Empty;

                this.Hide();
                MainForm mf = new MainForm(kullaniciBL.GirisKontrol(kullanici)[0].KullaniciId);
                mf.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
