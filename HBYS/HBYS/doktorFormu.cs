using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBYS
{
    public partial class doktorForm: Form
    {
        public string hastaIsim;
        public string hastaSoyisim;
        public string dogumTarihi;
        public string telefon;
        public string adres;
        public string cinsiyet;
        public string anneIsim;
        public string babaIsim;
        public string tcNo;
        public string kiloBoy;
        public string doktorAdi;

        public doktorForm()
        {
            InitializeComponent();
        }

        private void btnTaniAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tcNo))
            {
                tanilariGetir();
            }
            else { }
        }

        private void btnIlac_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme();
        }

        private void doktorForm_Load(object sender, EventArgs e)
        {
            lblHastaAd.Text = lblHastaAd.Text + " " + hastaIsim;
            lblHastaSoyad.Text = lblHastaSoyad.Text + " " + hastaSoyisim;
            lblHastaDogum.Text = lblHastaDogum.Text + " " + dogumTarihi;
            lblHastaTc.Text = lblHastaTc.Text + " " + tcNo;
            lblHastaTel.Text = lblHastaTel.Text + " " + telefon;
            lblHastaAdres.Text = lblHastaAdres.Text + " " + adres;
            lblHastaCinsiyet.Text = lblHastaCinsiyet.Text + " " + cinsiyet;
            lblHastaAnne.Text = lblHastaAnne.Text + " " + anneIsim;
            lblHastaBaba.Text = lblHastaBaba.Text + " " + babaIsim;
            lblBoyKilo.Text = lblBoyKilo.Text + " " + kiloBoy;
            label1.Text = "Hoşgeldiniz sayın Dr. " + doktorAdi;
            this.Text = "Dr. " + doktorAdi + " | HBYS";

            string yol = Path.Combine(Application.StartupPath, "image", "man.png");
            string yol2 = Path.Combine(Application.StartupPath, "image", "businesswoman.png");

            if (!string.IsNullOrWhiteSpace(cinsiyet))
            {
                string temizCinsiyet = cinsiyet.Trim().ToLower();

                if (temizCinsiyet == "erkek")
                {
                    hastaCinsiyetPic.Image = Image.FromFile(yol);
                }
                else if (temizCinsiyet == "kadın" || temizCinsiyet == "kadin")
                {
                    hastaCinsiyetPic.Image = Image.FromFile(yol2);
                }
                else
                {
                    hastaCinsiyetPic.Image = null; // Bilinmeyen cinsiyet durumu
                }
            }
            else
            {
                hastaCinsiyetPic.Image = null; // cinsiyet boş veya null ise resim yükleme
            }

            if(!string.IsNullOrWhiteSpace(tcNo))
            {
                semptomlariGetir();
                ilaclariGetir();
                tanilariGetir();
                notlariGetir();
            }
            else { }

            if (string.IsNullOrWhiteSpace(tcNo))
            {
                btnIlac.Enabled = false;
                btnHastalikRaporu.Enabled = false;
                btnRapor.Enabled = false;
                btnSevk.Enabled = false;
                btnMuayene.Enabled = false;
                btnSaglikRaporu.Enabled = false;
                btnAskerlikRaporu.Enabled = false;
                btnSurucu.Enabled = false;
                btnSemptomAra.Enabled = false;
                btnIlacAra.Enabled = false;
                btnTaniAra.Enabled = false;
                btnNotAra.Enabled = false;
            }
        }

        public void BilgileriEkranaYansit()
        {
            lblHastaAd.Text = "Ad: " + hastaIsim;
            lblHastaSoyad.Text = "Soyad: " + hastaSoyisim;
            lblHastaDogum.Text = "Doğum Tarihi: " + dogumTarihi;
            lblHastaTc.Text = "TC: " + tcNo;
            lblHastaTel.Text = "Telefon: " + telefon;
            lblHastaAdres.Text = "Adres: " + adres;
            lblHastaCinsiyet.Text = "Cinsiyet: " + cinsiyet;
            lblHastaAnne.Text = "Anne Adı: " + anneIsim;
            lblHastaBaba.Text = "Baba Adı: " + babaIsim;
            lblBoyKilo.Text = "Boy/Kilo: " + kiloBoy;

            string yol = Path.Combine(Application.StartupPath, "image", "man.png");
            string yol2 = Path.Combine(Application.StartupPath, "image", "businesswoman.png");

            if (!string.IsNullOrWhiteSpace(cinsiyet))
            {
                string temizCinsiyet = cinsiyet.Trim().ToLower();

                if (temizCinsiyet == "erkek")
                {
                    hastaCinsiyetPic.Image = Image.FromFile(yol);
                }
                else if (temizCinsiyet == "kadın" || temizCinsiyet == "kadin")
                {
                    hastaCinsiyetPic.Image = Image.FromFile(yol2);
                }
                else
                {
                    hastaCinsiyetPic.Image = null;
                }
            }
            else
            {
                hastaCinsiyetPic.Image = null;
            }

            notlariGetir();
            ilaclariGetir();
            semptomlariGetir();
        }

        private void btnHastaArama_Click(object sender, EventArgs e)
        {
            hastaArama hastaAramaForm = new hastaArama(this);
            hastaAramaForm.Show();
            this.Hide();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme2();
            this.Hide();
        }

        private void btnSevk_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme3();
            this.Hide();
        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme4();
            this.Hide();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            hastaBilgileri form = new hastaBilgileri(this, "doktor");
            form.Show();
            this.Hide();
        }

        private void btnHastaBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme5();
            this.Hide();
        }

        private void btnHastalikRaporu_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme6();
            this.Hide();
        }

        private void btnSaglikRaporu_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme7();
            this.Hide();
        }

        private void btnAskerlikRaporu_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme8();
            this.Hide();
        }

        private void btnSurucu_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void semptomlariGetir()
        {
            string tc = tcNo.Trim();
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT Semptomlar FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string semptomlar = reader["Semptomlar"].ToString();

                            // Listeyi temizle
                            hastaSemptomlar.Items.Clear();

                            // Eğer semptomlar virgülle ayrılmışsa
                            if (!string.IsNullOrWhiteSpace(semptomlar))
                            {
                                string[] semptomListesi = semptomlar.Split(',');

                                foreach (var semptom in semptomListesi)
                                {
                                    hastaSemptomlar.Items.Add(semptom.Trim());
                                }
                            }
                            else
                            {
                                hastaSemptomlar.Items.Add("Semptom kaydı bulunamadı.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.");
                        }
                    }
                }
            }
        }

        private void btnSemptomAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tcNo))
            {
                semptomlariGetir();
            }
            else { }
        }

        private void ilaclariGetir()
        {
            string tc = tcNo.Trim();
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT Ilaclar FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string ilaclar = reader["Ilaclar"].ToString();

                            // ListBox'ı temizle
                            hastaIlaclar.Items.Clear();

                            if (!string.IsNullOrWhiteSpace(ilaclar))
                            {
                                string[] ilacListesi = ilaclar.Split(',');

                                foreach (var ilac in ilacListesi)
                                {
                                    hastaIlaclar.Items.Add(ilac.Trim());
                                }
                            }
                            else
                            {
                                hastaIlaclar.Items.Add("İlaç kaydı bulunamadı.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.");
                        }
                    }
                }
            }
        }

        private void notlariGetir()
        {
            string tc = tcNo.Trim();
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT MuayeneNotu FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string muayeneNots = reader["MuayeneNotu"].ToString();

                            // ListBox'ı temizle
                            muayeneNotlari.Items.Clear();

                            if (!string.IsNullOrWhiteSpace(muayeneNots))
                            {
                                string[] notListesi = muayeneNots.Split(',');

                                foreach (var not in notListesi)
                                {
                                    muayeneNotlari.Items.Add(not.Trim());
                                }
                            }
                            else
                            {
                                muayeneNotlari.Items.Add("Not kaydı bulunamadı.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.");
                        }
                    }
                }
            }
        }

        private void tanilariGetir()
        {
            string tc = tcNo.Trim();
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT Tanilar FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tanilar = reader["Tanilar"].ToString();

                            // ListBox'ı temizle
                            hastaTanilar.Items.Clear();

                            if (!string.IsNullOrWhiteSpace(tanilar))
                            {
                                string[] taniListesi = tanilar.Split(',');

                                foreach (var tani in taniListesi)
                                {
                                    hastaTanilar.Items.Add(tani.Trim());
                                }
                            }
                            else
                            {
                                hastaTanilar.Items.Add("Tanı kaydı bulunamadı.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.");
                        }
                    }
                }
            }
        }

        protected void hastaBilgileriniGetirme()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            receteOlusturma receteOlusturma = new receteOlusturma(this);
                            receteOlusturma.hastaIsim = isim;
                            receteOlusturma.hastaSoyisim = soyisim;
                            receteOlusturma.cinsiyet = cinsiyet;
                            receteOlusturma.tcNo = tcNo;
                            receteOlusturma.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        protected void hastaBilgileriniGetirme2()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            isgormezlik isgormezlik = new isgormezlik(this);
                            isgormezlik.hastaIsim = isim;
                            isgormezlik.hastaSoyisim = soyisim;
                            isgormezlik.cinsiyet = cinsiyet;
                            isgormezlik.tcNo = tcNo;
                            isgormezlik.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        protected void hastaBilgileriniGetirme3()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            sevk sevk = new sevk(this);
                            sevk.hastaIsim = isim;
                            sevk.hastaSoyisim = soyisim;
                            sevk.cinsiyet = cinsiyet;
                            sevk.tcNo = tcNo;
                            sevk.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        protected void hastaBilgileriniGetirme4()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            muayeneNotu muayeneNotu = new muayeneNotu(this);
                            muayeneNotu.hastaIsim = isim;
                            muayeneNotu.hastaSoyisim = soyisim;
                            muayeneNotu.cinsiyet = cinsiyet;
                            muayeneNotu.tcNo = tcNo;
                            muayeneNotu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        protected void hastaBilgileriniGetirme5()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            hastaBilgileriGuncelle hastaBilgileriGuncelle = new hastaBilgileriGuncelle(this, tc);
                            hastaBilgileriGuncelle.cinsiyet = cinsiyet;
                            hastaBilgileriGuncelle.tcNo = tcNo;
                            hastaBilgileriGuncelle.Show(this);
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        protected void hastaBilgileriniGetirme6()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            hastalikRaporu hastalikRaporu = new hastalikRaporu(this);
                            hastalikRaporu.hastaIsim = isim;
                            hastalikRaporu.hastaSoyisim = soyisim;
                            hastalikRaporu.cinsiyet = cinsiyet;
                            hastalikRaporu.tcNo = tcNo;
                            hastalikRaporu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        protected void hastaBilgileriniGetirme7()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            genelSaglikRaporu genelSaglikRaporu = new genelSaglikRaporu(this);
                            genelSaglikRaporu.hastaIsim = isim;
                            genelSaglikRaporu.hastaSoyisim = soyisim;
                            genelSaglikRaporu.cinsiyet = cinsiyet;
                            genelSaglikRaporu.tcNo = tcNo;
                            genelSaglikRaporu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        protected void hastaBilgileriniGetirme8()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            askerlikRaporu askerlikRaporu = new askerlikRaporu(this);
                            askerlikRaporu.hastaIsim = isim;
                            askerlikRaporu.hastaSoyisim = soyisim;
                            askerlikRaporu.cinsiyet = cinsiyet;
                            askerlikRaporu.tcNo = tcNo;
                            askerlikRaporu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        protected void hastaBilgileriniGetirme9()
        {
            string tc = tcNo.Trim();
            if (string.IsNullOrEmpty(tc)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bilgileri oku
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            // Diğer sütunlar da burada alınabilir...

                            // Yeni formu oluştur ve verileri aktar
                            surucuRaporu surucuRaporu = new surucuRaporu(this);
                            surucuRaporu.hastaIsim = isim;
                            surucuRaporu.hastaSoyisim = soyisim;
                            surucuRaporu.cinsiyet = cinsiyet;
                            surucuRaporu.tcNo = tcNo;
                            surucuRaporu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        private void btnIlacAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tcNo))
            {
                ilaclariGetir();
            }
            else { }
        }

        private void btnNotAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tcNo))
            {
                notlariGetir();
            }
            else { }
        }
    }
}
