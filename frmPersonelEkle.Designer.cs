namespace Personal_takip_1
{
    partial class frmPersonelEkle
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelEkle));
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtMaasi = new TextBox();
            txtDurumu = new TextBox();
            txtAdres = new TextBox();
            txtAciklama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboDepartman = new ComboBox();
            dateTimePickerGirisTarihi = new DateTimePicker();
            btnCikis = new Button();
            ımageList1 = new ImageList(components);
            btnEkle = new Button();
            SuspendLayout();
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(129, 53);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(176, 26);
            txtAdi.TabIndex = 0;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(129, 85);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(176, 26);
            txtSoyadi.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 26);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(129, 117);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(176, 26);
            txtTelefon.TabIndex = 2;
            // 
            // txtMaasi
            // 
            txtMaasi.Location = new Point(129, 312);
            txtMaasi.Name = "txtMaasi";
            txtMaasi.Size = new Size(176, 26);
            txtMaasi.TabIndex = 7;
            // 
            // txtDurumu
            // 
            txtDurumu.Location = new Point(129, 280);
            txtDurumu.Name = "txtDurumu";
            txtDurumu.Size = new Size(176, 26);
            txtDurumu.TabIndex = 6;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(128, 149);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(175, 60);
            txtAdres.TabIndex = 5;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(129, 379);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(175, 60);
            txtAciklama.TabIndex = 9;
            txtAciklama.TextChanged += textBox9_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(13, 56);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 10;
            label1.Text = "Personel Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 11;
            label2.Text = "Personel Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 152);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 13;
            label3.Text = "Adres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(13, 120);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 12;
            label4.Text = "Telefonu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(13, 315);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 17;
            label5.Text = "Maaşı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(13, 283);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 16;
            label6.Text = "Durumu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(13, 251);
            label7.Name = "label7";
            label7.Size = new Size(79, 17);
            label7.TabIndex = 15;
            label7.Text = "Departman:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(13, 222);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 14;
            label8.Text = "E-mail:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(13, 379);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 19;
            label9.Text = "Açıklama:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(13, 347);
            label10.Name = "label10";
            label10.Size = new Size(73, 17);
            label10.TabIndex = 18;
            label10.Text = "Giriş Tarihi:";
            // 
            // comboDepartman
            // 
            comboDepartman.FormattingEnabled = true;
            comboDepartman.Location = new Point(128, 247);
            comboDepartman.Name = "comboDepartman";
            comboDepartman.Size = new Size(176, 27);
            comboDepartman.TabIndex = 20;
            comboDepartman.SelectedIndexChanged += comboDepartman_SelectedIndexChanged;
            // 
            // dateTimePickerGirisTarihi
            // 
            dateTimePickerGirisTarihi.Format = DateTimePickerFormat.Short;
            dateTimePickerGirisTarihi.Location = new Point(129, 344);
            dateTimePickerGirisTarihi.Name = "dateTimePickerGirisTarihi";
            dateTimePickerGirisTarihi.Size = new Size(176, 26);
            dateTimePickerGirisTarihi.TabIndex = 21;
            // 
            // btnCikis
            // 
            btnCikis.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCikis.ForeColor = SystemColors.ActiveCaptionText;
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.ImageIndex = 0;
            btnCikis.ImageList = ımageList1;
            btnCikis.Location = new Point(215, 454);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(90, 50);
            btnCikis.TabIndex = 23;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "4115235_exit_logout_sign out_icon.png");
            ımageList1.Images.SetKeyName(1, "1564533_arrow_refrech_reload_update_icon.png");
            ımageList1.Images.SetKeyName(2, "4115230_cancel_close_delete_icon.png");
            ımageList1.Images.SetKeyName(3, "1564491_add_create_new_plus_icon.png");
            ımageList1.Images.SetKeyName(4, "3994424_cancel_close_delete_reject_remove_icon.png");
            // 
            // btnEkle
            // 
            btnEkle.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageIndex = 3;
            btnEkle.ImageList = ımageList1;
            btnEkle.Location = new Point(119, 454);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 50);
            btnEkle.TabIndex = 24;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // frmPersonelEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(351, 540);
            Controls.Add(btnEkle);
            Controls.Add(btnCikis);
            Controls.Add(dateTimePickerGirisTarihi);
            Controls.Add(comboDepartman);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAciklama);
            Controls.Add(txtMaasi);
            Controls.Add(txtDurumu);
            Controls.Add(txtAdres);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Name = "frmPersonelEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Ekleme Sayfası";
            Load += frmPersonelEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtMaasi;
        private TextBox txtDurumu;
        private TextBox txtAdres;
        private TextBox txtAciklama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboDepartman;
        private DateTimePicker dateTimePickerGirisTarihi;
        private Button btnCikis;
        private Button btnEkle;
        private ImageList ımageList1;
    }
}