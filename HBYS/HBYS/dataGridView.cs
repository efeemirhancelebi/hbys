using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBYS
{
    public partial class dataGridView: Form
    {
        private string _tc;
        private Form _hemsireFormu;
        private string _mod;
        private string _baslik;

        public dataGridView(string tc, Form hemsireFormu, string mod = "rapor", string baslik = "")
        {
            InitializeComponent();
            _tc = tc;
            _hemsireFormu = hemsireFormu;
            _mod = mod;
            _baslik = baslik;
            if (_mod == "rapor") 
            {
                RaporVerileriniGetir();
                this.Text = "SGK İşgörmezlik Rapor Verileri";
                label1.Text = baslik;
            }
            else if (_mod == "sevk")
            {
                SevkVerileriniGetir();
                this.Text = "Sevk Verileri";
                label1.Text = baslik;
            }
            else if (_mod == "asi")
            {
                asiBilgileriGetir();
                this.Text = "Hastaya Ait Aşı Bilgileri";
                label1.Text = baslik;
            }
            else if (_mod == "stok")
            {
                StokBilgileriniGetir();
                this.Text = "Aşı Stok Bilgileri";
                label1.Text = baslik;
            }
            else if (_mod == "genelRapor")
            {
                GenelSaglikRaporuGetir();
                this.Text = "Genel Sağlık Raporu Bilgileri";
                label1.Text = baslik;
            }
            else if (_mod == "askerlikRapor")
            {
                AskerlikRaporuGetir();
                this.Text = "Askerlik Raporu Bilgileri";
                label1.Text = baslik;
            }

            else if (_mod == "surucu")
            {
                SurucuRaporuGetir();
                this.Text = "Sürücü Sağlık Raporu Verileri";
                label1.Text = baslik;
            }

            else if (_mod == "hastalik")
            {
                HastalikRaporuGetir();
                this.Text = "Hastalık Raporu Verileri";
                label1.Text = baslik;
            }

            else if (_mod == "belgeGecmisi")
            {
                belgeGecmisiGetir();
                this.Text = "Belge Geçmişi";
                label1.Text = baslik;
            }

            else if (_mod == "raporGecmisi")
            {
                raporGecmisiGetir();
                this.Text = "Rapor Geçmişi";
                label1.Text = baslik;
            }

            else if (_mod == "receteGecmisi")
            {
                receteGecmisiGetir();
                this.Text = "Reçete Geçmişi";
                label1.Text = baslik;
            }

            else if (_mod == "asi")
            {
                asiGecmisiGetir();
                this.Text = "Aşı Geçmişi";
                label1.Text = baslik;
            }
        }

        private void asiGecmisiGetir()
        {
            string connStr = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT 
                TCKimlikNo AS 'TC Kimlik No',
                AsiAdi AS 'Aşı Adı',
                AsiKodu AS 'Aşı Kodu',
                AsiVurulduguMiktar AS 'Aşı Miktarı',
                AsiVurulduguTarih AS 'Aşı Tarihi',
                AsiNotu AS 'Aşı Notu'
            FROM HastaAsi
            WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void receteGecmisiGetir()
        {
            string connStr = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT 
                Isim AS 'Ad',
                Soyisim AS 'Soyad',
                TCKimlikNo AS 'TC Kimlik No',
                MuayeneNotu AS 'Muayene Notu',
                Ilaclar AS 'İlaçlar',
                IlacMiktari AS 'İlaç Miktarı',
                Semptomlar AS 'Semptomlar',
                Tanilar AS 'Tanılar',
                Izlemler AS 'İzlemler'
            FROM Hasta
            WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void raporGecmisiGetir()
        {
            string connStr = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT 
                Isim AS 'Ad',
                Soyisim AS 'Soyad',
                TCKimlikNo AS 'TC Kimlik No',
                IsGormezlikRaporu AS 'İşgörmezlik Raporu',
                IsGormezlikRaporuSonTarihi AS 'İşgörmezlik Raporu Son Tarihi',
                IsGormezlikRaporuNedeni AS 'İşgörmezlik Nedeni',
                HastalikRaporu AS 'Hastalık Raporu',
                HastalikRaporuSonTarihi AS 'Hastalık Raporu Son Tarihi',
                HastalikRaporuNedeni AS 'Hastalık Nedeni'
            FROM Hasta
            WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void belgeGecmisiGetir()
        {
            string connStr = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT 
                Isim AS 'Ad',
                Soyisim AS 'Soyad',
                TCKimlikNo AS 'TC Kimlik No',
                Sevk AS 'Sevk Edilen Hastane',
                SevkNedeni AS 'Sevk Nedeni',
                AskerlikRaporu AS 'Askerlik Raporu',
                AskerlikRaporuSonTarihi AS 'Askerlik Raporu Son Tarihi',
                AskerlikRaporuAciklamasi AS 'Askerlik Raporu Açıklaması',
                SurucuRaporu AS 'Sürücü Raporu',
                SurucuRaporuSonTarihi AS 'Sürücü Raporu Son Tarihi',
                SurucuRaporuAciklamasi AS 'Sürücü Raporu Açıklaması'
            FROM Hasta
            WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void RaporVerileriniGetir()
        {
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT 
                                    Isim AS [Ad], 
                                    Soyisim AS [Soyad], 
                                    TCKimlikNo AS [TC Kimlik No],
                                    Cinsiyet, 
                                    DogumTarihi AS [Doğum Tarihi], 
                                    IsGormezlikRaporu AS [Rapor Var Mı],
                                    IsGormezlikRaporuSonTarihi AS [Rapor Son Tarih],
                                    IsGormezlikRaporuNedeni AS [Rapor Nedeni]
                                FROM Hasta
                                WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                }
            }
        }

        private void SevkVerileriniGetir()
        {
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT 
                                Isim AS [Ad], 
                                Soyisim AS [Soyad], 
                                TCKimlikNo AS [TC Kimlik No],
                                Cinsiyet, 
                                DogumTarihi AS [Doğum Tarihi], 
                                Sevk AS [Sevk Edilen Hastane],
                                SevkNedeni AS [Sevk Nedeni]
                            FROM Hasta
                            WHERE TCKimlikNo = @tc AND Sevk IS NOT NULL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            _hemsireFormu.Show();
            this.Close();
        }

        private void asiBilgileriGetir()
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                h.Isim AS 'Ad',
                h.Soyisim AS 'Soyad',
                h.TCKimlikNo AS 'TC Kimlik No',
                h.Cinsiyet AS 'Cinsiyet',
                h.DogumTarihi AS 'Doğum Tarihi',
                ha.AsiAdi AS 'Aşı Adı',
                ha.AsiKodu AS 'Aşı Kodu',
                ha.AsiVurulduguMiktar AS 'Aşı Miktarı',
                ha.AsiNotu AS 'Aşı Notu'
            FROM Hasta h
            INNER JOIN HastaAsi ha ON h.TCKimlikNo = ha.TCKimlikNo
            WHERE h.TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void StokBilgileriniGetir()
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                AsiAdi AS 'Aşı Adı',
                AsiMiktari AS 'Stoktaki Miktar',
                AsiKodu AS 'Aşı Kodu'
            FROM Asi";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void GenelSaglikRaporuGetir()
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                Isim AS 'Ad',
                Soyisim AS 'Soyad',
                TCKimlikNo AS 'TC Kimlik No',
                Yas AS 'Yaş',
                DogumTarihi AS 'Doğum Tarihi',
                GenelSaglikRaporu AS 'Genel Sağlık Raporu Var mı?',
                GenelSaglikRaporuSonTarihi AS 'Rapor Bitiş Tarihi',
                GenelSaglikRaporuNedeni AS 'Rapor Nedeni'
            FROM Hasta
            WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void AskerlikRaporuGetir()
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                Isim AS 'Ad',
                Soyisim AS 'Soyad',
                TCKimlikNo AS 'TC Kimlik No',
                Yas AS 'Yaş',
                DogumTarihi AS 'Doğum Tarihi',
                AskerlikRaporu AS 'Askerlik Raporu Var mı?',
                AskerlikRaporuSonTarihi AS 'Rapor Bitiş Tarihi',
                AskerlikRaporuAciklamasi AS 'Rapor Açıklaması'
            FROM Hasta
            WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void SurucuRaporuGetir()
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                Isim AS 'Ad',
                Soyisim AS 'Soyad',
                TCKimlikNo AS 'TC Kimlik No',
                Yas AS 'Yaş',
                DogumTarihi AS 'Doğum Tarihi',
                SurucuRaporu AS 'Sürücü Raporu Var mı?',
                SurucuRaporuSonTarihi AS 'Rapor Bitiş Tarihi',
                SurucuRaporuAciklamasi AS 'Rapor Açıklaması'
            FROM Hasta
            WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void HastalikRaporuGetir()
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                Isim AS 'Ad',
                Soyisim AS 'Soyad',
                TCKimlikNo AS 'TC Kimlik No',
                Yas AS 'Yaş',
                DogumTarihi AS 'Doğum Tarihi',
                HastalikRaporu AS 'Hastalık Raporu Var mı?',
                HastalikRaporuSonTarihi AS 'Rapor Bitiş Tarihi',
                HastalikRaporuNedeni AS 'Rapor Nedeni'
            FROM Hasta
            WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", _tc);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}