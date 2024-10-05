namespace Personal_takip_1
{
    partial class frmYeniKullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            txtAdSoyad = new TextBox();
            txtCevap = new TextBox();
            txtEmail = new TextBox();
            comboSoru = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnEkle = new Button();
            btnCikis = new Button();
            txtAciklama = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(122, 35);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(200, 26);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(124, 74);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 26);
            txtSifre.TabIndex = 1;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(124, 113);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(200, 26);
            txtSifreTekrar.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(124, 152);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 26);
            txtAdSoyad.TabIndex = 0;
            // 
            // txtCevap
            // 
            txtCevap.Location = new Point(124, 270);
            txtCevap.Name = "txtCevap";
            txtCevap.Size = new Size(200, 26);
            txtCevap.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 26);
            txtEmail.TabIndex = 2;
            // 
            // comboSoru
            // 
            comboSoru.FormattingEnabled = true;
            comboSoru.Items.AddRange(new object[] { "1- En sevdiğiniz renk hangisidir?", "2- İlk okul öğretmeninizin ismi nedir?", "3- En sevdiğiniz araba nedir?" });
            comboSoru.Location = new Point(124, 230);
            comboSoru.Name = "comboSoru";
            comboSoru.Size = new Size(200, 27);
            comboSoru.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(20, 76);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(20, 158);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 8;
            label3.Text = "Adı Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(20, 117);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 7;
            label4.Text = "Şifre Tekrar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(20, 270);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 10;
            label5.Text = "Cevap:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(20, 230);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 9;
            label6.Text = "Soru:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(20, 191);
            label8.Name = "label8";
            label8.Size = new Size(49, 19);
            label8.TabIndex = 11;
            label8.Text = "Email:";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.MidnightBlue;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.Control;
            btnEkle.Location = new Point(122, 405);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(95, 50);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.MidnightBlue;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCikis.ForeColor = SystemColors.Control;
            btnCikis.Location = new Point(229, 405);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(95, 50);
            btnCikis.TabIndex = 13;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(124, 309);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(200, 90);
            txtAciklama.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(20, 309);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 15;
            label7.Text = "Açıklama:";
            // 
            // frmYeniKullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 486);
            Controls.Add(label7);
            Controls.Add(txtAciklama);
            Controls.Add(btnCikis);
            Controls.Add(btnEkle);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboSoru);
            Controls.Add(txtEmail);
            Controls.Add(txtCevap);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "frmYeniKullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Kullanıcı Sayfası";
            Load += frmYeniKullanici_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private TextBox txtAdSoyad;
        private TextBox txtCevap;
        private TextBox txtEmail;
        private ComboBox comboSoru;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button btnEkle;
        private Button btnCikis;
        private TextBox txtAciklama;
        private Label label7;
    }
}