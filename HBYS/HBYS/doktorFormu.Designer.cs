namespace HBYS
{
    partial class doktorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorForm));
            this.hastaCinsiyetPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.lblHastaSoyad = new System.Windows.Forms.Label();
            this.lblHastaDogum = new System.Windows.Forms.Label();
            this.lblHastaYas = new System.Windows.Forms.Label();
            this.lblHastaTel = new System.Windows.Forms.Label();
            this.lblHastaAdres = new System.Windows.Forms.Label();
            this.lblHastaAnne = new System.Windows.Forms.Label();
            this.lblHastaBaba = new System.Windows.Forms.Label();
            this.lblHastaTc = new System.Windows.Forms.Label();
            this.gBoxHastaBilgileri = new System.Windows.Forms.GroupBox();
            this.lblBoyKilo = new System.Windows.Forms.Label();
            this.lblHastaCinsiyet = new System.Windows.Forms.Label();
            this.gBoxHastaTetkik = new System.Windows.Forms.GroupBox();
            this.lblDefaultIzlemler = new System.Windows.Forms.Label();
            this.lblVurulanAsilar = new System.Windows.Forms.Label();
            this.lblHastaIzlemleri = new System.Windows.Forms.Label();
            this.btnTaniAra = new System.Windows.Forms.Button();
            this.btnIlacAra = new System.Windows.Forms.Button();
            this.btnSemptomAra = new System.Windows.Forms.Button();
            this.hastaTanilar = new System.Windows.Forms.ListBox();
            this.hastaIlaclar = new System.Windows.Forms.ListBox();
            this.hastaSemptomlar = new System.Windows.Forms.ListBox();
            this.btnIlac = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnSevk = new System.Windows.Forms.Button();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.btnSaglikRaporu = new System.Windows.Forms.Button();
            this.btnAskerlikRaporu = new System.Windows.Forms.Button();
            this.btnSurucu = new System.Windows.Forms.Button();
            this.btnSgk = new System.Windows.Forms.Button();
            this.muayeneNotlari = new System.Windows.Forms.ListBox();
            this.btnHastalikRaporu = new System.Windows.Forms.Button();
            this.btnHastaBilgileriGuncelle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnHastaArama = new System.Windows.Forms.Button();
            this.lblMuayeneNotlari = new System.Windows.Forms.Label();
            this.btnNotAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hastaCinsiyetPic)).BeginInit();
            this.gBoxHastaBilgileri.SuspendLayout();
            this.gBoxHastaTetkik.SuspendLayout();
            this.SuspendLayout();
            // 
            // hastaCinsiyetPic
            // 
            this.hastaCinsiyetPic.BackColor = System.Drawing.Color.Transparent;
            this.hastaCinsiyetPic.Image = ((System.Drawing.Image)(resources.GetObject("hastaCinsiyetPic.Image")));
            this.hastaCinsiyetPic.Location = new System.Drawing.Point(358, 35);
            this.hastaCinsiyetPic.Name = "hastaCinsiyetPic";
            this.hastaCinsiyetPic.Size = new System.Drawing.Size(150, 150);
            this.hastaCinsiyetPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hastaCinsiyetPic.TabIndex = 0;
            this.hastaCinsiyetPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldiniz, sayın Dr. x.";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaAd.Location = new System.Drawing.Point(6, 16);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(75, 18);
            this.lblHastaAd.TabIndex = 2;
            this.lblHastaAd.Text = "Hasta Adı:";
            // 
            // lblHastaSoyad
            // 
            this.lblHastaSoyad.AutoSize = true;
            this.lblHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaSoyad.Location = new System.Drawing.Point(6, 39);
            this.lblHastaSoyad.Name = "lblHastaSoyad";
            this.lblHastaSoyad.Size = new System.Drawing.Size(100, 18);
            this.lblHastaSoyad.TabIndex = 3;
            this.lblHastaSoyad.Text = "Hasta Soyadı:";
            // 
            // lblHastaDogum
            // 
            this.lblHastaDogum.AutoSize = true;
            this.lblHastaDogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaDogum.Location = new System.Drawing.Point(6, 83);
            this.lblHastaDogum.Name = "lblHastaDogum";
            this.lblHastaDogum.Size = new System.Drawing.Size(144, 18);
            this.lblHastaDogum.TabIndex = 4;
            this.lblHastaDogum.Text = "Hasta Doğum Tarihi:";
            // 
            // lblHastaYas
            // 
            this.lblHastaYas.AutoSize = true;
            this.lblHastaYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaYas.Location = new System.Drawing.Point(6, 105);
            this.lblHastaYas.Name = "lblHastaYas";
            this.lblHastaYas.Size = new System.Drawing.Size(83, 18);
            this.lblHastaYas.TabIndex = 5;
            this.lblHastaYas.Text = "Hasta Yaşı:";
            // 
            // lblHastaTel
            // 
            this.lblHastaTel.AutoSize = true;
            this.lblHastaTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaTel.Location = new System.Drawing.Point(6, 127);
            this.lblHastaTel.Name = "lblHastaTel";
            this.lblHastaTel.Size = new System.Drawing.Size(172, 18);
            this.lblHastaTel.TabIndex = 6;
            this.lblHastaTel.Text = "Hasta Telefon Numarası:";
            // 
            // lblHastaAdres
            // 
            this.lblHastaAdres.AutoSize = true;
            this.lblHastaAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaAdres.Location = new System.Drawing.Point(6, 149);
            this.lblHastaAdres.Name = "lblHastaAdres";
            this.lblHastaAdres.Size = new System.Drawing.Size(96, 18);
            this.lblHastaAdres.TabIndex = 7;
            this.lblHastaAdres.Text = "Hasta Adresi:";
            // 
            // lblHastaAnne
            // 
            this.lblHastaAnne.AutoSize = true;
            this.lblHastaAnne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaAnne.Location = new System.Drawing.Point(6, 242);
            this.lblHastaAnne.Name = "lblHastaAnne";
            this.lblHastaAnne.Size = new System.Drawing.Size(112, 18);
            this.lblHastaAnne.TabIndex = 8;
            this.lblHastaAnne.Text = "Hasta Anne Adı:";
            // 
            // lblHastaBaba
            // 
            this.lblHastaBaba.AutoSize = true;
            this.lblHastaBaba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaBaba.Location = new System.Drawing.Point(6, 264);
            this.lblHastaBaba.Name = "lblHastaBaba";
            this.lblHastaBaba.Size = new System.Drawing.Size(113, 18);
            this.lblHastaBaba.TabIndex = 9;
            this.lblHastaBaba.Text = "Hasta Baba Adı:";
            // 
            // lblHastaTc
            // 
            this.lblHastaTc.AutoSize = true;
            this.lblHastaTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaTc.Location = new System.Drawing.Point(6, 61);
            this.lblHastaTc.Name = "lblHastaTc";
            this.lblHastaTc.Size = new System.Drawing.Size(102, 18);
            this.lblHastaTc.TabIndex = 10;
            this.lblHastaTc.Text = "Hasta TC NO:";
            // 
            // gBoxHastaBilgileri
            // 
            this.gBoxHastaBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gBoxHastaBilgileri.Controls.Add(this.lblBoyKilo);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaCinsiyet);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaAd);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaTc);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaSoyad);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaBaba);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaDogum);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaAnne);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaYas);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaAdres);
            this.gBoxHastaBilgileri.Controls.Add(this.lblHastaTel);
            this.gBoxHastaBilgileri.Location = new System.Drawing.Point(12, 35);
            this.gBoxHastaBilgileri.Name = "gBoxHastaBilgileri";
            this.gBoxHastaBilgileri.Size = new System.Drawing.Size(340, 335);
            this.gBoxHastaBilgileri.TabIndex = 11;
            this.gBoxHastaBilgileri.TabStop = false;
            this.gBoxHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // lblBoyKilo
            // 
            this.lblBoyKilo.AutoSize = true;
            this.lblBoyKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoyKilo.Location = new System.Drawing.Point(8, 308);
            this.lblBoyKilo.Name = "lblBoyKilo";
            this.lblBoyKilo.Size = new System.Drawing.Size(152, 18);
            this.lblBoyKilo.TabIndex = 14;
            this.lblBoyKilo.Text = "Hasta Boy Kilo Bilgisi:";
            // 
            // lblHastaCinsiyet
            // 
            this.lblHastaCinsiyet.AutoSize = true;
            this.lblHastaCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaCinsiyet.Location = new System.Drawing.Point(8, 286);
            this.lblHastaCinsiyet.Name = "lblHastaCinsiyet";
            this.lblHastaCinsiyet.Size = new System.Drawing.Size(110, 18);
            this.lblHastaCinsiyet.TabIndex = 12;
            this.lblHastaCinsiyet.Text = "Hasta Cinsiyeti:";
            // 
            // gBoxHastaTetkik
            // 
            this.gBoxHastaTetkik.BackColor = System.Drawing.Color.Transparent;
            this.gBoxHastaTetkik.Controls.Add(this.lblDefaultIzlemler);
            this.gBoxHastaTetkik.Controls.Add(this.lblVurulanAsilar);
            this.gBoxHastaTetkik.Controls.Add(this.lblHastaIzlemleri);
            this.gBoxHastaTetkik.Controls.Add(this.btnTaniAra);
            this.gBoxHastaTetkik.Controls.Add(this.btnIlacAra);
            this.gBoxHastaTetkik.Controls.Add(this.btnSemptomAra);
            this.gBoxHastaTetkik.Controls.Add(this.hastaTanilar);
            this.gBoxHastaTetkik.Controls.Add(this.hastaIlaclar);
            this.gBoxHastaTetkik.Controls.Add(this.hastaSemptomlar);
            this.gBoxHastaTetkik.Location = new System.Drawing.Point(12, 376);
            this.gBoxHastaTetkik.Name = "gBoxHastaTetkik";
            this.gBoxHastaTetkik.Size = new System.Drawing.Size(860, 273);
            this.gBoxHastaTetkik.TabIndex = 12;
            this.gBoxHastaTetkik.TabStop = false;
            this.gBoxHastaTetkik.Text = "Hasta Tetkikleri";
            // 
            // lblDefaultIzlemler
            // 
            this.lblDefaultIzlemler.AutoSize = true;
            this.lblDefaultIzlemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultIzlemler.Location = new System.Drawing.Point(576, 13);
            this.lblDefaultIzlemler.Name = "lblDefaultIzlemler";
            this.lblDefaultIzlemler.Size = new System.Drawing.Size(143, 16);
            this.lblDefaultIzlemler.TabIndex = 50;
            this.lblDefaultIzlemler.Text = "Hasta Geçmiş Tanıları:";
            // 
            // lblVurulanAsilar
            // 
            this.lblVurulanAsilar.AutoSize = true;
            this.lblVurulanAsilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVurulanAsilar.Location = new System.Drawing.Point(289, 13);
            this.lblVurulanAsilar.Name = "lblVurulanAsilar";
            this.lblVurulanAsilar.Size = new System.Drawing.Size(146, 16);
            this.lblVurulanAsilar.TabIndex = 49;
            this.lblVurulanAsilar.Text = "Hasta Kullandığı İlaçlar:";
            // 
            // lblHastaIzlemleri
            // 
            this.lblHastaIzlemleri.AutoSize = true;
            this.lblHastaIzlemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaIzlemleri.Location = new System.Drawing.Point(6, 13);
            this.lblHastaIzlemleri.Name = "lblHastaIzlemleri";
            this.lblHastaIzlemleri.Size = new System.Drawing.Size(125, 16);
            this.lblHastaIzlemleri.TabIndex = 48;
            this.lblHastaIzlemleri.Text = "Hasta Semptomları:";
            // 
            // btnTaniAra
            // 
            this.btnTaniAra.Location = new System.Drawing.Point(607, 211);
            this.btnTaniAra.Name = "btnTaniAra";
            this.btnTaniAra.Size = new System.Drawing.Size(222, 56);
            this.btnTaniAra.TabIndex = 8;
            this.btnTaniAra.Text = "Tanı Listesini Güncelle";
            this.btnTaniAra.UseVisualStyleBackColor = true;
            this.btnTaniAra.Click += new System.EventHandler(this.btnTaniAra_Click);
            // 
            // btnIlacAra
            // 
            this.btnIlacAra.Location = new System.Drawing.Point(318, 211);
            this.btnIlacAra.Name = "btnIlacAra";
            this.btnIlacAra.Size = new System.Drawing.Size(222, 56);
            this.btnIlacAra.TabIndex = 7;
            this.btnIlacAra.Text = "İlaç Listesini Güncelle";
            this.btnIlacAra.UseVisualStyleBackColor = true;
            this.btnIlacAra.Click += new System.EventHandler(this.btnIlacAra_Click);
            // 
            // btnSemptomAra
            // 
            this.btnSemptomAra.Location = new System.Drawing.Point(32, 211);
            this.btnSemptomAra.Name = "btnSemptomAra";
            this.btnSemptomAra.Size = new System.Drawing.Size(222, 56);
            this.btnSemptomAra.TabIndex = 6;
            this.btnSemptomAra.Text = "Semptom Listesini Güncelle";
            this.btnSemptomAra.UseVisualStyleBackColor = true;
            this.btnSemptomAra.Click += new System.EventHandler(this.btnSemptomAra_Click);
            // 
            // hastaTanilar
            // 
            this.hastaTanilar.FormattingEnabled = true;
            this.hastaTanilar.Location = new System.Drawing.Point(579, 32);
            this.hastaTanilar.Name = "hastaTanilar";
            this.hastaTanilar.Size = new System.Drawing.Size(275, 173);
            this.hastaTanilar.TabIndex = 2;
            // 
            // hastaIlaclar
            // 
            this.hastaIlaclar.FormattingEnabled = true;
            this.hastaIlaclar.Location = new System.Drawing.Point(292, 32);
            this.hastaIlaclar.Name = "hastaIlaclar";
            this.hastaIlaclar.Size = new System.Drawing.Size(275, 173);
            this.hastaIlaclar.TabIndex = 1;
            // 
            // hastaSemptomlar
            // 
            this.hastaSemptomlar.FormattingEnabled = true;
            this.hastaSemptomlar.Location = new System.Drawing.Point(6, 32);
            this.hastaSemptomlar.Name = "hastaSemptomlar";
            this.hastaSemptomlar.Size = new System.Drawing.Size(275, 173);
            this.hastaSemptomlar.TabIndex = 0;
            // 
            // btnIlac
            // 
            this.btnIlac.Location = new System.Drawing.Point(359, 192);
            this.btnIlac.Name = "btnIlac";
            this.btnIlac.Size = new System.Drawing.Size(149, 35);
            this.btnIlac.TabIndex = 13;
            this.btnIlac.Text = "Reçete Oluştur";
            this.btnIlac.UseVisualStyleBackColor = true;
            this.btnIlac.Click += new System.EventHandler(this.btnIlac_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(358, 233);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(149, 35);
            this.btnRapor.TabIndex = 14;
            this.btnRapor.Text = "SGK İşgöremezlik Raporu Oluştur";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnSevk
            // 
            this.btnSevk.Location = new System.Drawing.Point(359, 274);
            this.btnSevk.Name = "btnSevk";
            this.btnSevk.Size = new System.Drawing.Size(149, 35);
            this.btnSevk.TabIndex = 15;
            this.btnSevk.Text = "Sevk Oluştur";
            this.btnSevk.UseVisualStyleBackColor = true;
            this.btnSevk.Click += new System.EventHandler(this.btnSevk_Click);
            // 
            // btnMuayene
            // 
            this.btnMuayene.Location = new System.Drawing.Point(359, 315);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Size = new System.Drawing.Size(149, 35);
            this.btnMuayene.TabIndex = 16;
            this.btnMuayene.Text = "Muayene Notu Oluştur";
            this.btnMuayene.UseVisualStyleBackColor = true;
            this.btnMuayene.Click += new System.EventHandler(this.btnMuayene_Click);
            // 
            // btnSaglikRaporu
            // 
            this.btnSaglikRaporu.Location = new System.Drawing.Point(514, 192);
            this.btnSaglikRaporu.Name = "btnSaglikRaporu";
            this.btnSaglikRaporu.Size = new System.Drawing.Size(149, 35);
            this.btnSaglikRaporu.TabIndex = 17;
            this.btnSaglikRaporu.Text = "Genel Sağlık Raporu Oluştur";
            this.btnSaglikRaporu.UseVisualStyleBackColor = true;
            this.btnSaglikRaporu.Click += new System.EventHandler(this.btnSaglikRaporu_Click);
            // 
            // btnAskerlikRaporu
            // 
            this.btnAskerlikRaporu.Location = new System.Drawing.Point(514, 233);
            this.btnAskerlikRaporu.Name = "btnAskerlikRaporu";
            this.btnAskerlikRaporu.Size = new System.Drawing.Size(149, 35);
            this.btnAskerlikRaporu.TabIndex = 18;
            this.btnAskerlikRaporu.Text = "Askerlik Raporu Oluştur";
            this.btnAskerlikRaporu.UseVisualStyleBackColor = true;
            this.btnAskerlikRaporu.Click += new System.EventHandler(this.btnAskerlikRaporu_Click);
            // 
            // btnSurucu
            // 
            this.btnSurucu.Location = new System.Drawing.Point(514, 274);
            this.btnSurucu.Name = "btnSurucu";
            this.btnSurucu.Size = new System.Drawing.Size(149, 35);
            this.btnSurucu.TabIndex = 19;
            this.btnSurucu.Text = "Sürücü Olur Belgesi Oluştur";
            this.btnSurucu.UseVisualStyleBackColor = true;
            this.btnSurucu.Click += new System.EventHandler(this.btnSurucu_Click);
            // 
            // btnSgk
            // 
            this.btnSgk.Enabled = false;
            this.btnSgk.Location = new System.Drawing.Point(514, 315);
            this.btnSgk.Name = "btnSgk";
            this.btnSgk.Size = new System.Drawing.Size(149, 35);
            this.btnSgk.TabIndex = 20;
            this.btnSgk.Text = "Medula Sistemi";
            this.btnSgk.UseVisualStyleBackColor = true;
            // 
            // muayeneNotlari
            // 
            this.muayeneNotlari.FormattingEnabled = true;
            this.muayeneNotlari.Location = new System.Drawing.Point(669, 47);
            this.muayeneNotlari.Name = "muayeneNotlari";
            this.muayeneNotlari.Size = new System.Drawing.Size(203, 225);
            this.muayeneNotlari.TabIndex = 21;
            // 
            // btnHastalikRaporu
            // 
            this.btnHastalikRaporu.Location = new System.Drawing.Point(514, 151);
            this.btnHastalikRaporu.Name = "btnHastalikRaporu";
            this.btnHastalikRaporu.Size = new System.Drawing.Size(149, 35);
            this.btnHastalikRaporu.TabIndex = 22;
            this.btnHastalikRaporu.Text = "Hastalık Raporu Oluştur";
            this.btnHastalikRaporu.UseVisualStyleBackColor = true;
            this.btnHastalikRaporu.Click += new System.EventHandler(this.btnHastalikRaporu_Click);
            // 
            // btnHastaBilgileriGuncelle
            // 
            this.btnHastaBilgileriGuncelle.Location = new System.Drawing.Point(514, 110);
            this.btnHastaBilgileriGuncelle.Name = "btnHastaBilgileriGuncelle";
            this.btnHastaBilgileriGuncelle.Size = new System.Drawing.Size(149, 35);
            this.btnHastaBilgileriGuncelle.TabIndex = 23;
            this.btnHastaBilgileriGuncelle.Text = "Hasta Bilgileri Güncelle";
            this.btnHastaBilgileriGuncelle.UseVisualStyleBackColor = true;
            this.btnHastaBilgileriGuncelle.Click += new System.EventHandler(this.btnHastaBilgileriGuncelle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(514, 69);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(149, 35);
            this.btnYeniKayit.TabIndex = 42;
            this.btnYeniKayit.Text = "Yeni Kayıt Oluştur";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnHastaArama
            // 
            this.btnHastaArama.Location = new System.Drawing.Point(514, 28);
            this.btnHastaArama.Name = "btnHastaArama";
            this.btnHastaArama.Size = new System.Drawing.Size(149, 35);
            this.btnHastaArama.TabIndex = 43;
            this.btnHastaArama.Text = "Hasta Arama";
            this.btnHastaArama.UseVisualStyleBackColor = true;
            this.btnHastaArama.Click += new System.EventHandler(this.btnHastaArama_Click);
            // 
            // lblMuayeneNotlari
            // 
            this.lblMuayeneNotlari.AutoSize = true;
            this.lblMuayeneNotlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuayeneNotlari.Location = new System.Drawing.Point(669, 28);
            this.lblMuayeneNotlari.Name = "lblMuayeneNotlari";
            this.lblMuayeneNotlari.Size = new System.Drawing.Size(108, 16);
            this.lblMuayeneNotlari.TabIndex = 45;
            this.lblMuayeneNotlari.Text = "Muayene Notları:";
            // 
            // btnNotAra
            // 
            this.btnNotAra.Location = new System.Drawing.Point(669, 294);
            this.btnNotAra.Name = "btnNotAra";
            this.btnNotAra.Size = new System.Drawing.Size(203, 56);
            this.btnNotAra.TabIndex = 51;
            this.btnNotAra.Text = "Not Listesini Güncelle";
            this.btnNotAra.UseVisualStyleBackColor = true;
            this.btnNotAra.Click += new System.EventHandler(this.btnNotAra_Click);
            // 
            // doktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnNotAra);
            this.Controls.Add(this.lblMuayeneNotlari);
            this.Controls.Add(this.btnHastaArama);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.btnHastaBilgileriGuncelle);
            this.Controls.Add(this.btnHastalikRaporu);
            this.Controls.Add(this.muayeneNotlari);
            this.Controls.Add(this.btnSgk);
            this.Controls.Add(this.btnSurucu);
            this.Controls.Add(this.btnAskerlikRaporu);
            this.Controls.Add(this.btnSaglikRaporu);
            this.Controls.Add(this.btnMuayene);
            this.Controls.Add(this.btnSevk);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnIlac);
            this.Controls.Add(this.gBoxHastaTetkik);
            this.Controls.Add(this.gBoxHastaBilgileri);
            this.Controls.Add(this.hastaCinsiyetPic);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "doktorForm";
            this.Text = "Dr. x | HBYS";
            this.Load += new System.EventHandler(this.doktorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaCinsiyetPic)).EndInit();
            this.gBoxHastaBilgileri.ResumeLayout(false);
            this.gBoxHastaBilgileri.PerformLayout();
            this.gBoxHastaTetkik.ResumeLayout(false);
            this.gBoxHastaTetkik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hastaCinsiyetPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.Label lblHastaSoyad;
        private System.Windows.Forms.Label lblHastaDogum;
        private System.Windows.Forms.Label lblHastaYas;
        private System.Windows.Forms.Label lblHastaTel;
        private System.Windows.Forms.Label lblHastaAdres;
        private System.Windows.Forms.Label lblHastaAnne;
        private System.Windows.Forms.Label lblHastaBaba;
        private System.Windows.Forms.Label lblHastaTc;
        private System.Windows.Forms.GroupBox gBoxHastaBilgileri;
        private System.Windows.Forms.Label lblHastaCinsiyet;
        private System.Windows.Forms.GroupBox gBoxHastaTetkik;
        private System.Windows.Forms.ListBox hastaSemptomlar;
        private System.Windows.Forms.ListBox hastaTanilar;
        private System.Windows.Forms.ListBox hastaIlaclar;
        private System.Windows.Forms.ListBox muayeneNotlari;
        private System.Windows.Forms.Label lblBoyKilo;
        private System.Windows.Forms.Label lblMuayeneNotlari;
        private System.Windows.Forms.Label lblDefaultIzlemler;
        private System.Windows.Forms.Label lblVurulanAsilar;
        private System.Windows.Forms.Label lblHastaIzlemleri;
        public System.Windows.Forms.Button btnIlac;
        public System.Windows.Forms.Button btnRapor;
        public System.Windows.Forms.Button btnSevk;
        public System.Windows.Forms.Button btnMuayene;
        public System.Windows.Forms.Button btnSaglikRaporu;
        public System.Windows.Forms.Button btnAskerlikRaporu;
        public System.Windows.Forms.Button btnSurucu;
        public System.Windows.Forms.Button btnSgk;
        public System.Windows.Forms.Button btnHastalikRaporu;
        public System.Windows.Forms.Button btnHastaBilgileriGuncelle;
        public System.Windows.Forms.Button btnYeniKayit;
        public System.Windows.Forms.Button btnHastaArama;
        public System.Windows.Forms.Button btnTaniAra;
        public System.Windows.Forms.Button btnIlacAra;
        public System.Windows.Forms.Button btnSemptomAra;
        public System.Windows.Forms.Button btnNotAra;
    }
}