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

        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string KullaniciAdi { get => _KullaniciAdi; set => _KullaniciAdi = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }
        
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