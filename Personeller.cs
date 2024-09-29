using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_takip_1
{
    internal class Personeller
    {
        private DataGridView dataGridView1;
        private int _PersonelID;
        private string _Adi;
        private string _Soyadi;
        private string _Telefon;
        private string _Adres;
        private string _Email;
        private int _Departman;
        private string _Durumu;
        private decimal _Maasi;
        private DateTime _GirisTarihi;
        private string _Aciklama;

        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyadi { get => _Soyadi; set => _Soyadi = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int Departman { get => _Departman; set => _Departman = value; }
        public string Durumu { get => _Durumu; set => _Durumu = value; }
        public decimal Maasi { get => _Maasi; set => _Maasi = value; }
        public DateTime GirisTarihi { get => _GirisTarihi; set => _GirisTarihi = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }

        public static DataTable ComboyaDepartmanGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            Veritabanı.baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Departmanlar", Veritabanı.baglantı);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = "DepartmanID";
            combo.DisplayMember = "Departman";
            Veritabanı.baglantı.Close();
            return tbl;
        }

        public static DataTable TariheGöreAra(DateTimePicker dt, DataGridView dataGridView)
        {
            DataTable tbl = new DataTable();
            Veritabanı.baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, departmanlar.Departman, p.Durumu, p.Maasi, p.GirisTarihi, p.Aciklama FROM personeller p, departmanlar WHERE p.DepartmanID = departmanlar.DepartmanID AND GirisTarihi=@GirisTarihi", Veritabanı.baglantı);
            adtr.SelectCommand.Parameters.AddWithValue("@GirisTarihi", dt.Value.ToString("yyyy-MM-dd"));
            adtr.Fill(tbl);
            DataGridView dataGridView1 = dataGridView;
            dataGridView1.DataSource = tbl;
            Veritabanı.baglantı.Close();    
            return tbl;
        }

        //public static void GridvieweVeriAktar(DataGridView gridview, DataTable tbl)
        //{
        //    gridview.DataSource = tbl;
        //}
    }
}
