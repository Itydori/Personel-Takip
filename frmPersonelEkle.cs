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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboDepartman);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Temizle()
        {
            dateTimePickerGirisTarihi.Value = DateTime.Now;
            comboDepartman.Text = "";
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Clear();
                }
            }
        }
            /*
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtEmail.Clear();
            txtDurumu.Clear();
            txtMaasi.Clear();
            txtAciklama.Clear();
            */
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.Departman = (int)comboDepartman.SelectedValue;
            if (comboDepartman.SelectedValue != null)
            {
                p.Departman = (int)comboDepartman.SelectedValue;
            }
            else
            {
                // Hata işleme veya varsayılan değer atama
                p.Departman = 0; // Örneğin, varsayılan değer olarak 0 atayabilirsiniz
            }
            p.Durumu = txtDurumu.Text;
            p.Maasi = decimal.Parse(txtMaasi.Text);
            p.GirisTarihi = dateTimePickerGirisTarihi.Value;
            p.Aciklama = txtAciklama.Text;

            String sorgu = "INSERT INTO Personeller (Adi, Soyadi, Telefon, Adres, Email, DepartmanID, Durumu, Maasi, GirisTarihi, Aciklama) " +
            "VALUES (@Adi, @Soyadi, @Telefon, @Adres, @Email, @DepartmanID, @Durumu, @Maasi, @GirisTarihi, @Aciklama)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Adi", p.Adi);
            cmd.Parameters.AddWithValue("@Soyadi", p.Soyadi);
            cmd.Parameters.AddWithValue("@Telefon", p.Telefon);
            cmd.Parameters.AddWithValue("@Adres", p.Adres);
            cmd.Parameters.AddWithValue("@Email", p.Email);
            cmd.Parameters.AddWithValue("@DepartmanID", p.Departman);
            cmd.Parameters.AddWithValue("@Durumu", p.Durumu);
            cmd.Parameters.AddWithValue("@Aciklama", p.Aciklama);
            cmd.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            cmd.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi.ToString("yyyy-MM-dd");
            
            Veritabanı.ESG(cmd, sorgu);
            Temizle();
            MessageBox.Show("Personel Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
