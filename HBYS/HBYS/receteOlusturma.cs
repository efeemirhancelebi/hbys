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
    public partial class receteOlusturma: Form
    {
        public string hastaIsim;
        public string hastaSoyisim;
        public string tcNo;
        public string cinsiyet;
        private doktorForm _doktorForm;

        public receteOlusturma(doktorForm form)
        {
            InitializeComponent();
            _doktorForm = form;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ilaclariComboBoxaYukle()
        {
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT IlacAdi FROM Ilac";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear(); // Daha önce eklenmiş verileri temizle

                        while (reader.Read())
                        {
                            string ilacAdi = reader["IlacAdi"].ToString();
                            if (!string.IsNullOrWhiteSpace(ilacAdi))
                            {
                                comboBox1.Items.Add(ilacAdi.Trim());
                            }
                        }
                    }
                }
            }
        }

        private void receteOlusturma_Load(object sender, EventArgs e)
        {
            labelHastaAdi.Text = labelHastaAdi.Text + " " + hastaIsim;
            labelHastaSoyadi.Text = labelHastaSoyadi.Text + " " + hastaSoyisim;
            labelHastaTc.Text = labelHastaTc.Text + " " + tcNo;
            labelCinsiyet.Text = labelCinsiyet.Text + " " + cinsiyet;


            ilaclariComboBoxaYukle();

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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string secilenIlac = comboBox1.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(secilenIlac))
            {
                recete.Items.Add(secilenIlac);
            }
        }

        private void ilacKoduIleEkle()
        {
            string girilenKod = textBox1.Text.Trim(); // ilaç kodu yazılan textbox
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT IlacAdi FROM Ilac WHERE IlacKodu = @kod";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kod", girilenKod);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string ilacAdi = result.ToString();
                        recete.Items.Add(ilacAdi);
                    }
                    else
                    {
                        MessageBox.Show("Girilen ilaç koduna ait bir ilaç bulunamadı.");
                    }
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ilacKoduIleEkle();
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            string tc = tcNo.Trim(); // TC'nin alındığı textbox
            if (string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("Lütfen hastanın TC Kimlik numarasını giriniz.");
                return;
            }

            if (recete.Items.Count == 0)
            {
                MessageBox.Show("Reçete listesinde ekli ilaç yok.");
                return;
            }

            // Reçete listesini virgülle ayırarak tek bir string'e çevir
            List<string> ilaclarListesi = new List<string>();
            foreach (var item in recete.Items)
            {
                ilaclarListesi.Add(item.ToString());
            }
            string ilaclarMetni = string.Join(", ", ilaclarListesi);

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE Hasta SET Ilaclar = @ilaclar WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ilaclar", ilaclarMetni);
                    cmd.Parameters.AddWithValue("@tc", tc);

                    int etkilenenSatir = cmd.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Reçete başarıyla hastanın ilaçlar sütununa kaydedildi.");
                        _doktorForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hasta bulunamadı veya güncelleme başarısız oldu.");

                    }
                }
            }
        }
    }
}
