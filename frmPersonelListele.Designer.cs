namespace Personal_takip_1
{
    partial class frmPersonelListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            txtPersonelIDAra = new TextBox();
            txtPersonelAdAra = new TextBox();
            txtPersonelSoyadAra = new TextBox();
            txtPersonelTelefonAra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTelefon = new TextBox();
            txtSoyadi = new TextBox();
            txtAdi = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            comboDepartman = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtMaasi = new TextBox();
            txtDurumu = new TextBox();
            dateTimePickerGirisTarihi = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            txtAciklama = new TextBox();
            btnCikis = new Button();
            ımageList1 = new ImageList(components);
            lblToplamMaas = new Label();
            lblToplamKayit = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            label16 = new Label();
            txtPersonelID = new TextBox();
            label15 = new Label();
            dateTimePickerG_Tarihi = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPersonelIDAra
            // 
            txtPersonelIDAra.Location = new Point(125, 21);
            txtPersonelIDAra.Name = "txtPersonelIDAra";
            txtPersonelIDAra.Size = new Size(130, 26);
            txtPersonelIDAra.TabIndex = 0;
            txtPersonelIDAra.TextChanged += txtPersonelIDAra_TextChanged;
            // 
            // txtPersonelAdAra
            // 
            txtPersonelAdAra.Location = new Point(390, 25);
            txtPersonelAdAra.Name = "txtPersonelAdAra";
            txtPersonelAdAra.Size = new Size(136, 26);
            txtPersonelAdAra.TabIndex = 0;
            txtPersonelAdAra.TextChanged += txtPersonelAdAra_TextChanged;
            // 
            // txtPersonelSoyadAra
            // 
            txtPersonelSoyadAra.Location = new Point(390, 67);
            txtPersonelSoyadAra.Name = "txtPersonelSoyadAra";
            txtPersonelSoyadAra.Size = new Size(136, 26);
            txtPersonelSoyadAra.TabIndex = 0;
            txtPersonelSoyadAra.TextChanged += txtPersonelSoyadAra_TextChanged;
            // 
            // txtPersonelTelefonAra
            // 
            txtPersonelTelefonAra.Location = new Point(125, 67);
            txtPersonelTelefonAra.Name = "txtPersonelTelefonAra";
            txtPersonelTelefonAra.Size = new Size(130, 26);
            txtPersonelTelefonAra.TabIndex = 0;
            txtPersonelTelefonAra.TextChanged += txtPersonelTelefonAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 1;
            label1.Text = "Personel ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 28);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 1;
            label2.Text = "Personel Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 74);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 1;
            label3.Text = "Personel Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 67);
            label4.Name = "label4";
            label4.Size = new Size(110, 19);
            label4.TabIndex = 1;
            label4.Text = "Personel Telefon:";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(960, 303);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 541);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 18;
            label5.Text = "Telefonu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 507);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 17;
            label6.Text = "Personel Soyadı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 472);
            label7.Name = "label7";
            label7.Size = new Size(87, 19);
            label7.TabIndex = 16;
            label7.Text = "Personel Adı:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(125, 534);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(166, 26);
            txtTelefon.TabIndex = 15;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(125, 500);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(166, 26);
            txtSoyadi.TabIndex = 14;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(125, 466);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(166, 26);
            txtAdi.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 498);
            label8.Name = "label8";
            label8.Size = new Size(50, 19);
            label8.TabIndex = 22;
            label8.Text = "E-mail:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(338, 439);
            label9.Name = "label9";
            label9.Size = new Size(47, 19);
            label9.TabIndex = 21;
            label9.Text = "Adres:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(390, 431);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(191, 60);
            txtAdres.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(390, 498);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 26);
            txtEmail.TabIndex = 19;
            // 
            // comboDepartman
            // 
            comboDepartman.FormattingEnabled = true;
            comboDepartman.Location = new Point(705, 433);
            comboDepartman.Name = "comboDepartman";
            comboDepartman.Size = new Size(126, 27);
            comboDepartman.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(611, 505);
            label10.Name = "label10";
            label10.Size = new Size(48, 19);
            label10.TabIndex = 27;
            label10.Text = "Maaşı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(611, 473);
            label11.Name = "label11";
            label11.Size = new Size(63, 19);
            label11.TabIndex = 26;
            label11.Text = "Durumu:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(611, 439);
            label12.Name = "label12";
            label12.Size = new Size(81, 19);
            label12.TabIndex = 25;
            label12.Text = "Departman:";
            // 
            // txtMaasi
            // 
            txtMaasi.Location = new Point(706, 500);
            txtMaasi.Name = "txtMaasi";
            txtMaasi.Size = new Size(126, 26);
            txtMaasi.TabIndex = 24;
            // 
            // txtDurumu
            // 
            txtDurumu.Location = new Point(706, 467);
            txtDurumu.Name = "txtDurumu";
            txtDurumu.Size = new Size(126, 26);
            txtDurumu.TabIndex = 23;
            // 
            // dateTimePickerGirisTarihi
            // 
            dateTimePickerGirisTarihi.Format = DateTimePickerFormat.Short;
            dateTimePickerGirisTarihi.Location = new Point(706, 533);
            dateTimePickerGirisTarihi.Name = "dateTimePickerGirisTarihi";
            dateTimePickerGirisTarihi.Size = new Size(126, 26);
            dateTimePickerGirisTarihi.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 569);
            label13.Name = "label13";
            label13.Size = new Size(66, 19);
            label13.TabIndex = 31;
            label13.Text = "Açıklama:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(611, 540);
            label14.Name = "label14";
            label14.Size = new Size(74, 19);
            label14.TabIndex = 30;
            label14.Text = "Giriş Tarihi:";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(125, 568);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(457, 22);
            txtAciklama.TabIndex = 29;
            // 
            // btnCikis
            // 
            btnCikis.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.ImageIndex = 0;
            btnCikis.ImageList = ımageList1;
            btnCikis.Location = new Point(868, 553);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(104, 50);
            btnCikis.TabIndex = 33;
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
            // lblToplamMaas
            // 
            lblToplamMaas.AutoSize = true;
            lblToplamMaas.Location = new Point(12, 612);
            lblToplamMaas.Name = "lblToplamMaas";
            lblToplamMaas.Size = new Size(305, 19);
            lblToplamMaas.TabIndex = 36;
            lblToplamMaas.Text = "Listede Toplam 1000000,85 TL Maaş Hesaplandı";
            // 
            // lblToplamKayit
            // 
            lblToplamKayit.AutoSize = true;
            lblToplamKayit.Location = new Point(339, 612);
            lblToplamKayit.Name = "lblToplamKayit";
            lblToplamKayit.Size = new Size(176, 19);
            lblToplamKayit.TabIndex = 37;
            lblToplamKayit.Text = "Toplam 111 Kayıt Listelendi";
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageIndex = 1;
            btnGuncelle.ImageList = ımageList1;
            btnGuncelle.Location = new Point(868, 497);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(104, 50);
            btnGuncelle.TabIndex = 39;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 4;
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(868, 441);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(104, 50);
            btnSil.TabIndex = 38;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 439);
            label16.Name = "label16";
            label16.Size = new Size(81, 19);
            label16.TabIndex = 41;
            label16.Text = "Personel ID:";
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(125, 432);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(166, 26);
            txtPersonelID.TabIndex = 40;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(563, 28);
            label15.Name = "label15";
            label15.Size = new Size(125, 19);
            label15.TabIndex = 42;
            label15.Text = "Tarihe Göre Arama:";
            // 
            // dateTimePickerG_Tarihi
            // 
            dateTimePickerG_Tarihi.Location = new Point(705, 21);
            dateTimePickerG_Tarihi.Name = "dateTimePickerG_Tarihi";
            dateTimePickerG_Tarihi.Size = new Size(200, 26);
            dateTimePickerG_Tarihi.TabIndex = 43;
            dateTimePickerG_Tarihi.ValueChanged += dateTimePickerG_Tarihi_ValueChanged;
            // 
            // frmPersonelListele
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(dateTimePickerG_Tarihi);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(txtPersonelID);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(lblToplamKayit);
            Controls.Add(lblToplamMaas);
            Controls.Add(btnCikis);
            Controls.Add(dateTimePickerGirisTarihi);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(txtAciklama);
            Controls.Add(comboDepartman);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(txtMaasi);
            Controls.Add(txtDurumu);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtAdres);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyadi);
            Controls.Add(txtAdi);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPersonelTelefonAra);
            Controls.Add(txtPersonelSoyadAra);
            Controls.Add(txtPersonelAdAra);
            Controls.Add(txtPersonelIDAra);
            Name = "frmPersonelListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Listeleme, Arama, Silme ve Güncelleme Sayfası";
            Load += frmPersonelListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonelIDAra;
        private TextBox txtPersonelAdAra;
        private TextBox txtPersonelSoyadAra;
        private TextBox txtPersonelTelefonAra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTelefon;
        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label8;
        private Label label9;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private ComboBox comboDepartman;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtMaasi;
        private TextBox txtDurumu;
        private DateTimePicker dateTimePickerGirisTarihi;
        private Label label13;
        private Label label14;
        private TextBox txtAciklama;
        private Button btnCikis;
        private ImageList ımageList1;
        private Label lblToplamMaas;
        private Label lblToplamKayit;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label16;
        private TextBox txtPersonelID;
        private Label label15;
        private DateTimePicker dateTimePickerG_Tarihi;
    }
}