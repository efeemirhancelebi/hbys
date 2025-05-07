namespace HBYS
{
    partial class askerlikRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(askerlikRaporu));
            this.btnHayir = new System.Windows.Forms.RadioButton();
            this.labelBilgi = new System.Windows.Forms.Label();
            this.btnEvet = new System.Windows.Forms.RadioButton();
            this.btnRaporOlustur = new System.Windows.Forms.Button();
            this.gboxHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.labelHastaAdi = new System.Windows.Forms.Label();
            this.labelHastaSoyadi = new System.Windows.Forms.Label();
            this.labelHastaTc = new System.Windows.Forms.Label();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.hastaCinsiyetPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yaziciHayir = new System.Windows.Forms.RadioButton();
            this.yaziciEvet = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelRaporTarihi = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxHastaBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaCinsiyetPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHayir
            // 
            this.btnHayir.AutoSize = true;
            this.btnHayir.Location = new System.Drawing.Point(230, 226);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Size = new System.Drawing.Size(49, 17);
            this.btnHayir.TabIndex = 45;
            this.btnHayir.TabStop = true;
            this.btnHayir.Text = "Hayır";
            this.btnHayir.UseVisualStyleBackColor = true;
            // 
            // labelBilgi
            // 
            this.labelBilgi.AutoSize = true;
            this.labelBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilgi.Location = new System.Drawing.Point(11, 191);
            this.labelBilgi.Name = "labelBilgi";
            this.labelBilgi.Size = new System.Drawing.Size(389, 32);
            this.labelBilgi.TabIndex = 40;
            this.labelBilgi.Text = "Hastanın askerlik yapmaya uygundur raporu almaya uygun olup \r\nolmama durumu:";
            // 
            // btnEvet
            // 
            this.btnEvet.AutoSize = true;
            this.btnEvet.Location = new System.Drawing.Point(139, 226);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(47, 17);
            this.btnEvet.TabIndex = 44;
            this.btnEvet.TabStop = true;
            this.btnEvet.Text = "Evet";
            this.btnEvet.UseVisualStyleBackColor = true;
            // 
            // btnRaporOlustur
            // 
            this.btnRaporOlustur.Location = new System.Drawing.Point(354, 379);
            this.btnRaporOlustur.Name = "btnRaporOlustur";
            this.btnRaporOlustur.Size = new System.Drawing.Size(120, 35);
            this.btnRaporOlustur.TabIndex = 43;
            this.btnRaporOlustur.Text = "Rapor Oluştur";
            this.btnRaporOlustur.UseVisualStyleBackColor = true;
            this.btnRaporOlustur.Click += new System.EventHandler(this.btnRaporOlustur_Click);
            // 
            // gboxHastaBilgileri
            // 
            this.gboxHastaBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gboxHastaBilgileri.Controls.Add(this.labelHastaAdi);
            this.gboxHastaBilgileri.Controls.Add(this.labelHastaSoyadi);
            this.gboxHastaBilgileri.Controls.Add(this.labelHastaTc);
            this.gboxHastaBilgileri.Controls.Add(this.labelCinsiyet);
            this.gboxHastaBilgileri.Location = new System.Drawing.Point(14, 12);
            this.gboxHastaBilgileri.Name = "gboxHastaBilgileri";
            this.gboxHastaBilgileri.Size = new System.Drawing.Size(260, 150);
            this.gboxHastaBilgileri.TabIndex = 42;
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
            this.hastaCinsiyetPic.Location = new System.Drawing.Point(324, 12);
            this.hastaCinsiyetPic.Name = "hastaCinsiyetPic";
            this.hastaCinsiyetPic.Size = new System.Drawing.Size(150, 150);
            this.hastaCinsiyetPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hastaCinsiyetPic.TabIndex = 41;
            this.hastaCinsiyetPic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yaziciHayir);
            this.groupBox1.Controls.Add(this.yaziciEvet);
            this.groupBox1.Location = new System.Drawing.Point(277, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 70);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazıcı İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Yazıcıya Gönder:";
            // 
            // yaziciHayir
            // 
            this.yaziciHayir.AutoSize = true;
            this.yaziciHayir.Location = new System.Drawing.Point(62, 39);
            this.yaziciHayir.Name = "yaziciHayir";
            this.yaziciHayir.Size = new System.Drawing.Size(49, 17);
            this.yaziciHayir.TabIndex = 52;
            this.yaziciHayir.TabStop = true;
            this.yaziciHayir.Text = "Hayır";
            this.yaziciHayir.UseVisualStyleBackColor = true;
            // 
            // yaziciEvet
            // 
            this.yaziciEvet.AutoSize = true;
            this.yaziciEvet.Location = new System.Drawing.Point(9, 39);
            this.yaziciEvet.Name = "yaziciEvet";
            this.yaziciEvet.Size = new System.Drawing.Size(47, 17);
            this.yaziciEvet.TabIndex = 51;
            this.yaziciEvet.TabStop = true;
            this.yaziciEvet.Text = "Evet";
            this.yaziciEvet.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // labelRaporTarihi
            // 
            this.labelRaporTarihi.AutoSize = true;
            this.labelRaporTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaporTarihi.Location = new System.Drawing.Point(274, 250);
            this.labelRaporTarihi.Name = "labelRaporTarihi";
            this.labelRaporTarihi.Size = new System.Drawing.Size(129, 16);
            this.labelRaporTarihi.TabIndex = 62;
            this.labelRaporTarihi.Text = "Son Kullanma Tarihi:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(15, 269);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(254, 96);
            this.richTextBox2.TabIndex = 59;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Açıklama:";
            // 
            // askerlikRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelRaporTarihi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnHayir);
            this.Controls.Add(this.labelBilgi);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.btnRaporOlustur);
            this.Controls.Add(this.gboxHastaBilgileri);
            this.Controls.Add(this.hastaCinsiyetPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "askerlikRaporu";
            this.Text = "Askerlik Yapmaya Uygundur Raporu Oluştur";
            this.Load += new System.EventHandler(this.askerlikRaporu_Load);
            this.gboxHastaBilgileri.ResumeLayout(false);
            this.gboxHastaBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaCinsiyetPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton btnHayir;
        private System.Windows.Forms.Label labelBilgi;
        private System.Windows.Forms.RadioButton btnEvet;
        private System.Windows.Forms.Button btnRaporOlustur;
        private System.Windows.Forms.GroupBox gboxHastaBilgileri;
        private System.Windows.Forms.Label labelHastaAdi;
        private System.Windows.Forms.Label labelHastaSoyadi;
        private System.Windows.Forms.Label labelHastaTc;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.PictureBox hastaCinsiyetPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton yaziciHayir;
        private System.Windows.Forms.RadioButton yaziciEvet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelRaporTarihi;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
    }
}