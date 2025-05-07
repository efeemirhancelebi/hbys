using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HBYS
{
    public partial class hastaBilgileri : Form
    {
        private doktorForm _doktorForm;
        private hemsireFormu _hemsireFormu;
        private string _kaynakForm;

        // Doktor formundan gelen constructor
        public hastaBilgileri(doktorForm form, string kaynakForm)
        {
            InitializeComponent();
            _doktorForm = form;
            _kaynakForm = "doktor";
        }

        // Hemşire formundan gelen constructor
        public hastaBilgileri(hemsireFormu form, string kaynakForm)
        {
            InitializeComponent();
            _hemsireFormu = form;
            _kaynakForm = "hemsire";
        }

        protected void veritabaniIslemleri()
        {
            string isim = textAd.Text.Trim();
            string soyisim = textSoyad.Text.Trim();
            string tc = textTc.Text.Trim();
            string telefon = textTel.Text.Trim();
            string anne = textAnne.Text.Trim();
            string baba = textBaba.Text.Trim();
            string boy = textBoy.Text.Trim();
            string kilo = textKilo.Text.Trim();
            string evAdresi = rAdres.Text.Trim();
            DateTime dogumTarih = dateDogumTarihi.Value;
            string cinsiyet = radioErkek.Checked ? "Erkek" : (radioKadin.Checked ? "Kadın" : "");
            string boyKilo = $"{boy}-{kilo}";

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                    INSERT INTO Hasta 
                    (Isim, Soyisim, TCKimlikNo, DogumTarihi, Telefon, EvAdresi, AnneAdi, BabaAdi, Cinsiyet, BoyKilo) 
                    VALUES 
                    (@isim, @soyisim, @tc, @dogum, @tel, @adres, @anne, @baba, @cinsiyet, @boykilo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isim", isim);
                    cmd.Parameters.AddWithValue("@soyisim", soyisim);
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@dogum", dogumTarih);
                    cmd.Parameters.AddWithValue("@tel", telefon);
                    cmd.Parameters.AddWithValue("@adres", evAdresi);
                    cmd.Parameters.AddWithValue("@anne", anne);
                    cmd.Parameters.AddWithValue("@baba", baba);
                    cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@boykilo", boyKilo);

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                        MessageBox.Show("Yeni kayıt başarıyla eklendi.");
                    else
                        MessageBox.Show("Kayıt eklenirken bir sorun oluştu.");
                }
            }
        }

        protected void veritabaniIslemleri2()
        {
            string isim = textAd.Text.Trim();
            string soyisim = textSoyad.Text.Trim();
            string tc = textTc.Text.Trim();
            string telefon = textTel.Text.Trim();
            string anne = textAnne.Text.Trim();
            string baba = textBaba.Text.Trim();
            string boy = textBoy.Text.Trim();
            string kilo = textKilo.Text.Trim();
            string evAdresi = rAdres.Text.Trim();
            DateTime dogumTarih = dateDogumTarihi.Value;
            string cinsiyet = radioErkek.Checked ? "Erkek" : (radioKadin.Checked ? "Kadın" : "");
            string boyKilo = $"{boy}-{kilo}";

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                    INSERT INTO Hasta 
                    (Isim, Soyisim, TCKimlikNo, DogumTarihi, Telefon, EvAdresi, AnneAdi, BabaAdi, Cinsiyet, BoyKilo) 
                    VALUES 
                    (@isim, @soyisim, @tc, @dogum, @tel, @adres, @anne, @baba, @cinsiyet, @boykilo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isim", isim);
                    cmd.Parameters.AddWithValue("@soyisim", soyisim);
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@dogum", dogumTarih);
                    cmd.Parameters.AddWithValue("@tel", telefon);
                    cmd.Parameters.AddWithValue("@adres", evAdresi);
                    cmd.Parameters.AddWithValue("@anne", anne);
                    cmd.Parameters.AddWithValue("@baba", baba);
                    cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@boykilo", boyKilo);

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                        MessageBox.Show("Yeni kayıt başarıyla eklendi.");
                    else
                        MessageBox.Show("Kayıt eklenirken bir sorun oluştu.");
                }
            }
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (_kaynakForm == "hemsire")
            {
                veritabaniIslemleri2();
                _hemsireFormu?.Show();
            }
            else if (_kaynakForm == "doktor")
            {
                veritabaniIslemleri();
                _doktorForm?.Show();
            }

            this.Close();
        }

        private void hastaBilgileri_Load(object sender, EventArgs e)
        {
            // Gerekli işlemler varsa buraya yazabilirsin.
        }
    }
}
