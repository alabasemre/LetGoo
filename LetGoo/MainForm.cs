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
    public partial class MainForm : Form
    {
        int kullaniciId;
        int urunId;
        UrunBL urunBL = null;

        public MainForm(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;

            dgvPazar.AutoGenerateColumns = false;
            dgvUrunlerim.AutoGenerateColumns = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["LoginForm"].Show();
        }

        private void dgvUrunlerim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunlerim.CurrentRow.Cells["clmAd"].Value.ToString();
            txtFiyat.Text = dgvUrunlerim.CurrentRow.Cells["clmFiyat"].Value.ToString();
            urunId = (int)dgvUrunlerim.CurrentRow.Cells["clmUrunId"].Value;
            btnEkle.Text = "Güncelle";
            btnSil.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!EksikVarmi())
            {
                MessageBox.Show("Lütfen Bilgileri Boş Bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }                   

            if (urunId==0)
            {
                UrunEkle();
            }
            else
            {
                UrunGuncelle();
            }
        }
        private void UrunGuncelle()
        {
            if (MessageBox.Show("Güncelle İşlemini Onaylıyor Musunuz?", "İşlem Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                urunBL = new UrunBL();
                Urun u = new Urun();
                u.UrunAd = txtUrunAdi.Text.Trim();
                u.Fiyat = int.Parse(txtFiyat.Text.Trim());
                u.UrunId = this.urunId;

                if (urunBL.UrunGuncelle(u))
                {
                    MessageBox.Show("Ürününüz Güncellendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "İşlem İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UrunEkle()
        {
            if (MessageBox.Show("Ekleme İşlemini Onaylıyor Musunuz?", "İşlem Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                urunBL = new UrunBL();
                Urun u = new Urun();
                u.UrunAd = txtUrunAdi.Text.Trim();
                u.Fiyat = int.Parse(txtFiyat.Text.Trim());
                u.KullaniciId = this.kullaniciId;

                if (urunBL.UrunEkle(u))
                {
                    MessageBox.Show("Ürününüz Eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "İşlem İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Temizle()
        {
            txtFiyat.Text = String.Empty;
            txtUrunAdi.Text = String.Empty;
            btnEkle.Text = "Ekle";
            btnSil.Visible = false;
            urunId = 0;
        }

        void Listele()
        {
            urunBL = new UrunBL();
            dgvPazar.DataSource = urunBL.UrunListesi();
            dgvUrunlerim.DataSource = urunBL.BenimUrunlerim(kullaniciId);
        }

        public bool EksikVarmi()
        {
            bool kontrol = true;
            if (txtFiyat.Text.Trim()=="" || txtUrunAdi.Text.Trim()=="")
            {
                kontrol = false;
            }
            return kontrol;
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=48 && e.KeyChar <=57)|| e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "İşlem Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                urunBL = new UrunBL();             

                if (urunBL.UrunSil(this.urunId))
                {
                    MessageBox.Show("Ürününüz Silindi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "İşlem İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKGüncelle_Click(object sender, EventArgs e)
        {
            if (EksikVarMiKullanici())
            {
                MessageBox.Show("Lütfen Bilgileri Boş Bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Güncelle İşlemini Onaylıyor Musunuz?", "İşlem Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KullaniciBL kullaniciBL = new KullaniciBL();

                if (kullaniciBL.KullaniciVarMiGuncelle(txtKullaniciAdi.Text,this.kullaniciId))
                {
                    Kullanici kullanici = new Kullanici();

                    kullanici.KullaniciAd = txtKullaniciAdi.Text.Trim();
                    kullanici.Sifre = txtKullaniciSifre.Text.Trim();
                    kullanici.KullaniciId = this.kullaniciId;

                    if (kullaniciBL.KullaniciGuncelle(kullanici))
                    {
                        MessageBox.Show("Hesabınız Güncellendi Yeniden Giriş Yapın", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Aynı isimde kullanıcı var!!!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "İşlem İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        bool EksikVarMiKullanici()
        {
            bool kontrol = false;
            if (txtKullaniciAdi.Text.Trim()=="" || txtKullaniciSifre.Text.Trim()=="")
            {
                kontrol = true;
            }
            return kontrol;
        }

        private void btnKSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesap Silme İşlemini Onaylıyor Musunuz?", "İşlem Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KullaniciBL kullaniciBL = new KullaniciBL();
                if (kullaniciBL.KullaniciSil(this.kullaniciId))
                {
                    MessageBox.Show("Hesabınız Silindi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "İşlem İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
