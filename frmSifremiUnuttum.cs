using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_takip_1
{
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtKullaniciID.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtAdSoyad.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
            txtEmail.Clear();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Kullanicilar k = new Kullanicilar();
            if (!string.IsNullOrEmpty(txtKullaniciID.Text))
            {
                k.KullaniciID = Convert.ToInt32(txtKullaniciID.Text);
            }
            else
            {
                // Kullanıcıya bir hata mesajı göstermek için MessageBox kullanabilirsiniz.
                MessageBox.Show("Bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdSoyad.Text;
            k.Email = txtEmail.Text;
            k.Tarih = DateTime.Now;
            k.SifreHatirlatmaSorusu = comboSoru.Text;
            k.SifreHatirlatmaCevap = txtSifreTekrar.Text;
            k.Aciklama = txtAciklama.Text;
            string sql = "update Kullanicilar set KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,AdiSoyadi=@AdiSoyadi,Email=@Email,Tarih=@Tarih,SifreHatirlatmaSorusu=@SifreHatirlatmaSorusu,SifreHatirlatmaCevap=@SifreHatirlatmaCevap,Aciklama=@Aciklama where KullaniciID=@KullaniciID";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = k.Tarih;
            Veritabanı.ESG(cmd, sql);
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                string updateSql = "UPDATE Kullanicilar SET Sifre = @YeniSifre, AdSoyad = @AdSoyad, Soru = @Soru, Cevap = @Cevap, Tarih = @Tarih, Aciklama = @Aciklama WHERE KullaniciAdi = @KullaniciAdi";
                cmd.Parameters.AddWithValue("@YeniSifre", txtSifre.Text);
                cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                Veritabanı.ESG(cmd, updateSql);
                MessageBox.Show("Şifre güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Kullanıcı Güncellendi", "İşlem Başarılı Yeni Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();


        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdSoyad.Text;
            k.SifreHatirlatmaSorusu = comboSoru.Text;
            k.SifreHatirlatmaCevap = txtSifreTekrar.Text;
            k.Email = txtEmail.Text;
            k.Tarih = DateTime.Now;
            k.Aciklama = txtAciklama.Text;

            string sql = "insert into Kullanicilar(KullaniciAdi,Sifre,AdiSoyadi,SifreHatirlatmaSorusu,SifreHatirlatmaCevap,Email) values(@KullaniciAdi,@Sifre,@AdiSoyadi,@SifreHatirlatmaSorusu,@SifreHatirlatmaCevap,@Email)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = k.KullaniciAdi;
            cmd.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = k.Sifre;
            cmd.Parameters.Add("@AdiSoyadi", SqlDbType.NVarChar).Value = k.AdiSoyadi;
            cmd.Parameters.Add("@SifreHatirlatmaSorusu", SqlDbType.NVarChar).Value = k.SifreHatirlatmaSorusu;
            cmd.Parameters.Add("@SifreHatirlatmaCevap", SqlDbType.NVarChar).Value = k.SifreHatirlatmaCevap;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = k.Email;
            cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = k.Tarih;

            Veritabanı.ESG(cmd, sql);
            MessageBox.Show("Kullanıcı Eklendi", "İşlem Başarılı Yeni Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            this.Close();
        }

        private void frmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
