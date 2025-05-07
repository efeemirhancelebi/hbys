namespace HBYS
{
    partial class muayeneNotu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(muayeneNotu));
            this.gboxHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.labelHastaAdi = new System.Windows.Forms.Label();
            this.labelHastaSoyadi = new System.Windows.Forms.Label();
            this.labelHastaTc = new System.Windows.Forms.Label();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.hastaCinsiyetPic = new System.Windows.Forms.PictureBox();
            this.hastaSemptomlari = new System.Windows.Forms.ListBox();
            this.muayeninNotu = new System.Windows.Forms.RichTextBox();
            this.labelNot = new System.Windows.Forms.Label();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.hastaSemptomuEkle = new System.Windows.Forms.TextBox();
            this.labelSemptomEkle = new System.Windows.Forms.Label();
            this.btnSemptomEkle = new System.Windows.Forms.Button();
            this.btnTaniEkle = new System.Windows.Forms.Button();
            this.labelHastaTanisi = new System.Windows.Forms.Label();
            this.textTani = new System.Windows.Forms.TextBox();
            this.hastaTanilari = new System.Windows.Forms.ListBox();
            this.gboxHastaBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaCinsiyetPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxHastaBilgileri
            // 
            this.gboxHastaBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gboxHastaBilgileri.Controls.Add(this.labelHastaAdi);
            this.gboxHastaBilgileri.Controls.Add(this.labelHastaSoyadi);
            this.gboxHastaBilgileri.Controls.Add(this.labelHastaTc);
            this.gboxHastaBilgileri.Controls.Add(this.labelCinsiyet);
            this.gboxHastaBilgileri.Location = new System.Drawing.Point(12, 12);
            this.gboxHastaBilgileri.Name = "gboxHastaBilgileri";
            this.gboxHastaBilgileri.Size = new System.Drawing.Size(260, 150);
            this.gboxHastaBilgileri.TabIndex = 26;
            this.gboxHastaBilgileri.TabStop = false;
            this.gboxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // labelHastaAdi
            // 
            this.labelHastaAdi.AutoSize = true;
            this.labelHastaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHastaAdi.Location = new System.Drawing.Point(6, 16);
            this.labelHastaAdi.Name = "labelHastaAdi";
            this.labelHastaAdi.Size = new System.Drawing.Size(69, 16);
            this.labelHastaAdi.TabIndex = 0;
            this.labelHastaAdi.Text = "Hasta Adı:";
            // 
            // labelHastaSoyadi
            // 
            this.labelHastaSoyadi.AutoSize = true;
            this.labelHastaSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHastaSoyadi.Location = new System.Drawing.Point(6, 36);
            this.labelHastaSoyadi.Name = "labelHastaSoyadi";
            this.labelHastaSoyadi.Size = new System.Drawing.Size(92, 16);
            this.labelHastaSoyadi.TabIndex = 1;
            this.labelHastaSoyadi.Text = "Hasta Soyadı:";
            // 
            // labelHastaTc
            // 
            this.labelHastaTc.AutoSize = true;
            this.labelHastaTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHastaTc.Location = new System.Drawing.Point(6, 56);
            this.labelHastaTc.Name = "labelHastaTc";
            this.labelHastaTc.Size = new System.Drawing.Size(166, 16);
            this.labelHastaTc.TabIndex = 2;
            this.labelHastaTc.Text = "Hasta TC Kimlik Numarası:";
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCinsiyet.Location = new System.Drawing.Point(6, 76);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(99, 16);
            this.labelCinsiyet.TabIndex = 3;
            this.labelCinsiyet.Text = "Hasta Cinsiyeti:";
            // 
            // hastaCinsiyetPic
            // 
            this.hastaCinsiyetPic.BackColor = System.Drawing.Color.Transparent;
            this.hastaCinsiyetPic.Image = ((System.Drawing.Image)(resources.GetObject("hastaCinsiyetPic.Image")));
            this.hastaCinsiyetPic.Location = new System.Drawing.Point(478, 12);
            this.hastaCinsiyetPic.Name = "hastaCinsiyetPic";
            this.hastaCinsiyetPic.Size = new System.Drawing.Size(150, 150);
            this.hastaCinsiyetPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hastaCinsiyetPic.TabIndex = 25;
            this.hastaCinsiyetPic.TabStop = false;
            // 
            // hastaSemptomlari
            // 
            this.hastaSemptomlari.FormattingEnabled = true;
            this.hastaSemptomlari.Location = new System.Drawing.Point(322, 168);
            this.hastaSemptomlari.Name = "hastaSemptomlari";
            this.hastaSemptomlari.Size = new System.Drawing.Size(150, 238);
            this.hastaSemptomlari.TabIndex = 27;
            // 
            // muayeninNotu
            // 
            this.muayeninNotu.Location = new System.Drawing.Point(12, 187);
            this.muayeninNotu.Name = "muayeninNotu";
            this.muayeninNotu.Size = new System.Drawing.Size(260, 136);
            this.muayeninNotu.TabIndex = 28;
            this.muayeninNotu.Text = "";
            // 
            // labelNot
            // 
            this.labelNot.AutoSize = true;
            this.labelNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNot.Location = new System.Drawing.Point(18, 168);
            this.labelNot.Name = "labelNot";
            this.labelNot.Size = new System.Drawing.Size(97, 16);
            this.labelNot.TabIndex = 4;
            this.labelNot.Text = "Muayene Notu:";
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Location = new System.Drawing.Point(503, 454);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(125, 35);
            this.btnNotEkle.TabIndex = 29;
            this.btnNotEkle.Text = "Muayene Notu Ekle";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // hastaSemptomuEkle
            // 
            this.hastaSemptomuEkle.Location = new System.Drawing.Point(12, 345);
            this.hastaSemptomuEkle.Name = "hastaSemptomuEkle";
            this.hastaSemptomuEkle.Size = new System.Drawing.Size(260, 20);
            this.hastaSemptomuEkle.TabIndex = 30;
            // 
            // labelSemptomEkle
            // 
            this.labelSemptomEkle.AutoSize = true;
            this.labelSemptomEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemptomEkle.Location = new System.Drawing.Point(13, 326);
            this.labelSemptomEkle.Name = "labelSemptomEkle";
            this.labelSemptomEkle.Size = new System.Drawing.Size(144, 16);
            this.labelSemptomEkle.TabIndex = 31;
            this.labelSemptomEkle.Text = "Yeni Hasta Semptomu:";
            // 
            // btnSemptomEkle
            // 
            this.btnSemptomEkle.Location = new System.Drawing.Point(12, 371);
            this.btnSemptomEkle.Name = "btnSemptomEkle";
            this.btnSemptomEkle.Size = new System.Drawing.Size(125, 35);
            this.btnSemptomEkle.TabIndex = 32;
            this.btnSemptomEkle.Text = "Semptom Ekle";
            this.btnSemptomEkle.UseVisualStyleBackColor = true;
            this.btnSemptomEkle.Click += new System.EventHandler(this.btnSemptomEkle_Click);
            // 
            // btnTaniEkle
            // 
            this.btnTaniEkle.Location = new System.Drawing.Point(12, 454);
            this.btnTaniEkle.Name = "btnTaniEkle";
            this.btnTaniEkle.Size = new System.Drawing.Size(125, 35);
            this.btnTaniEkle.TabIndex = 35;
            this.btnTaniEkle.Text = "Tanı Ekle";
            this.btnTaniEkle.UseVisualStyleBackColor = true;
            this.btnTaniEkle.Click += new System.EventHandler(this.btnTaniEkle_Click);
            // 
            // labelHastaTanisi
            // 
            this.labelHastaTanisi.AutoSize = true;
            this.labelHastaTanisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHastaTanisi.Location = new System.Drawing.Point(13, 409);
            this.labelHastaTanisi.Name = "labelHastaTanisi";
            this.labelHastaTanisi.Size = new System.Drawing.Size(116, 16);
            this.labelHastaTanisi.TabIndex = 34;
            this.labelHastaTanisi.Text = "Yeni Hasta Tanısı:";
            // 
            // textTani
            // 
            this.textTani.Location = new System.Drawing.Point(12, 428);
            this.textTani.Name = "textTani";
            this.textTani.Size = new System.Drawing.Size(260, 20);
            this.textTani.TabIndex = 33;
            // 
            // hastaTanilari
            // 
            this.hastaTanilari.FormattingEnabled = true;
            this.hastaTanilari.Location = new System.Drawing.Point(478, 168);
            this.hastaTanilari.Name = "hastaTanilari";
            this.hastaTanilari.Size = new System.Drawing.Size(150, 238);
            this.hastaTanilari.TabIndex = 36;
            // 
            // muayeneNotu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 499);
            this.Controls.Add(this.hastaTanilari);
            this.Controls.Add(this.btnTaniEkle);
            this.Controls.Add(this.labelHastaTanisi);
            this.Controls.Add(this.textTani);
            this.Controls.Add(this.btnSemptomEkle);
            this.Controls.Add(this.labelSemptomEkle);
            this.Controls.Add(this.hastaSemptomuEkle);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.labelNot);
            this.Controls.Add(this.muayeninNotu);
            this.Controls.Add(this.hastaSemptomlari);
            this.Controls.Add(this.gboxHastaBilgileri);
            this.Controls.Add(this.hastaCinsiyetPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "muayeneNotu";
            this.Text = "Muayene Notu Oluştur";
            this.Load += new System.EventHandler(this.muayeneNotu_Load);
            this.gboxHastaBilgileri.ResumeLayout(false);
            this.gboxHastaBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaCinsiyetPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxHastaBilgileri;
        private System.Windows.Forms.Label labelHastaAdi;
        private System.Windows.Forms.Label labelHastaSoyadi;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.PictureBox hastaCinsiyetPic;
        private System.Windows.Forms.ListBox hastaSemptomlari;
        private System.Windows.Forms.RichTextBox muayeninNotu;
        private System.Windows.Forms.Label labelNot;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.TextBox hastaSemptomuEkle;
        private System.Windows.Forms.Label labelSemptomEkle;
        private System.Windows.Forms.Button btnSemptomEkle;
        private System.Windows.Forms.Label labelHastaTc;
        private System.Windows.Forms.Button btnTaniEkle;
        private System.Windows.Forms.Label labelHastaTanisi;
        private System.Windows.Forms.TextBox textTani;
        private System.Windows.Forms.ListBox hastaTanilari;
    }
}