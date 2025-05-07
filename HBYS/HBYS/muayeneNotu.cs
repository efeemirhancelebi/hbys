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
    public partial class muayeneNotu: Form
    {
        public string hastaIsim;
        public string hastaSoyisim;
        public string tcNo;
        public string cinsiyet;
        private doktorForm _doktorForm;

        public muayeneNotu(doktorForm form)
        {
            InitializeComponent();
            _doktorForm = form;
        }

        private void muayeneNotu_Load(object sender, EventArgs e)
        {
            labelHastaAdi.Text = labelHastaAdi.Text + " " + hastaIsim;
            labelHastaSoyadi.Text = labelHastaSoyadi.Text + " " + hastaSoyisim;
            labelHastaTc.Text = labelHastaTc.Text + " " + tcNo;
            labelCinsiyet.Text = labelCinsiyet.Text + " " + cinsiyet;

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

            semptomlariYukle();
            tanilariYukle();
        }

        private void semptomlariYukle()
        {
            string tc = tcNo.Trim(); // tcNo değişkeni, hastanın TC Kimlik No'su

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT Semptomlar FROM Hasta WHERE TCKimlikNo = @tc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    object result = cmd.ExecuteScalar();
                    if (result != null && !string.IsNullOrWhiteSpace(result.ToString()))
                    {
                        string semptomlar = result.ToString();
                        string[] semptomListesi = semptomlar.Split(',');

                        hastaSemptomlari.Items.Clear();
                        foreach (string semptom in semptomListesi)
                        {
                            hastaSemptomlari.Items.Add(semptom.Trim());
                        }
                    }
                    else
                    {
                        hastaSemptomlari.Items.Clear();
                    }
                }
            }
        }

        private void tanilariYukle()
        {
            string tc = tcNo.Trim(); // tcNo değişkeni, hastanın TC Kimlik No'su

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT Tanilar FROM Hasta WHERE TCKimlikNo = @tc";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);

                    object result = cmd.ExecuteScalar();
                    if (result != null && !string.IsNullOrWhiteSpace(result.ToString()))
                    {
                        string tanilar = result.ToString();
                        string[] taniListesi = tanilar.Split(',');

                        hastaTanilari.Items.Clear();
                        foreach (string tani in taniListesi)
                        {
                            hastaTanilari.Items.Add(tani.Trim());
                        }
                    }
                    else
                    {
                        hastaTanilari.Items.Clear();
                    }
                }
            }
        }

        private void btnSemptomEkle_Click(object sender, EventArgs e)
        {
            string yeniSemptom = hastaSemptomuEkle.Text.Trim();

            if (!string.IsNullOrWhiteSpace(yeniSemptom))
            {
                hastaSemptomlari.Items.Add(yeniSemptom);
                hastaSemptomuEkle.Clear();
            }
            else
            {
            }
        }

        private void semptomlariVeritabaninaKaydet()
        {
            string tc = tcNo.Trim(); // Hastanın TC Kimlik numarası
            if (string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("TC Kimlik numarası geçerli değil.");
                return;
            }

            if (hastaSemptomlari.Items.Count == 0)
            {
                MessageBox.Show("Listede semptom bulunmamaktadır.");
                return;
            }

            // ListBox'taki semptomları virgülle ayırarak tek string haline getir
            List<string> semptomListesi = new List<string>();
            foreach (var item in hastaSemptomlari.Items)
            {
                semptomListesi.Add(item.ToString());
            }

            string semptomMetni = string.Join(", ", semptomListesi);

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE Hasta SET Semptomlar = @semptom WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@semptom", semptomMetni);
                    cmd.Parameters.AddWithValue("@tc", tc);

                    int etkilenen = cmd.ExecuteNonQuery();
                    if (etkilenen > 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız. Hasta bulunamamış olabilir.");
                    }
                }
            }
        }

        private void tanilariVeritabaninaKaydet()
        {
            string tc = tcNo.Trim(); // Hastanın TC Kimlik numarası
            if (string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("TC Kimlik numarası geçerli değil.");
                return;
            }

            if (hastaTanilari.Items.Count == 0)
            {
                MessageBox.Show("Listede semptom bulunmamaktadır.");
                return;
            }

            // ListBox'taki semptomları virgülle ayırarak tek string haline getir
            List<string> taniListesi = new List<string>();
            foreach (var item in hastaTanilari.Items)
            {
                taniListesi.Add(item.ToString());
            }

            string taniMetni = string.Join(", ", taniListesi);

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE Hasta SET Tanilar = @tani WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tani", taniMetni);
                    cmd.Parameters.AddWithValue("@tc", tc);

                    int etkilenen = cmd.ExecuteNonQuery();
                    if (etkilenen > 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız. Hasta bulunamamış olabilir.");
                    }
                }
            }
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            string tc = tcNo.Trim(); // Hasta TC Kimlik numarası
            string not = muayeninNotu.Text.Trim(); // RichTextBox'tan alınan not

            if (string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("TC Kimlik numarası boş olamaz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(not))
            {
                MessageBox.Show("Lütfen not giriniz.");
                return;
            }

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE Hasta SET MuayeneNotu = @not WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@not", not);
                    cmd.Parameters.AddWithValue("@tc", tc);

                    int etkilenen = cmd.ExecuteNonQuery();

                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Muayene notu başarıyla kaydedildi.");
                        _doktorForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hasta bulunamadı veya not eklenemedi.");
                    }
                }
            }
            
            semptomlariVeritabaninaKaydet();
            tanilariVeritabaninaKaydet();
        }

        private void btnTaniEkle_Click(object sender, EventArgs e)
        {
            string yeniTani = textTani.Text.Trim();

            if (!string.IsNullOrWhiteSpace(yeniTani))
            {
                hastaTanilari.Items.Add(yeniTani);
                textTani.Clear();
            }
            else
            {
            }
        }
    }
}
