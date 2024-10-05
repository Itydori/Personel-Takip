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
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmYeniKullanici frm = new frmYeniKullanici();
            frm.ShowDialog();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum frm = new frmSifremiUnuttum();
            frm.ShowDialog();
            Kullanicilar.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {

        }
    }
}
