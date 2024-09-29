using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_takip_1
{
    internal class Departmanlar
    {
        private int _DepartmanID;
        private string _Departman;
        private string _Aciklama;

        public string Departman { get => _Departman; set => _Departman = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public static SqlDataReader DepartmanGetir(ListView lst)
        {
            lst.Items.Clear();
            Veritabanı.baglantı.Open();
            SqlCommand cmd = new SqlCommand("Select *from Departmanlar",Veritabanı.baglantı);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read() ==true) 
            {
                ListViewItem  ekle = new ListViewItem();
                ekle.Text = dataReader[0].ToString();
                ekle.SubItems.Add(dataReader[1].ToString());
                ekle.SubItems.Add(dataReader[2].ToString());
                lst.Items.Add(ekle);
            }
            Veritabanı.baglantı.Close();
            return dataReader;
        }   
    }
}
