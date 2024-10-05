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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboDepartman);
            YenileListele();
        }

        private void YenileListele()
        {
            Veritabanı.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email,d.Departman,p.Durumu,p.Maasi,p.Maasi,p.GirisTarihi,p.Aciklama from personeller p,departmanlar d where p.DepartmanID=d.DepartmanID");
            lblToplamKayit.Text = "Toplam Kayıt Sayısı: " + (dataGridView1.Rows.Count - 1 )+"Kayıt Listelendi.";
            lblToplamMaas.Text = "Toplam Maaş: " + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[8].Value)).ToString("C2");
        }


        private void label4_Click(object sender, EventArgs e)
        {

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
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.PersonelID = Convert.ToInt32(txtPersonelID.Text);
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.Departman = comboDepartman.SelectedValue != null ? (int)comboDepartman.SelectedValue : 0; // Set default value if null
            p.Durumu = txtDurumu.Text;
            p.Maasi = decimal.Parse(txtMaasi.Text);
            p.GirisTarihi = dateTimePickerGirisTarihi.Value;
            p.Aciklama = txtAciklama.Text;

            // Kontrol etmek istediğimiz değerleri bir listeye ekleyelim
            List<string> hataliSutunlar = new List<string>();
            if (string.IsNullOrEmpty(p.Adi))
                hataliSutunlar.Add("Adı");
            if (string.IsNullOrEmpty(p.Soyadi))
                hataliSutunlar.Add("Soyadı");
            if (string.IsNullOrEmpty(p.Telefon))
                hataliSutunlar.Add("Telefon");
            if (string.IsNullOrEmpty(p.Adres))
                hataliSutunlar.Add("Adres");
            if (string.IsNullOrEmpty(p.Email))
                hataliSutunlar.Add("Email");
            if (p.Departman == 0)
                hataliSutunlar.Add("Departman");
            if (string.IsNullOrEmpty(p.Durumu))
                hataliSutunlar.Add("Durumu");
            if (p.Maasi <= 0)
                hataliSutunlar.Add("Maaşı");

            // Eğer hatalı sütunlar varsa, kullanıcıya uyarı mesajı gösterelim
            if (hataliSutunlar.Count > 0)
            {
                string hataMesaji = "Aşağıdaki sütunlara geçersiz veri girişi yapıldı:\n";
                foreach (string sutun in hataliSutunlar)
                {
                    hataMesaji += sutun + "\n";
                }
                MessageBox.Show(hataMesaji, "Geçersiz Veri Girişi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sorgu = "update personeller set Adi=@Adi,Soyadi=@Soyadi,Telefon=@Telefon,Adres=@Adres,Email=@Email,DepartmanID=@DepartmanID,Durumu=@Durumu,Maasi=@Maasi,GirisTarihi=@GirisTarihi,Aciklama=@Aciklama where PersonelID=@PersonelID";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@Adi", SqlDbType.VarChar).Value = p.Adi;
            cmd.Parameters.Add("@Soyadi", SqlDbType.VarChar).Value = p.Soyadi;
            cmd.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = p.Telefon;
            cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = p.Adres;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = p.Email;
            cmd.Parameters.Add("@DepartmanID", SqlDbType.Int).Value = p.Departman;
            cmd.Parameters.Add("@Durumu", SqlDbType.VarChar).Value = p.Durumu;
            cmd.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            cmd.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = p.GirisTarihi;
            cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = p.Aciklama;
            cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = p.PersonelID;
            Veritabanı.ESG(cmd, sorgu);
            Temizle();
            MessageBox.Show("Güncelleme işlemi başarılı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileListele(); // Update the data grid view
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.PersonelID = Convert.ToInt32(txtPersonelID.Text);
            //string sorgu = "delete from personeller where PersonelID=@PersonelID";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@PersonelID", p.PersonelID);
            //Veritabanı.ESG(cmd, sorgu);
            string sorgu2 = "update personeller set durumu='Pasif' where PersonelID=@PersonelID";
            SqlCommand cmd2 = new SqlCommand();
            Veritabanı.ESG(cmd2, sorgu2);
            Temizle();
            MessageBox.Show("Silme işlemi başarılı", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileListele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboDepartman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtDurumu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtMaasi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[9].Value is DateTime dateValue)
            {
                dateTimePickerGirisTarihi.Value = dateValue;
            }
            else if (DateTime.TryParse(dataGridView1.CurrentRow.Cells[9].Value.ToString(), out dateValue))
            {
                dateTimePickerGirisTarihi.Value = dateValue;
            }

            txtAciklama.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            YenileListele();
        }

        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabanı.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email,d.Departman,p.Durumu,p.Maasi,p.Maasi,p.GirisTarihi,p.Aciklama from personeller p,departmanlar d where p.DepartmanID=d.DepartmanID and p.PersonelID like '%" + txtPersonelIDAra.Text + "%'");

        }

        private void txtPersonelAdAra_TextChanged(object sender, EventArgs e)
        {
            Veritabanı.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email,d.Departman,p.Durumu,p.Maasi,p.Maasi,p.GirisTarihi,p.Aciklama from personeller p,departmanlar d where p.DepartmanID=d.DepartmanID and p.Adi like '%" + txtPersonelAdAra.Text + "%'");
        }

        private void txtPersonelTelefonAra_TextChanged(object sender, EventArgs e)
        {
            Veritabanı.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email,d.Departman,p.Durumu,p.Maasi,p.Maasi,p.GirisTarihi,p.Aciklama from personeller p,departmanlar d where p.DepartmanID=d.DepartmanID and p.Telefon like '%" + txtPersonelTelefonAra.Text + "%'");
        }

        private void txtPersonelSoyadAra_TextChanged(object sender, EventArgs e)
        {
            Veritabanı.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email,d.Departman,p.Durumu,p.Maasi,p.Maasi,p.GirisTarihi,p.Aciklama from personeller p,departmanlar d where p.DepartmanID=d.DepartmanID and p.Soyadi like '%" + txtPersonelSoyadAra.Text + "%'");

        }

        private void dateTimePickerG_Tarihi_ValueChanged(object sender, EventArgs e)
        {
            Personeller.TariheGöreAra(dateTimePickerG_Tarihi,dataGridView1);
        }
    }
}
