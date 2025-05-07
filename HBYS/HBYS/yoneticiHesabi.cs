using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HBYS
{
    public partial class yoneticiHesabi : Form
    {
        public string yoneticiAdi;

        public yoneticiHesabi()
        {
            InitializeComponent();
        }

        private void yoneticiHesabi_Load(object sender, EventArgs e)
        {
            // Karşılama metni
            label1.Text = "Hoşgeldiniz sayın Yön. " + yoneticiAdi;
            this.Text = "Yönetici " + yoneticiAdi + " | HBYS";

            // Liste kutularını temizle
            tumHastalar.Items.Clear();
            tumDoktorlar.Items.Clear();
            hemsireVeEbeler.Items.Clear();
            tumAsilar.Items.Clear();

            string connStr = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Hasta bilgilerini yükle
                using (SqlCommand cmd = new SqlCommand("SELECT Isim, Soyisim, TCKimlikNo FROM Hasta", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string isim = reader["Isim"].ToString();
                        string soyisim = reader["Soyisim"].ToString();
                        string tc = reader["TCKimlikNo"].ToString();
                        tumHastalar.Items.Add($"{isim} {soyisim} - {tc}");
                    }
                }

                // Doktor ve yönetici personeli yükle
                using (SqlCommand cmd = new SqlCommand("SELECT Isim, Soyisim, TCKimlikNo FROM Personel WHERE Unvan = 'doktor' OR Unvan = 'yönetici'", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string isim = reader["Isim"].ToString();
                        string soyisim = reader["Soyisim"].ToString();
                        string tc = reader["TCKimlikNo"].ToString();
                        tumDoktorlar.Items.Add($"{isim} {soyisim} - {tc}");
                    }
                }

                // Hemşire ve ebe personeli yükle
                using (SqlCommand cmd = new SqlCommand("SELECT Isim, Soyisim, TCKimlikNo FROM Personel WHERE Unvan = 'hemşire' OR Unvan = 'ebe'", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string isim = reader["Isim"].ToString();
                        string soyisim = reader["Soyisim"].ToString();
                        string tc = reader["TCKimlikNo"].ToString();
                        hemsireVeEbeler.Items.Add($"{isim} {soyisim} - {tc}");
                    }
                }

                // Aşı bilgilerini alfabetik sıraya göre AsiKodu ile yükle
                using (SqlCommand cmd = new SqlCommand("SELECT AsiAdi, AsiKodu, AsiMiktari FROM Asi ORDER BY AsiKodu", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string asiAdi = reader["AsiAdi"].ToString();
                        string asiKodu = reader["AsiKodu"].ToString();
                        string asiMiktari = reader["AsiMiktari"].ToString();

                        tumAsilar.Items.Add($"{asiAdi} | Kod: {asiKodu} | Miktar: {asiMiktari}");
                    }
                }
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            string connStr = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                foreach (var item in tumHastalar.CheckedItems)
                {
                    string secilen = item.ToString();
                    string tc = secilen.Split('-')[1].Trim();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Hasta WHERE TCKimlikNo = @tc", conn);
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Seçili hastalar silindi.");
            yoneticiHesabi_Load(null, null);
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (tumHastalar.CheckedItems.Count != 1)
            {
                MessageBox.Show("Lütfen sadece bir hasta seçin.");
                return;
            }

            // Seçilen hastayı alıyoruz (örnek: "Ahmet Yılmaz - 12345678900")
            string secilen = tumHastalar.CheckedItems[0].ToString();

            // Şimdi string parçalanıyor, "-" karakterine göre ayırıyoruz
            string[] parcalar = secilen.Split('-');

            if (parcalar.Length != 2)
            {
                MessageBox.Show("Seçili hasta formatı hatalı.");
                return;
            }

            // TC bilgisi "-" karakterinden sonra geliyor
            string tc = parcalar[1].Trim(); // "12345678900"
            string tcNo = tc;

            // Formu oluşturup tc'yi gönderiyoruz
            hastaBilgileriGuncelle form = new hastaBilgileriGuncelle(this, tcNo);
            form.Show();
            this.Hide();
        }

        private void btnRaporGecmisi_Click(object sender, EventArgs e)
        {
            if (tumHastalar.CheckedItems.Count != 1)
            {
                MessageBox.Show("Lütfen sadece bir hasta seçin.");
                return;
            }
            string tc = tumHastalar.CheckedItems[0].ToString().Split('-')[1].Trim();
            string baslik = "Rapor Geçmişi:";
            dataGridView form = new dataGridView(tc, this, "raporGecmisi", baslik);
            form.Show();
            this.Hide();
        }

        private void btnBelgeGecmisi_Click(object sender, EventArgs e)
        {
            if (tumHastalar.CheckedItems.Count != 1)
            {
                MessageBox.Show("Lütfen sadece bir hasta seçin.");
                return;
            }
            string tc = tumHastalar.CheckedItems[0].ToString().Split('-')[1].Trim();
            string baslik = "Belge Geçmişi:";
            dataGridView form = new dataGridView(tc, this, "belgeGecmisi", baslik);
            form.Show();
            this.Hide();
        }

        private void btnReceteGecmisi_Click(object sender, EventArgs e)
        {
            if (tumHastalar.CheckedItems.Count != 1)
            {
                MessageBox.Show("Lütfen sadece bir hasta seçin.");
                return;
            }
            string tc = tumHastalar.CheckedItems[0].ToString().Split('-')[1].Trim();
            string baslik = "Reçete Geçmişi:";
            dataGridView form = new dataGridView(tc, this, "receteGecmisi", baslik);
            form.Show();
            this.Hide();
        }

        private void btnHastaAsiGecmisi_Click(object sender, EventArgs e)
        {
            if (tumHastalar.CheckedItems.Count != 1)
            {
                MessageBox.Show("Lütfen sadece bir hasta seçin.");
                return;
            }
            string tc = tumHastalar.CheckedItems[0].ToString().Split('-')[1].Trim();
            string baslik = "Aşı Geçmişi:";
            dataGridView form = new dataGridView(tc, this, "asi", baslik);
            form.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
