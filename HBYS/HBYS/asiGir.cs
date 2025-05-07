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
    public partial class asiGir : Form
    {
        public string hastaIsim;
        public string hastaSoyisim;
        public string tcNo;
        public string cinsiyet;
        private hemsireFormu _hemsireFormu;

        public asiGir(hemsireFormu form)
        {
            InitializeComponent();
            _hemsireFormu = form;
        }

        private void asiGir_Load(object sender, EventArgs e)
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

            ilaclariComboBoxaYukle();
        }

        private void ilaclariComboBoxaYukle()
        {
            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT AsiAdi FROM Asi";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear(); // Daha önce eklenmiş verileri temizle

                        while (reader.Read())
                        {
                            string asiAdi = reader["AsiAdi"].ToString();
                            if (!string.IsNullOrWhiteSpace(asiAdi))
                            {
                                comboBox1.Items.Add(asiAdi.Trim());
                            }
                        }
                    }
                }
            }
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Trusted_Connection=True;"))
            {
                conn.Open();

                string asiAdi = comboBox1.Text;
                string asiKodu = textBox1.Text.Trim();
                int miktar = (int)numericUpDown1.Value;
                DateTime tarih = takvim.SelectionStart;
                string asiNotu = richTextBox1.Text;
                string hastaTC = tcNo;

                // Eğer kullanıcı aşı kodu girmişse, AsiAdi'yi veritabanından çek
                if (!string.IsNullOrEmpty(asiKodu))
                {
                    string checkQuery = "SELECT AsiAdi FROM Asi WHERE AsiKodu = @asiKodu";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@asiKodu", asiKodu);

                    var result = checkCmd.ExecuteScalar();

                    if (result != null)
                    {
                        string bulunanAsiAdi = result.ToString();
                        DialogResult onay = MessageBox.Show($"{bulunanAsiAdi} adlı aşıyı hastaya uygulamak üzeresiniz. Onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo);

                        if (onay == DialogResult.No)
                            return;

                        asiAdi = bulunanAsiAdi; // AsiAdi'yi güncelle
                    }
                    else
                    {
                        MessageBox.Show("Girilen aşı kodu veritabanında bulunamadı!", "Hatalı Aşı Kodu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Aşı kodu boşsa, combobox'tan seçilen AsiAdi'ye göre AsiKodu'nu bul
                    string getKoduQuery = "SELECT AsiKodu FROM Asi WHERE AsiAdi = @asiAdi";
                    SqlCommand getKoduCmd = new SqlCommand(getKoduQuery, conn);
                    getKoduCmd.Parameters.AddWithValue("@asiAdi", asiAdi);

                    var result = getKoduCmd.ExecuteScalar();

                    if (result != null)
                    {
                        asiKodu = result.ToString(); // AsiKodu'yu otomatik çek
                    }
                    else
                    {
                        MessageBox.Show("Seçilen aşı adı veritabanında bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // HastaAsi tablosuna veri ekle
                string insertQuery = @"INSERT INTO HastaAsi (TCKimlikNo, AsiAdi, AsiKodu, AsiVurulduguMiktar, AsiVurulduguTarih, AsiNotu)
                               VALUES (@tc, @asiAdi, @asiKodu, @miktar, @tarih, @not)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@tc", hastaTC);
                insertCmd.Parameters.AddWithValue("@asiAdi", asiAdi);
                insertCmd.Parameters.AddWithValue("@asiKodu", asiKodu);
                insertCmd.Parameters.AddWithValue("@miktar", miktar);
                insertCmd.Parameters.AddWithValue("@tarih", tarih);
                insertCmd.Parameters.AddWithValue("@not", asiNotu);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Aşı bilgisi başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _hemsireFormu.Show();
            }
        }
    }
}