namespace Personal_takip_1
{
    partial class frmSifremiUnuttum
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
            label7 = new Label();
            txtAciklama = new TextBox();
            btnCikis = new Button();
            btnGuncelle = new Button();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboSoru = new ComboBox();
            txtEmail = new TextBox();
            txtCevap = new TextBox();
            txtSifreTekrar = new TextBox();
            txtAdSoyad = new TextBox();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label9 = new Label();
            txtKullaniciID = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(19, 322);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 33;
            label7.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(121, 322);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(200, 90);
            txtAciklama.TabIndex = 32;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.MidnightBlue;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCikis.ForeColor = SystemColors.Control;
            btnCikis.Location = new Point(226, 424);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(95, 50);
            btnCikis.TabIndex = 31;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.MidnightBlue;
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuncelle.ForeColor = SystemColors.Control;
            btnGuncelle.Location = new Point(121, 424);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(95, 50);
            btnGuncelle.TabIndex = 30;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(19, 207);
            label8.Name = "label8";
            label8.Size = new Size(49, 19);
            label8.TabIndex = 29;
            label8.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(19, 284);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 28;
            label5.Text = "Cevap:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(19, 245);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 27;
            label6.Text = "Soru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(19, 169);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 26;
            label3.Text = "Adı Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(19, 131);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 25;
            label4.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(19, 93);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 24;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(19, 55);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 23;
            label1.Text = "Kullanıcı Adı:";
            // 
            // comboSoru
            // 
            comboSoru.FormattingEnabled = true;
            comboSoru.Location = new Point(123, 245);
            comboSoru.Name = "comboSoru";
            comboSoru.Size = new Size(200, 27);
            comboSoru.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 26);
            txtEmail.TabIndex = 21;
            // 
            // txtCevap
            // 
            txtCevap.Location = new Point(123, 284);
            txtCevap.Name = "txtCevap";
            txtCevap.Size = new Size(200, 26);
            txtCevap.TabIndex = 18;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(123, 131);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(200, 26);
            txtSifreTekrar.TabIndex = 20;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(123, 169);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 26);
            txtAdSoyad.TabIndex = 17;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(123, 93);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 26);
            txtSifre.TabIndex = 19;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(121, 55);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(200, 26);
            txtKullaniciAdi.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(19, 23);
            label9.Name = "label9";
            label9.Size = new Size(87, 19);
            label9.TabIndex = 35;
            label9.Text = "Kullanıcı ID:";
            // 
            // txtKullaniciID
            // 
            txtKullaniciID.Location = new Point(121, 23);
            txtKullaniciID.Name = "txtKullaniciID";
            txtKullaniciID.Size = new Size(200, 26);
            txtKullaniciID.TabIndex = 34;
            // 
            // frmSifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 486);
            Controls.Add(label9);
            Controls.Add(txtKullaniciID);
            Controls.Add(label7);
            Controls.Add(txtAciklama);
            Controls.Add(btnCikis);
            Controls.Add(btnGuncelle);
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
            Name = "frmSifremiUnuttum";
            Text = "Şifremi Unuttum Sayfası";
            Load += frmSifremiUnuttum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtAciklama;
        private Button btnCikis;
        private Button btnGuncelle;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox comboSoru;
        private TextBox txtEmail;
        private TextBox txtCevap;
        private TextBox txtSifreTekrar;
        private TextBox txtAdSoyad;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label9;
        private TextBox txtKullaniciID;
    }
}