namespace HBYS
{
    partial class yoneticiHesabi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yoneticiHesabi));
            this.label1 = new System.Windows.Forms.Label();
            this.tumHastalar = new System.Windows.Forms.CheckedListBox();
            this.gboxHastaIslemleri = new System.Windows.Forms.GroupBox();
            this.btnReceteGecmisi = new System.Windows.Forms.Button();
            this.btnBelgeGecmisi = new System.Windows.Forms.Button();
            this.btnRaporGecmisi = new System.Windows.Forms.Button();
            this.btnHastaAsiGecmisi = new System.Windows.Forms.Button();
            this.btnKayitGuncelle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxAsi = new System.Windows.Forms.GroupBox();
            this.btnAsiGuncelle = new System.Windows.Forms.Button();
            this.btnAsiOlustur = new System.Windows.Forms.Button();
            this.btnAsiMiktarlari = new System.Windows.Forms.Button();
            this.btnAsiEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tumAsilar = new System.Windows.Forms.CheckedListBox();
            this.gboxPersonel = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hemsireVeEbeler = new System.Windows.Forms.CheckedListBox();
            this.btnYoneticiTanimla = new System.Windows.Forms.Button();
            this.btnSaglikPersoneliCikart = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tumDoktorlar = new System.Windows.Forms.CheckedListBox();
            this.gboxSaglikOcagiIslemleri = new System.Windows.Forms.GroupBox();
            this.btnGiderBilgileri = new System.Windows.Forms.Button();
            this.btnCalisanListesi = new System.Windows.Forms.Button();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.btnTadilatOlustur = new System.Windows.Forms.Button();
            this.btnAdresBilgileri = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.gboxHastaIslemleri.SuspendLayout();
            this.gboxAsi.SuspendLayout();
            this.gboxPersonel.SuspendLayout();
            this.gboxSaglikOcagiIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hoşgeldiniz, sayın x.";
            // 
            // tumHastalar
            // 
            this.tumHastalar.FormattingEnabled = true;
            this.tumHastalar.Location = new System.Drawing.Point(6, 34);
            this.tumHastalar.Name = "tumHastalar";
            this.tumHastalar.Size = new System.Drawing.Size(240, 439);
            this.tumHastalar.TabIndex = 27;
            // 
            // gboxHastaIslemleri
            // 
            this.gboxHastaIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.gboxHastaIslemleri.Controls.Add(this.btnReceteGecmisi);
            this.gboxHastaIslemleri.Controls.Add(this.btnBelgeGecmisi);
            this.gboxHastaIslemleri.Controls.Add(this.btnRaporGecmisi);
            this.gboxHastaIslemleri.Controls.Add(this.btnHastaAsiGecmisi);
            this.gboxHastaIslemleri.Controls.Add(this.btnKayitGuncelle);
            this.gboxHastaIslemleri.Controls.Add(this.btnKayitSil);
            this.gboxHastaIslemleri.Controls.Add(this.btnHastaEkle);
            this.gboxHastaIslemleri.Controls.Add(this.label2);
            this.gboxHastaIslemleri.Controls.Add(this.tumHastalar);
            this.gboxHastaIslemleri.Location = new System.Drawing.Point(15, 30);
            this.gboxHastaIslemleri.Name = "gboxHastaIslemleri";
            this.gboxHastaIslemleri.Size = new System.Drawing.Size(398, 479);
            this.gboxHastaIslemleri.TabIndex = 28;
            this.gboxHastaIslemleri.TabStop = false;
            this.gboxHastaIslemleri.Text = "Hasta İşlemleri";
            // 
            // btnReceteGecmisi
            // 
            this.btnReceteGecmisi.Location = new System.Drawing.Point(252, 340);
            this.btnReceteGecmisi.Name = "btnReceteGecmisi";
            this.btnReceteGecmisi.Size = new System.Drawing.Size(140, 45);
            this.btnReceteGecmisi.TabIndex = 36;
            this.btnReceteGecmisi.Text = "Hasta Reçete Geçmişi";
            this.btnReceteGecmisi.UseVisualStyleBackColor = true;
            this.btnReceteGecmisi.Click += new System.EventHandler(this.btnReceteGecmisi_Click);
            // 
            // btnBelgeGecmisi
            // 
            this.btnBelgeGecmisi.Location = new System.Drawing.Point(252, 289);
            this.btnBelgeGecmisi.Name = "btnBelgeGecmisi";
            this.btnBelgeGecmisi.Size = new System.Drawing.Size(140, 45);
            this.btnBelgeGecmisi.TabIndex = 35;
            this.btnBelgeGecmisi.Text = "Hasta Belge Geçmişi";
            this.btnBelgeGecmisi.UseVisualStyleBackColor = true;
            this.btnBelgeGecmisi.Click += new System.EventHandler(this.btnBelgeGecmisi_Click);
            // 
            // btnRaporGecmisi
            // 
            this.btnRaporGecmisi.Location = new System.Drawing.Point(252, 238);
            this.btnRaporGecmisi.Name = "btnRaporGecmisi";
            this.btnRaporGecmisi.Size = new System.Drawing.Size(140, 45);
            this.btnRaporGecmisi.TabIndex = 34;
            this.btnRaporGecmisi.Text = "Hasta Rapor Geçmişi";
            this.btnRaporGecmisi.UseVisualStyleBackColor = true;
            this.btnRaporGecmisi.Click += new System.EventHandler(this.btnRaporGecmisi_Click);
            // 
            // btnHastaAsiGecmisi
            // 
            this.btnHastaAsiGecmisi.Location = new System.Drawing.Point(252, 187);
            this.btnHastaAsiGecmisi.Name = "btnHastaAsiGecmisi";
            this.btnHastaAsiGecmisi.Size = new System.Drawing.Size(140, 45);
            this.btnHastaAsiGecmisi.TabIndex = 33;
            this.btnHastaAsiGecmisi.Text = "Hasta Aşı Geçmişi";
            this.btnHastaAsiGecmisi.UseVisualStyleBackColor = true;
            this.btnHastaAsiGecmisi.Click += new System.EventHandler(this.btnHastaAsiGecmisi_Click);
            // 
            // btnKayitGuncelle
            // 
            this.btnKayitGuncelle.Location = new System.Drawing.Point(252, 136);
            this.btnKayitGuncelle.Name = "btnKayitGuncelle";
            this.btnKayitGuncelle.Size = new System.Drawing.Size(140, 45);
            this.btnKayitGuncelle.TabIndex = 31;
            this.btnKayitGuncelle.Text = "Kayıt Güncelle";
            this.btnKayitGuncelle.UseVisualStyleBackColor = true;
            this.btnKayitGuncelle.Click += new System.EventHandler(this.btnKayitGuncelle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(252, 85);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(140, 45);
            this.btnKayitSil.TabIndex = 30;
            this.btnKayitSil.Text = "Kayıt Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.Location = new System.Drawing.Point(252, 34);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(140, 45);
            this.btnHastaEkle.TabIndex = 29;
            this.btnHastaEkle.Text = "Yeni Kayıt Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Kayıtlı Tüm Hastalar";
            // 
            // gboxAsi
            // 
            this.gboxAsi.BackColor = System.Drawing.Color.Transparent;
            this.gboxAsi.Controls.Add(this.btnAsiGuncelle);
            this.gboxAsi.Controls.Add(this.btnAsiOlustur);
            this.gboxAsi.Controls.Add(this.btnAsiMiktarlari);
            this.gboxAsi.Controls.Add(this.btnAsiEkle);
            this.gboxAsi.Controls.Add(this.label3);
            this.gboxAsi.Controls.Add(this.tumAsilar);
            this.gboxAsi.Location = new System.Drawing.Point(419, 30);
            this.gboxAsi.Name = "gboxAsi";
            this.gboxAsi.Size = new System.Drawing.Size(410, 241);
            this.gboxAsi.TabIndex = 29;
            this.gboxAsi.TabStop = false;
            this.gboxAsi.Text = "Aşı İşlemleri";
            // 
            // btnAsiGuncelle
            // 
            this.btnAsiGuncelle.Location = new System.Drawing.Point(252, 187);
            this.btnAsiGuncelle.Name = "btnAsiGuncelle";
            this.btnAsiGuncelle.Size = new System.Drawing.Size(140, 45);
            this.btnAsiGuncelle.TabIndex = 42;
            this.btnAsiGuncelle.Text = "Aşı Miktarlarını Güncelle";
            this.btnAsiGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnAsiOlustur
            // 
            this.btnAsiOlustur.Location = new System.Drawing.Point(252, 136);
            this.btnAsiOlustur.Name = "btnAsiOlustur";
            this.btnAsiOlustur.Size = new System.Drawing.Size(140, 45);
            this.btnAsiOlustur.TabIndex = 41;
            this.btnAsiOlustur.Text = "Aşı İhtiyacı Oluştur";
            this.btnAsiOlustur.UseVisualStyleBackColor = true;
            // 
            // btnAsiMiktarlari
            // 
            this.btnAsiMiktarlari.Location = new System.Drawing.Point(252, 85);
            this.btnAsiMiktarlari.Name = "btnAsiMiktarlari";
            this.btnAsiMiktarlari.Size = new System.Drawing.Size(140, 45);
            this.btnAsiMiktarlari.TabIndex = 40;
            this.btnAsiMiktarlari.Text = "Aşı Miktarları";
            this.btnAsiMiktarlari.UseVisualStyleBackColor = true;
            // 
            // btnAsiEkle
            // 
            this.btnAsiEkle.Location = new System.Drawing.Point(252, 34);
            this.btnAsiEkle.Name = "btnAsiEkle";
            this.btnAsiEkle.Size = new System.Drawing.Size(140, 45);
            this.btnAsiEkle.TabIndex = 39;
            this.btnAsiEkle.Text = "Aşı Ekle";
            this.btnAsiEkle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mevcut Tüm Aşılar";
            // 
            // tumAsilar
            // 
            this.tumAsilar.FormattingEnabled = true;
            this.tumAsilar.Location = new System.Drawing.Point(6, 34);
            this.tumAsilar.Name = "tumAsilar";
            this.tumAsilar.Size = new System.Drawing.Size(240, 199);
            this.tumAsilar.TabIndex = 37;
            // 
            // gboxPersonel
            // 
            this.gboxPersonel.BackColor = System.Drawing.Color.Transparent;
            this.gboxPersonel.Controls.Add(this.label5);
            this.gboxPersonel.Controls.Add(this.hemsireVeEbeler);
            this.gboxPersonel.Controls.Add(this.btnYoneticiTanimla);
            this.gboxPersonel.Controls.Add(this.btnSaglikPersoneliCikart);
            this.gboxPersonel.Controls.Add(this.btnPersonelEkle);
            this.gboxPersonel.Controls.Add(this.label4);
            this.gboxPersonel.Controls.Add(this.tumDoktorlar);
            this.gboxPersonel.Location = new System.Drawing.Point(419, 277);
            this.gboxPersonel.Name = "gboxPersonel";
            this.gboxPersonel.Size = new System.Drawing.Size(428, 232);
            this.gboxPersonel.TabIndex = 43;
            this.gboxPersonel.TabStop = false;
            this.gboxPersonel.Text = "Doktor ve Hemşire İşlemleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Hemşire ve Ebeler";
            // 
            // hemsireVeEbeler
            // 
            this.hemsireVeEbeler.FormattingEnabled = true;
            this.hemsireVeEbeler.Location = new System.Drawing.Point(144, 27);
            this.hemsireVeEbeler.Name = "hemsireVeEbeler";
            this.hemsireVeEbeler.Size = new System.Drawing.Size(132, 199);
            this.hemsireVeEbeler.TabIndex = 43;
            // 
            // btnYoneticiTanimla
            // 
            this.btnYoneticiTanimla.Location = new System.Drawing.Point(282, 129);
            this.btnYoneticiTanimla.Name = "btnYoneticiTanimla";
            this.btnYoneticiTanimla.Size = new System.Drawing.Size(140, 45);
            this.btnYoneticiTanimla.TabIndex = 41;
            this.btnYoneticiTanimla.Text = "Yönetici Tanımla";
            this.btnYoneticiTanimla.UseVisualStyleBackColor = true;
            // 
            // btnSaglikPersoneliCikart
            // 
            this.btnSaglikPersoneliCikart.Location = new System.Drawing.Point(282, 78);
            this.btnSaglikPersoneliCikart.Name = "btnSaglikPersoneliCikart";
            this.btnSaglikPersoneliCikart.Size = new System.Drawing.Size(140, 45);
            this.btnSaglikPersoneliCikart.TabIndex = 40;
            this.btnSaglikPersoneliCikart.Text = "Sağlık Personeli Çıkart";
            this.btnSaglikPersoneliCikart.UseVisualStyleBackColor = true;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(282, 27);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(140, 45);
            this.btnPersonelEkle.TabIndex = 39;
            this.btnPersonelEkle.Text = "Yeni Sağlık Personeli Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Doktorlar";
            // 
            // tumDoktorlar
            // 
            this.tumDoktorlar.FormattingEnabled = true;
            this.tumDoktorlar.Location = new System.Drawing.Point(9, 27);
            this.tumDoktorlar.Name = "tumDoktorlar";
            this.tumDoktorlar.Size = new System.Drawing.Size(132, 199);
            this.tumDoktorlar.TabIndex = 37;
            // 
            // gboxSaglikOcagiIslemleri
            // 
            this.gboxSaglikOcagiIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.gboxSaglikOcagiIslemleri.Controls.Add(this.btnGiderBilgileri);
            this.gboxSaglikOcagiIslemleri.Controls.Add(this.btnCalisanListesi);
            this.gboxSaglikOcagiIslemleri.Controls.Add(this.btnCalisanEkle);
            this.gboxSaglikOcagiIslemleri.Controls.Add(this.btnTadilatOlustur);
            this.gboxSaglikOcagiIslemleri.Controls.Add(this.btnAdresBilgileri);
            this.gboxSaglikOcagiIslemleri.Location = new System.Drawing.Point(15, 515);
            this.gboxSaglikOcagiIslemleri.Name = "gboxSaglikOcagiIslemleri";
            this.gboxSaglikOcagiIslemleri.Size = new System.Drawing.Size(398, 134);
            this.gboxSaglikOcagiIslemleri.TabIndex = 44;
            this.gboxSaglikOcagiIslemleri.TabStop = false;
            this.gboxSaglikOcagiIslemleri.Text = "Sağlık Ocağı İşlemleri";
            // 
            // btnGiderBilgileri
            // 
            this.btnGiderBilgileri.Location = new System.Drawing.Point(136, 60);
            this.btnGiderBilgileri.Name = "btnGiderBilgileri";
            this.btnGiderBilgileri.Size = new System.Drawing.Size(125, 35);
            this.btnGiderBilgileri.TabIndex = 49;
            this.btnGiderBilgileri.Text = "Sağlık Ocağı Gider Bilgileri";
            this.btnGiderBilgileri.UseVisualStyleBackColor = true;
            // 
            // btnCalisanListesi
            // 
            this.btnCalisanListesi.Location = new System.Drawing.Point(6, 60);
            this.btnCalisanListesi.Name = "btnCalisanListesi";
            this.btnCalisanListesi.Size = new System.Drawing.Size(125, 35);
            this.btnCalisanListesi.TabIndex = 48;
            this.btnCalisanListesi.Text = "Sağlık Ocağı Çalışan Listesi";
            this.btnCalisanListesi.UseVisualStyleBackColor = true;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(267, 19);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(125, 35);
            this.btnCalisanEkle.TabIndex = 47;
            this.btnCalisanEkle.Text = "Sağlık Ocağı Çalışanı Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            // 
            // btnTadilatOlustur
            // 
            this.btnTadilatOlustur.Location = new System.Drawing.Point(136, 19);
            this.btnTadilatOlustur.Name = "btnTadilatOlustur";
            this.btnTadilatOlustur.Size = new System.Drawing.Size(125, 35);
            this.btnTadilatOlustur.TabIndex = 46;
            this.btnTadilatOlustur.Text = "Sağlık Ocağı Tadilat Durumu Oluştur";
            this.btnTadilatOlustur.UseVisualStyleBackColor = true;
            // 
            // btnAdresBilgileri
            // 
            this.btnAdresBilgileri.Location = new System.Drawing.Point(6, 19);
            this.btnAdresBilgileri.Name = "btnAdresBilgileri";
            this.btnAdresBilgileri.Size = new System.Drawing.Size(124, 35);
            this.btnAdresBilgileri.TabIndex = 45;
            this.btnAdresBilgileri.Text = "Sağlık Ocağı Adres Bilgisi";
            this.btnAdresBilgileri.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(747, 609);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(125, 40);
            this.button16.TabIndex = 45;
            this.button16.Text = "Oturumu Kapat";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // yoneticiHesabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.gboxSaglikOcagiIslemleri);
            this.Controls.Add(this.gboxPersonel);
            this.Controls.Add(this.gboxAsi);
            this.Controls.Add(this.gboxHastaIslemleri);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "yoneticiHesabi";
            this.Text = "1";
            this.Load += new System.EventHandler(this.yoneticiHesabi_Load);
            this.gboxHastaIslemleri.ResumeLayout(false);
            this.gboxHastaIslemleri.PerformLayout();
            this.gboxAsi.ResumeLayout(false);
            this.gboxAsi.PerformLayout();
            this.gboxPersonel.ResumeLayout(false);
            this.gboxPersonel.PerformLayout();
            this.gboxSaglikOcagiIslemleri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox tumHastalar;
        private System.Windows.Forms.GroupBox gboxHastaIslemleri;
        private System.Windows.Forms.Button btnHastaAsiGecmisi;
        private System.Windows.Forms.Button btnKayitGuncelle;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReceteGecmisi;
        private System.Windows.Forms.Button btnBelgeGecmisi;
        private System.Windows.Forms.Button btnRaporGecmisi;
        private System.Windows.Forms.GroupBox gboxAsi;
        private System.Windows.Forms.Button btnAsiGuncelle;
        private System.Windows.Forms.Button btnAsiOlustur;
        private System.Windows.Forms.Button btnAsiMiktarlari;
        private System.Windows.Forms.Button btnAsiEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox tumAsilar;
        private System.Windows.Forms.GroupBox gboxPersonel;
        private System.Windows.Forms.Button btnYoneticiTanimla;
        private System.Windows.Forms.Button btnSaglikPersoneliCikart;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox tumDoktorlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox hemsireVeEbeler;
        private System.Windows.Forms.GroupBox gboxSaglikOcagiIslemleri;
        private System.Windows.Forms.Button btnGiderBilgileri;
        private System.Windows.Forms.Button btnCalisanListesi;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Button btnTadilatOlustur;
        private System.Windows.Forms.Button btnAdresBilgileri;
        private System.Windows.Forms.Button button16;
    }
}