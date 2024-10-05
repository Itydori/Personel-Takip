namespace Personal_takip_1
{
    partial class frmKullanici
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            panel1 = new Panel();
            lblCikis = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnKullaniciGiris = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            btnKayitOl2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(75, 260);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(250, 26);
            txtSifre.TabIndex = 0;
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(75, 174);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(250, 26);
            txtKullaniciAdi.TabIndex = 1;
            txtKullaniciAdi.TextChanged += txtKullaniciAdi_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblCikis);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 105);
            panel1.TabIndex = 2;
            // 
            // lblCikis
            // 
            lblCikis.AutoSize = true;
            lblCikis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCikis.ForeColor = SystemColors.ButtonFace;
            lblCikis.Location = new Point(374, 9);
            lblCikis.Name = "lblCikis";
            lblCikis.Size = new Size(23, 25);
            lblCikis.TabIndex = 0;
            lblCikis.Text = "X";
            lblCikis.Click += lblCikis_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(122, 68);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Giriş";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 17);
            label1.TabIndex = 0;
            label1.Text = "Tynac Software";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(75, 152);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 3;
            label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(76, 238);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "Şifre:";
            // 
            // btnKullaniciGiris
            // 
            btnKullaniciGiris.BackColor = Color.MidnightBlue;
            btnKullaniciGiris.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKullaniciGiris.ForeColor = SystemColors.ButtonFace;
            btnKullaniciGiris.Location = new Point(75, 335);
            btnKullaniciGiris.Name = "btnKullaniciGiris";
            btnKullaniciGiris.Size = new Size(250, 54);
            btnKullaniciGiris.TabIndex = 5;
            btnKullaniciGiris.Text = "Giriş Yap";
            btnKullaniciGiris.UseVisualStyleBackColor = false;
            btnKullaniciGiris.Click += btnKullaniciGiris_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(75, 299);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 23);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Black", 11.25F);
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(201, 305);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnKayitOl2
            // 
            btnKayitOl2.BackColor = Color.MidnightBlue;
            btnKayitOl2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl2.ForeColor = SystemColors.ButtonFace;
            btnKayitOl2.Location = new Point(75, 395);
            btnKayitOl2.Name = "btnKayitOl2";
            btnKayitOl2.Size = new Size(250, 54);
            btnKayitOl2.TabIndex = 5;
            btnKayitOl2.Text = "Kayıt Ol";
            btnKayitOl2.UseVisualStyleBackColor = false;
            btnKayitOl2.Click += btnKayitOl_Click;
            // 
            // frmKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 500);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(btnKayitOl2);
            Controls.Add(btnKullaniciGiris);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSifre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKullanici";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı İşlemleri Sayfası";
            Load += frmKullanici_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Olay işleyicileri
        private void txSifre_TextChanged(object sender, EventArgs e)
        {
            // txSifre TextChanged olay işleyicisi
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            // txtKullaniciAdi TextChanged olay işleyicisi
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // btnGiris Click olay işleyicisi
        }

        #endregion

        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Panel panel1;
        private Label lblCikis;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnKullaniciGiris;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Button btnKayitOl2;
    }
}
