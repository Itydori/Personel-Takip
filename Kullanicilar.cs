using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_takip_1
{
    internal class Kullanicilar
    {
        private int _KullaniciID;
        private string _KullaniciAdi;
        private string _Sifre;
        private string _AdiSoyadi;
        private string _SifreHatirlatmaSorusu;
        private string _SifreHatirlatmaCevap;
        private string _Aciklama;
        private DateTime _Tarih;
        private string _Email;
        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string KullaniciAdi { get => _KullaniciAdi; set => _KullaniciAdi = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }
        public string AdiSoyadi { get => _AdiSoyadi; set => _AdiSoyadi = value; }
        public string SifreHatirlatmaSorusu { get => _SifreHatirlatmaSorusu; set => _SifreHatirlatmaSorusu = value; }
        public string SifreHatirlatmaCevap { get => _SifreHatirlatmaCevap; set => _SifreHatirlatmaCevap = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Email { get => _Email; set => _Email = value; }

        public static bool durum = false;
        public static SqlDataReader KullaniciGirisi(string KullaniciAdi, string Sifre)
        {
            Kullanicilar k = new Kullanicilar();
            k._KullaniciAdi = KullaniciAdi;
            k._Sifre = Sifre;
            Veritabanı.baglantı.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kullanicilar where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", Veritabanı.baglantı);
            cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", Sifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                k.KullaniciID = Convert.ToInt32(dr["KullaniciID"]);
            }
            else
            {
                durum = false;
            }
            dr.Close();
            Veritabanı.baglantı.Close();
            return dr;
        }
    }
}