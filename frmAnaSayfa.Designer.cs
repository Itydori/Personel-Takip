namespace Personal_takip_1
{
    partial class frmAnaSayfa
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
            btnDepartmanlar = new Button();
            btnPersonelEkle = new Button();
            btnPersonelListele = new Button();
            SuspendLayout();
            // 
            // btnDepartmanlar
            // 
            btnDepartmanlar.BackColor = SystemColors.ButtonHighlight;
            btnDepartmanlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDepartmanlar.ForeColor = SystemColors.ActiveCaptionText;
            btnDepartmanlar.Location = new Point(50, 50);
            btnDepartmanlar.Name = "btnDepartmanlar";
            btnDepartmanlar.Size = new Size(150, 150);
            btnDepartmanlar.TabIndex = 0;
            btnDepartmanlar.Text = "Departmanlar";
            btnDepartmanlar.UseVisualStyleBackColor = false;
            btnDepartmanlar.Click += btnDepartmanlar_Click;
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.BackColor = SystemColors.ButtonHighlight;
            btnPersonelEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPersonelEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnPersonelEkle.Location = new Point(250, 50);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.Size = new Size(150, 150);
            btnPersonelEkle.TabIndex = 1;
            btnPersonelEkle.Text = "Personel Ekleme";
            btnPersonelEkle.UseVisualStyleBackColor = false;
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // btnPersonelListele
            // 
            btnPersonelListele.BackColor = SystemColors.ButtonHighlight;
            btnPersonelListele.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPersonelListele.ForeColor = SystemColors.ActiveCaptionText;
            btnPersonelListele.Location = new Point(450, 50);
            btnPersonelListele.Name = "btnPersonelListele";
            btnPersonelListele.Size = new Size(150, 150);
            btnPersonelListele.TabIndex = 2;
            btnPersonelListele.Text = "Personel Listeleme";
            btnPersonelListele.UseVisualStyleBackColor = false;
            btnPersonelListele.Click += btnPersonelListele_Click;
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 261);
            Controls.Add(btnPersonelListele);
            Controls.Add(btnPersonelEkle);
            Controls.Add(btnDepartmanlar);
            Name = "frmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAnaSayfa";
            Load += frmAnaSayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDepartmanlar;
        private Button btnPersonelEkle;
        private Button btnPersonelListele;
    }
}