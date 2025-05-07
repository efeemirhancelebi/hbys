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
    public partial class hemsireFormu : Form
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
        public string hemsireAdi;
        private doktorForm _doktorForm;
        private string baslik;

        public hemsireFormu()
        {
            InitializeComponent();
        }

        private void btnHastaArama_Click(object sender, EventArgs e)
        {
            hastaArama hastaAramaForm = new hastaArama(this);
            hastaAramaForm.Show();
            this.Hide();
        }

        private void hemsireFormu_Load(object sender, EventArgs e)
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
            label1.Text = "Hoşgeldiniz sayın Hem. " + hemsireAdi;
            this.Text = "Hem. " + hemsireAdi + " | HBYS";

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

            if (!string.IsNullOrWhiteSpace(tcNo))
            {
                notlariGetir();
                asilariGetir();
                izlemleriGetir();
            }
            else { }

            if (string.IsNullOrWhiteSpace(tcNo))
            {
                btnIzlemAra.Enabled = false;
                btnAsiAra.Enabled = false;
                btnRaporIncele.Enabled = false;
                btnSevkIncele.Enabled = false;
                btnAsiOlustur.Enabled = false;
                btnAsiBilgileri.Enabled = false;
                btnSaglikRaporuIncele.Enabled = false;
                btnAskerlikRaporuIncele.Enabled = false;
                btnSurucuIncele.Enabled = false;
                btnHastalikRaporlariIncele.Enabled = false;
                btnNotAra.Enabled = false;
            }

            // Yalnızca izlem verisi olan ayları listeye ekle
            izlemVerileri.Add("0. Ay", new List<string>
    {
        "Doğumda genel fizik muayene yapılır.",
        "Topuk kanı alınarak metabolik hastalık taraması yapılır.",
        "İşitme testi uygulanır.",
        "Hepatit B aşısının ilk dozu uygulanır."
    });

            izlemVerileri.Add("1. Ay", new List<string>
    {
        "Baş kontrolü değerlendirilir.",
        "Kilo artışı takip edilir.",
        "Beslenme düzeni ve emzirme durumu gözden geçirilir."
    });

            izlemVerileri.Add("2. Ay", new List<string>
    {
        "Beşli karma aşı (1. doz) uygulanır.",
        "Pnömokok (KPA) aşısı yapılır.",
        "Hepatit B aşısının 2. dozu uygulanır.",
        "Görsel ve işitsel uyarılara tepkiler değerlendirilir."
    });

            izlemVerileri.Add("4. Ay", new List<string>
    {
        "Beşli karma aşı (2. doz) yapılır.",
        "KPA (2. doz) uygulanır.",
        "Motor gelişim ve el-göz koordinasyonu değerlendirilir."
    });

            izlemVerileri.Add("6. Ay", new List<string>
    {
        "Beşli karma aşı (3. doz), OPA (1. doz) uygulanır.",
        "Ek gıdaya geçiş değerlendirilir.",
        "Desteksiz oturma yetisi gözlemlenir."
    });

            izlemVerileri.Add("9. Ay", new List<string>
    {
        "Kızamık-Kızamıkçık-Kabakulak (KKK) aşısı (1. doz) yapılır.",
        "Nesnelere uzanma ve el becerileri değerlendirilir.",
        "Yabancı kişilere karşı tepkiler gözlemlenir."
    });

            izlemVerileri.Add("12. Ay", new List<string>
    {
        "Suçiçeği aşısı yapılır.",
        "Hepatit A (1. doz) uygulanır.",
        "Yürüme ve ilk kelimeler takip edilir."
    });

            izlemVerileri.Add("18. Ay", new List<string>
    {
        "Beşli karma pekiştirme dozu yapılır.",
        "KKK pekiştirme dozu uygulanır.",
        "Hepatit A (2. doz) yapılır.",
        "Tuvalet eğitimi ve sosyal gelişim değerlendirilir."
    });

            // ListBox'a sadece veri olan ayları ekle
            foreach (var ay in izlemVerileri.Keys)
            {
                defaultIzlemler.Items.Add(ay);
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
            asilariGetir();
            izlemleriGetir();
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

        private void izlemleriGetir()
        {
            string tc = tcNo.Trim();
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT Izlemler FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string izlemler = reader["Izlemler"].ToString();

                            // ListBox'ı temizle
                            hastaIzlemler.Items.Clear();

                            if (!string.IsNullOrWhiteSpace(izlemler))
                            {
                                string[] izlemListesi = izlemler.Split(',');

                                foreach (var izlem in izlemListesi)
                                {
                                    hastaIzlemler.Items.Add(izlem.Trim());
                                }
                            }
                            else
                            {
                                hastaIzlemler.Items.Add("İzlem kaydı bulunamadı.");
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

        private void asilariGetir()
        {
            string tc = tcNo.Trim();
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT AsiAdi FROM HastaAsi WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string asilar = reader["AsiAdi"].ToString();

                            // ListBox'ı temizle
                            hastaAsilar.Items.Clear();

                            if (!string.IsNullOrWhiteSpace(asilar))
                            {
                                string[] asiListesi = asilar.Split(',');

                                foreach (var asi in asiListesi)
                                {
                                    hastaAsilar.Items.Add(asi.Trim());
                                }
                            }
                            else
                            {
                                hastaAsilar.Items.Add("Aşı kaydı bulunamadı.");
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

        private void btnNotAra_Click(object sender, EventArgs e)
        {
            notlariGetir();
        }

        private void btnAsiAra_Click(object sender, EventArgs e)
        {
            asilariGetir();
        }

        private void btnIzlemAra_Click(object sender, EventArgs e)
        {
            izlemleriGetir();
        }

        private void btnRaporIncele_Click(object sender, EventArgs e)
        {
            string baslik = "Rapor Bilgileri:";
            string tc = tcNo.Trim();
            dataGridView form = new dataGridView(tc, this, "rapor");
            form.Show();
            this.Hide();
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme5();
            this.Hide();
        }

        protected void hastaBilgileriniGetirme5()
        {
            string tc = tcNo.Trim();
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
        protected void hastaBilgileriniGetirme1()
        {
            if (string.IsNullOrEmpty(tcNo)) { MessageBox.Show("Lütfen bir hasta seçiniz."); return; }
            string tc = tcNo.Trim();
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
                            asiGir asiGir = new asiGir(this);
                            asiGir.cinsiyet = cinsiyet;
                            asiGir.hastaIsim = isim;
                            asiGir.hastaSoyisim = soyisim;
                            asiGir.tcNo = tcNo;
                            asiGir.Show(this);
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btnSevkIncele_Click(object sender, EventArgs e)
        {
            string baslik = "Sevk Durumları:";
            string tc = tcNo.Trim();
            dataGridView form = new dataGridView(tc, this, "sevk", baslik);
            form.Show();
            this.Hide();
        }

        private void btnAsiOlustur_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetirme1();
            this.Hide();
        }

        private void btnAsiBilgileri_Click(object sender, EventArgs e)
        {
            string baslik = "Aşı Bilgileri:";
            string tc = tcNo.Trim();
            dataGridView form = new dataGridView(tc, this, "asi", baslik);
            form.Show();
            this.Hide();
        }

        Dictionary<string, List<string>> izlemVerileri = new Dictionary<string, List<string>>();

        private void defaultIzlemler_DoubleClick(object sender, EventArgs e)
        {
            string secilenAy = defaultIzlemler.SelectedItem?.ToString();
            if (secilenAy != null && izlemVerileri.ContainsKey(secilenAy))
            {
                List<string> detaylar = izlemVerileri[secilenAy];
                string mesaj = string.Join(Environment.NewLine + "- ", detaylar);
                MessageBox.Show("- " + mesaj, $"{secilenAy} Sağlıklı İzlem Ölçütleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            hastaBilgileri form = new hastaBilgileri(this, "hemsire");
            form.Show();
            this.Hide(); // opsiyonel
        }

        private void btnStokBilgileri_Click(object sender, EventArgs e)
        {
            string baslik = "Stok Bilgileri:";
            dataGridView stokFormu = new dataGridView("", this, "stok", baslik);
            stokFormu.Show();
            this.Hide();
        }

        private void btnSaglikRaporuIncele_Click(object sender, EventArgs e)
        {
            string baslik = "Genel Sağlık Raporları:";
            dataGridView raporFormu = new dataGridView(tcNo, this, "genelRapor", baslik);
            raporFormu.Show();
            this.Hide();
        }

        private void btnAskerlikRaporuIncele_Click(object sender, EventArgs e)
        {
            string baslik = "Askerlik Raporları:";
            dataGridView askerlikFormu = new dataGridView(tcNo, this, "askerlikRapor", baslik);
            askerlikFormu.Show();
            this.Hide();
        }

        private void btnSurucuIncele_Click(object sender, EventArgs e)
        {
            string baslik = "Sürücü Raporları:";
            dataGridView form = new dataGridView(tcNo, this, "surucu", baslik);
            form.Show();
            this.Hide();
        }

        private void btnHastalikRaporlariIncele_Click(object sender, EventArgs e)
        {
            string baslik = "Hastalık Raporları:";
            dataGridView form = new dataGridView(tcNo, this, "hastalik", baslik);
            form.Show();
            this.Hide();
        }

        private void hastaIzlemler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}