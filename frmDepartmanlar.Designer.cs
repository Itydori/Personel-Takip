namespace Personal_takip_1
{
    partial class frmDepartmanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanlar));
            txtDepartmanID = new TextBox();
            txtDepartman = new TextBox();
            txtAciklama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEkle = new Button();
            ımageList1 = new ImageList(components);
            btnGuncelle = new Button();
            btnSil = new Button();
            btnCikis = new Button();
            listView1 = new ListView();
            DepartmanID = new ColumnHeader();
            Departman = new ColumnHeader();
            Açıklama = new ColumnHeader();
            SuspendLayout();
            // 
            // txtDepartmanID
            // 
            txtDepartmanID.Location = new Point(150, 80);
            txtDepartmanID.Name = "txtDepartmanID";
            txtDepartmanID.Size = new Size(110, 26);
            txtDepartmanID.TabIndex = 0;
            // 
            // txtDepartman
            // 
            txtDepartman.Location = new Point(295, 80);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(110, 26);
            txtDepartman.TabIndex = 1;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(440, 80);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(110, 26);
            txtAciklama.TabIndex = 2;
            txtAciklama.TextChanged += txtAciklama_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 3;
            label1.Text = "Departman ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 58);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 4;
            label2.Text = "Departman:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 58);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 5;
            label3.Text = "Açıklama:";
            // 
            // btnEkle
            // 
            btnEkle.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageIndex = 3;
            btnEkle.ImageList = ımageList1;
            btnEkle.Location = new Point(150, 131);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 50);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.TextAlign = ContentAlignment.MiddleRight;
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
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
            // btnGuncelle
            // 
            btnGuncelle.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageIndex = 1;
            btnGuncelle.ImageList = ımageList1;
            btnGuncelle.Location = new Point(246, 131);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(90, 50);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageIndex = 4;
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(364, 131);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 50);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnCikis
            // 
            btnCikis.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.ImageIndex = 1;
            btnCikis.ImageList = ımageList1;
            btnCikis.Location = new Point(460, 131);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(90, 50);
            btnCikis.TabIndex = 9;
            btnCikis.Text = "Çıkış";
            btnCikis.TextAlign = ContentAlignment.MiddleRight;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { DepartmanID, Departman, Açıklama });
            listView1.Location = new Point(100, 200);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 200);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // DepartmanID
            // 
            DepartmanID.Text = "DepartmanID";
            DepartmanID.Width = 95;
            // 
            // Departman
            // 
            Departman.Text = "Departman";
            Departman.Width = 90;
            // 
            // Açıklama
            // 
            Açıklama.Text = "Açıklama";
            Açıklama.Width = 300;
            // 
            // frmDepartmanlar
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(listView1);
            Controls.Add(btnCikis);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAciklama);
            Controls.Add(txtDepartman);
            Controls.Add(txtDepartmanID);
            Name = "frmDepartmanlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departman Sayfası";
            Load += frmDepartmanlar_Load;
            Resize += frmDepartmanlar_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDepartmanID;
        private TextBox txtDepartman;
        private TextBox txtAciklama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnCikis;
        private ListView listView1;
        private ColumnHeader DepartmanID;
        private ColumnHeader Departman;
        private ColumnHeader Açıklama;
        private ImageList ımageList1;
    }
}