using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBYS
{
    public partial class hastalikRaporu: Form
    {
        public string hastaIsim;
        public string hastaSoyisim;
        public string tcNo;
        public string cinsiyet;
        private doktorForm _doktorForm;

        public hastalikRaporu(doktorForm form)
        {
            InitializeComponent();
            _doktorForm = form;
        }

        private void hastalikRaporu_Load(object sender, EventArgs e)
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
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            string raporDurumu = "";

            if (btnEvet.Checked)
            {
                raporDurumu = "Evet";
            }
            else if (btnHayir.Checked)
            {
                raporDurumu = "Hayır";
            }
            else
            {
                MessageBox.Show("Lütfen rapor durumunu seçiniz (Evet/Hayır).");
                return;
            }

            string raporSonTarihi = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string raporNedeni = richTextBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(raporNedeni))
            {
                MessageBox.Show("Lütfen rapor nedenini giriniz.");
                return;
            }

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"UPDATE Hasta SET 
                            HastalikRaporu = @rapor, 
                            HastalikRaporuSonTarihi = @tarih, 
                            HastalikRaporuNedeni = @neden 
                         WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@rapor", raporDurumu);
                    cmd.Parameters.AddWithValue("@tarih", raporSonTarihi);
                    cmd.Parameters.AddWithValue("@neden", raporNedeni);
                    cmd.Parameters.AddWithValue("@tc", tcNo);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Hastalık raporu başarıyla kaydedildi.");

                        // Yazıcı işlemi
                        if (yaziciEvet.Checked)
                        {
                            PrintDialog pd = new PrintDialog();
                            PrintDocument doc = new PrintDocument();

                            doc.PrintPage += (s, ev) =>
                            {
                                ev.Graphics.DrawString("Hastalık Raporu", new Font("Arial", 16), Brushes.Black, new PointF(100, 100));
                                ev.Graphics.DrawString($"TC: {tcNo}", new Font("Arial", 12), Brushes.Black, new PointF(100, 140));
                                ev.Graphics.DrawString($"Rapor: {raporDurumu}", new Font("Arial", 12), Brushes.Black, new PointF(100, 160));
                                ev.Graphics.DrawString($"Son Tarih: {raporSonTarihi}", new Font("Arial", 12), Brushes.Black, new PointF(100, 180));
                                ev.Graphics.DrawString($"Nedeni: {raporNedeni}", new Font("Arial", 12), Brushes.Black, new PointF(100, 200));
                            };

                            pd.Document = doc;

                            if (pd.ShowDialog() == DialogResult.OK)
                            {
                                doc.Print();
                            }
                        }

                        _doktorForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hasta bulunamadı veya güncelleme başarısız.");
                    }
                }
            }
        }
    }
}
