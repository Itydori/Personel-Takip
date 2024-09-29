namespace Personal_takip_1
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            Kullanicilar.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);
            if (Kullanicilar.durum)
            {
                
                this.Hide(); // Giriþ yapýldýktan sonra giriþ ekranýný gizler

            }
            else
            {
                MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý");
            }
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
