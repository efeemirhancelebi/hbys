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
    public partial class sevk: Form
    {
        public string hastaIsim;
        public string hastaSoyisim;
        public string tcNo;
        public string cinsiyet;
        private doktorForm _doktorForm;

        public sevk(doktorForm form)
        {
            InitializeComponent();
            _doktorForm = form;
        }

        private void sevk_Load(object sender, EventArgs e)
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

        private void btnSevk_Click(object sender, EventArgs e)
        {
            sevkBilgisiniKaydet();
        }

        private void sevkBilgisiniKaydet()
        {
            string secilenHastane = hastaneler.SelectedItem?.ToString();
            string sevkNedeni = richTextBox1.Text.Trim();
            string tc = tcNo.Trim(); // tcNo değişkeni hasta TC'sini içermeli

            if (string.IsNullOrWhiteSpace(secilenHastane) || string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("Sevk edilecek hastane veya hasta bilgisi eksik.");
                return;
            }

            string connStr = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "UPDATE Hasta SET Sevk = @sevk, SevkNedeni = @neden WHERE TCKimlikNo = @tc";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sevk", secilenHastane);
                    cmd.Parameters.AddWithValue("@neden", sevkNedeni);
                    cmd.Parameters.AddWithValue("@tc", tc);

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Sevk bilgisi başarıyla güncellendi.");
                        // Yazıcı işlemi
                        if (yaziciEvet.Checked)
                        {
                            PrintDialog pd = new PrintDialog();
                            PrintDocument doc = new PrintDocument();

                            doc.PrintPage += (s, ev) =>
                            {
                                ev.Graphics.DrawString("Sevk Durumu", new Font("Arial", 16), Brushes.Black, new PointF(100, 100));
                                ev.Graphics.DrawString($"TC: {tcNo}", new Font("Arial", 12), Brushes.Black, new PointF(100, 140));
                                ev.Graphics.DrawString($"Sevk Edilen Hastane: {secilenHastane}", new Font("Arial", 12), Brushes.Black, new PointF(100, 160));
                                ev.Graphics.DrawString($"Nedeni: {sevkNedeni}", new Font("Arial", 12), Brushes.Black, new PointF(100, 200));
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
