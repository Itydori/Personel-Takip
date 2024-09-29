using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_takip_1
{
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            Departmanlar.DepartmanGetir(listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;
            string sorgu = "INSERT INTO Departmanlar (Departman, Aciklama) VALUES (@Departman, @Aciklama)";
            SqlCommand cmd = new SqlCommand(sorgu);
            cmd.Parameters.AddWithValue("@Departman", d.Departman);
            cmd.Parameters.AddWithValue("@Aciklama", d.Aciklama);
            Veritabanı.ESG(cmd, sorgu); // sorgu parametresini kaldırdım çünkü sorgu zaten cmd içinde
            MessageBox.Show("İşlem Başarılı.");
            Departmanlar.DepartmanGetir(listView1);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(txtDepartmanID.Text);
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;
            string sorgu = "update departmanlar set departman='" + d.Departman + "',aciklama='" + d.Aciklama + "'where departmanID='" + d.DepartmanID + "'";
            SqlCommand cmd = new SqlCommand();
            Veritabanı.ESG(cmd, sorgu);
            cmd.Parameters.AddWithValue("@Departman", d.Departman);
            cmd.Parameters.AddWithValue("@Aciklama", d.Aciklama);
            MessageBox.Show("İşlem Başarılı.");
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {


                Departmanlar d = new Departmanlar();
                d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                d.Departman = txtDepartman.Text;
                d.Aciklama = txtAciklama.Text;
                string sorgu = "delete from departmanlar where departmanID='" + d.DepartmanID + "'";
                SqlCommand cmd = new SqlCommand();
                Veritabanı.ESG(cmd, sorgu);
                cmd.Parameters.AddWithValue("@Departman", d.Departman);
                cmd.Parameters.AddWithValue("@Aciklama", d.Aciklama);
                MessageBox.Show("İşlem Başarılı.");
                Departmanlar.DepartmanGetir(listView1);
            }
            else
            {
                MessageBox.Show("Departman silinemedi, önce kayıt seçilmeli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepartmanlar_Resize(object sender, EventArgs e)
        {

        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepartmanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
