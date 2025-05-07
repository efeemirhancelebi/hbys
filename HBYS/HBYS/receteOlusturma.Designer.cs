namespace HBYS
{
    partial class receteOlusturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receteOlusturma));
            this.labelHastaAdi = new System.Windows.Forms.Label();
            this.labelHastaSoyadi = new System.Windows.Forms.Label();
            this.labelHastaTc = new System.Windows.Forms.Label();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelVeya = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaCinsiyetPic = new System.Windows.Forms.PictureBox();
            this.gboxHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.takvim = new System.Windows.Forms.MonthCalendar();
            this.labelIlacSuresi = new System.Windows.Forms.Label();
            this.btnReceteOlustur = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelKacAdet = new System.Windows.Forms.Label();
            this.recete = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hastaCinsiyetPic)).BeginInit();
            this.gboxHastaBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // labelVeya
            // 
            this.labelVeya.AutoSize = true;
            this.labelVeya.Location = new System.Drawing.Point(242, 193);
            this.labelVeya.Name = "labelVeya";
            this.labelVeya.Size = new System.Drawing.Size(30, 13);
            this.labelVeya.TabIndex = 6;
            this.labelVeya.Text = "veya";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "İlaçlar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "İlaç Kodu:";
            // 
            // hastaCinsiyetPic
            // 
            this.hastaCinsiyetPic.BackColor = System.Drawing.Color.Transparent;
            this.hastaCinsiyetPic.Image = ((System.Drawing.Image)(resources.GetObject("hastaCinsiyetPic.Image")));
            this.hastaCinsiyetPic.Location = new System.Drawing.Point(322, 12);
            this.hastaCinsiyetPic.Name = "hastaCinsiyetPic";
            this.hastaCinsiyetPic.Size = new System.Drawing.Size(150, 150);
            this.hastaCinsiyetPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hastaCinsiyetPic.TabIndex = 9;
            this.hastaCinsiyetPic.TabStop = false;
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
            this.gboxHastaBilgileri.TabIndex = 10;
            this.gboxHastaBilgileri.TabStop = false;
            this.gboxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // takvim
            // 
            this.takvim.Location = new System.Drawing.Point(12, 251);
            this.takvim.Name = "takvim";
            this.takvim.TabIndex = 11;
            // 
            // labelIlacSuresi
            // 
            this.labelIlacSuresi.AutoSize = true;
            this.labelIlacSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIlacSuresi.Location = new System.Drawing.Point(12, 226);
            this.labelIlacSuresi.Name = "labelIlacSuresi";
            this.labelIlacSuresi.Size = new System.Drawing.Size(101, 16);
            this.labelIlacSuresi.TabIndex = 12;
            this.labelIlacSuresi.Text = "Kullanım Süresi:";
            // 
            // btnReceteOlustur
            // 
            this.btnReceteOlustur.Location = new System.Drawing.Point(352, 560);
            this.btnReceteOlustur.Name = "btnReceteOlustur";
            this.btnReceteOlustur.Size = new System.Drawing.Size(120, 35);
            this.btnReceteOlustur.TabIndex = 13;
            this.btnReceteOlustur.Text = "Reçete Oluştur";
            this.btnReceteOlustur.UseVisualStyleBackColor = true;
            this.btnReceteOlustur.Click += new System.EventHandler(this.btnReceteOlustur_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(278, 251);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(176, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelKacAdet
            // 
            this.labelKacAdet.AutoSize = true;
            this.labelKacAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKacAdet.Location = new System.Drawing.Point(275, 226);
            this.labelKacAdet.Name = "labelKacAdet";
            this.labelKacAdet.Size = new System.Drawing.Size(179, 16);
            this.labelKacAdet.TabIndex = 15;
            this.labelKacAdet.Text = "Kaç Adet Kullanılacağı (Kutu):";
            // 
            // recete
            // 
            this.recete.FormattingEnabled = true;
            this.recete.Location = new System.Drawing.Point(12, 425);
            this.recete.Name = "recete";
            this.recete.Size = new System.Drawing.Size(460, 121);
            this.recete.TabIndex = 16;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(352, 378);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 35);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "İlacı Reçeteye Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // receteOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 607);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.recete);
            this.Controls.Add(this.labelKacAdet);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnReceteOlustur);
            this.Controls.Add(this.labelIlacSuresi);
            this.Controls.Add(this.takvim);
            this.Controls.Add(this.gboxHastaBilgileri);
            this.Controls.Add(this.hastaCinsiyetPic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelVeya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "receteOlusturma";
            this.Text = "Reçete Oluştur";
            this.Load += new System.EventHandler(this.receteOlusturma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaCinsiyetPic)).EndInit();
            this.gboxHastaBilgileri.ResumeLayout(false);
            this.gboxHastaBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHastaAdi;
        private System.Windows.Forms.Label labelHastaSoyadi;
        private System.Windows.Forms.Label labelHastaTc;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelVeya;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox hastaCinsiyetPic;
        private System.Windows.Forms.GroupBox gboxHastaBilgileri;
        private System.Windows.Forms.MonthCalendar takvim;
        private System.Windows.Forms.Label labelIlacSuresi;
        private System.Windows.Forms.Button btnReceteOlustur;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelKacAdet;
        private System.Windows.Forms.ListBox recete;
        private System.Windows.Forms.Button btnEkle;
    }
}