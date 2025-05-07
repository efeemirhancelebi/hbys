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
    public partial class hastaBilgileriGuncelle : Form
    {
        public string tcNo;
        public string cinsiyet;
        private Form _gelenForm;
        public string _tc;

        public hastaBilgileriGuncelle(Form gelenForm, string tc)
        {
            InitializeComponent();
            _gelenForm = gelenForm;
            _tc = tc;
        }

        private void hastaBilgileriGuncelle_Load(object sender, EventArgs e)
        {
            textTc.Text = tcNo;
            VerileriYukle(_tc);

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
        }

        private void VerileriYukle(string tcNo)
        {
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Hasta WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tcNo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textAd.Text = reader["Isim"].ToString();
                            textSoyad.Text = reader["Soyisim"].ToString();
                            textTel.Text = reader["Telefon"].ToString();
                            adres.Text = reader["EvAdresi"].ToString();
                            textAnne.Text = reader["AnneAdi"].ToString();
                            textBaba.Text = reader["BabaAdi"].ToString();
                            textTc.Text = reader["TCKimlikNo"].ToString();

                            // Doğum tarihi
                            if (DateTime.TryParse(reader["DogumTarihi"].ToString(), out DateTime dt))
                            {
                                dogumTarihi.Value = dt;
                            }

                            // Cinsiyet
                            string cinsiyet = reader["Cinsiyet"].ToString().ToLower();
                            if (cinsiyet == "erkek")
                                radioErkek.Checked = true;
                            else if (cinsiyet == "kadın" || cinsiyet == "kadin")
                                radioKadin.Checked = true;

                            // Boy - Kilo
                            string boyKilo = reader["BoyKilo"].ToString();
                            if (boyKilo.Contains("-"))
                            {
                                var parcalar = boyKilo.Split('-');
                                if (parcalar.Length == 2)
                                {
                                    textBoy.Text = parcalar[0];
                                    textKilo.Text = parcalar[1];
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hasta bilgisi bulunamadı.");
                        }
                    }
                }
            }
        }

        private void BilgileriGuncelle()
        {
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            string isim = textAd.Text.Trim();
            string soyisim = textSoyad.Text.Trim();
            string tc = textTc.Text.Trim();
            string tel = textTel.Text.Trim();
            string evAdresi = adres.Text.Trim();
            string anneAdi = textAnne.Text.Trim();
            string babaAdi = textBaba.Text.Trim();
            string cinsiyet = radioErkek.Checked ? "Erkek" : (radioKadin.Checked ? "Kadın" : "");
            string dogumTarihiStr = dogumTarihi.Value.ToString("yyyy-MM-dd");
            string kiloBoy = $"{textBoy.Text.Trim()}-{textKilo.Text.Trim()}";

            if (string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("TC Kimlik numarası boş olamaz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"UPDATE Hasta SET 
                            Isim = @isim,
                            Soyisim = @soyisim,
                            Telefon = @tel,
                            EvAdresi = @adres,
                            AnneAdi = @anne,
                            BabaAdi = @baba,
                            Cinsiyet = @cinsiyet,
                            DogumTarihi = @dogumTarihi,
                            BoyKilo = @kiloBoy
                         WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isim", isim);
                    cmd.Parameters.AddWithValue("@soyisim", soyisim);
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@adres", evAdresi);
                    cmd.Parameters.AddWithValue("@anne", anneAdi);
                    cmd.Parameters.AddWithValue("@baba", babaAdi);
                    cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@dogumTarihi", dogumTarihiStr);
                    cmd.Parameters.AddWithValue("@kiloBoy", kiloBoy);

                    int etki = cmd.ExecuteNonQuery();
                    if (etki > 0)
                    {
                        MessageBox.Show("Hasta bilgileri başarıyla güncellendi.");
                        _gelenForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız. TC numarası hatalı olabilir.");

                    }
                }
            }
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            BilgileriGuncelle();
            this.Close();
        }
    }
}