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
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }
        void temizle()
        {
            comboSoru.Text = "";
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
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
        private void frmYeniKullanici_Load(object sender, EventArgs e)
        {

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdSoyad.Text;
            k.SifreHatirlatmaSorusu = comboSoru.Text;
            k.SifreHatirlatmaCevap = txtCevap.Text;
            k.Email = txtEmail.Text;
            k.Tarih = DateTime.Now;
            k.Aciklama = txtAciklama.Text;

            if (k.KullaniciAdi == k.Sifre)
            {
                MessageBox.Show("Kullanıcı adı ve şifre aynı olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "insert into Kullanicilar(KullaniciAdi, Sifre, AdiSoyadi, SifreHatirlatmaSorusu, SifreHatirlatmaCevabi, Email) values(@KullaniciAdi, @Sifre, @AdiSoyadi, @SifreHatirlatmaSorusu, @SifreHatirlatmaCevabi, @Email)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@KullaniciAdi", k.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", k.Sifre);
            cmd.Parameters.AddWithValue("@AdiSoyadi", k.AdiSoyadi);
            cmd.Parameters.AddWithValue("@SifreHatirlatmaSorusu", k.SifreHatirlatmaSorusu);
            cmd.Parameters.AddWithValue("@SifreHatirlatmaCevabi", k.SifreHatirlatmaCevap); // Doğru sütun adı kullanılıyor
            cmd.Parameters.AddWithValue("@Email", k.Email);
            cmd.Parameters.AddWithValue("@Tarih", k.Tarih);
            cmd.Parameters.AddWithValue("@Aciklama", k.Aciklama);
            Veritabanı.ESG(cmd, sql);

            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                cmd.Parameters.Clear(); // Komutu yeniden kullanmadan önce parametreleri temizleyin

                string updateSql = "update Kullanicilar set KullaniciAdi=@KullaniciAdi, Sifre=@Sifre, AdiSoyadi=@AdiSoyadi, SifreHatirlatmaSorusu=@SifreHatirlatmaSorusu, SifreHatirlatmaCevabi=@SifreHatirlatmaCevap, Email=@Email, Tarih=@Tarih, Aciklama=@Aciklama where KullaniciID=@KullaniciID";
                cmd.Parameters.AddWithValue("@KullaniciAdi", k.KullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", k.Sifre);
                cmd.Parameters.AddWithValue("@AdiSoyadi", k.AdiSoyadi);
                cmd.Parameters.AddWithValue("@SifreHatirlatmaSorusu", k.SifreHatirlatmaSorusu);
                cmd.Parameters.AddWithValue("@SifreHatirlatmaCevap", k.SifreHatirlatmaCevap);
                cmd.Parameters.AddWithValue("@Email", k.Email);
                cmd.Parameters.AddWithValue("@Tarih", k.Tarih);
                cmd.Parameters.AddWithValue("@Aciklama", k.Aciklama);
                cmd.Parameters.AddWithValue("@KullaniciID", k.KullaniciID);
                Veritabanı.ESG(cmd, updateSql);
                

                MessageBox.Show("Kullanıcı Eklendi", "İşlem Başarılı Yeni Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
//            Kullanicilar k = new Kullanicilar();
//            k.KullaniciAdi = txtKullaniciAdi.Text;
//            k.Sifre = txtSifre.Text;
//            k.AdiSoyadi = txtAdSoyad.Text;
//            k.SifreHatirlatmaSorusu = comboSoru.Text;
//            k.SifreHatirlatmaCevap = txtSifreTekrar.Text;
//            k.Email = txtEmail.Text;

//            string sql = "insert into Kullanicilar(KullaniciAdi,Sifre,AdiSoyadi,SifreHatirlatmaSorusu,SifreHatirlatmaCevap,Email) values(@KullaniciAdi,@Sifre,@AdiSoyadi,@SifreHatirlatmaSorusu,@SifreHatirlatmaCevap,@Email)";
//            SqlCommand cmd = new SqlCommand(sql, Veritabanı.baglantı);
//            cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
//            cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
//            cmd.Parameters.AddWithValue("@AdiSoyadi", txtAdSoyad.Text);
//            cmd.Parameters.AddWithValue("@SifreHatirlatmaSorusu", txtSifre.Text);
//            cmd.Parameters.AddWithValue("@SifreHatirlatmaCevabi", txtSifreTekrar.Text);
//            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
//            cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
//            Veritabanı.baglantı.Open();
//            cmd.ExecuteNonQuery();
//            Veritabanı.baglantı.Close();
//            MessageBox.Show("Kullanıcı Eklendi", "İşlem Başarılı Yeni Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            temizle();
//            this.Close();
//}
//    }
//}
