using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace HBYS
{
    public partial class hastaArama : Form
    {
        private doktorForm _doktorForm;
        private hemsireFormu _hemsireFormu;

        // Doktor formundan çağrılırsa
        public hastaArama(doktorForm form)
        {
            InitializeComponent();
            _doktorForm = form;
        }

        // Hemşire formundan çağrılırsa
        public hastaArama(hemsireFormu form)
        {
            InitializeComponent();
            _hemsireFormu = form;
        }

        protected void hastaBilgileriniGetir()
        {
            string tc = textTc.Text.Trim();
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
                            string isim = reader["Isim"].ToString();
                            string soyisim = reader["Soyisim"].ToString();
                            string dogumTarihi = reader["DogumTarihi"].ToString();
                            string telefon = reader["Telefon"].ToString();
                            string adres = reader["EvAdresi"].ToString();
                            string cinsiyet = reader["Cinsiyet"].ToString();
                            string anneAdi = reader["AnneAdi"].ToString();
                            string babaAdi = reader["BabaAdi"].ToString();
                            string tcKimlik = reader["TCKimlikNo"].ToString();
                            string boyKilo = reader["BoyKilo"].ToString();

                            // Eğer doktor formu üzerinden geldiyse
                            if (_doktorForm != null)
                            {
                                _doktorForm.hastaIsim = isim;
                                _doktorForm.hastaSoyisim = soyisim;
                                _doktorForm.dogumTarihi = dogumTarihi;
                                _doktorForm.telefon = telefon;
                                _doktorForm.adres = adres;
                                _doktorForm.cinsiyet = cinsiyet;
                                _doktorForm.anneIsim = anneAdi;
                                _doktorForm.babaIsim = babaAdi;
                                _doktorForm.tcNo = tcKimlik;
                                _doktorForm.kiloBoy = boyKilo;

                                // Butonların aktif hale getirilmesi örnek; doktorForm'daki kontrollerin public olması gerekir.
                                _doktorForm.btnSemptomAra.Enabled = true;
                                _doktorForm.btnTaniAra.Enabled = true;
                                _doktorForm.btnNotAra.Enabled = true;
                                _doktorForm.btnIlac.Enabled = true;
                                _doktorForm.btnRapor.Enabled = true;
                                _doktorForm.btnSevk.Enabled = true;
                                _doktorForm.btnMuayene.Enabled = true;
                                _doktorForm.btnHastalikRaporu.Enabled = true;
                                _doktorForm.btnSaglikRaporu.Enabled = true;
                                _doktorForm.btnAskerlikRaporu.Enabled = true;
                                _doktorForm.btnSurucu.Enabled = true;

                                _doktorForm.BilgileriEkranaYansit();
                                _doktorForm.Show();
                            }
                            // Eğer hemşire formu üzerinden geldiyse
                            else if (_hemsireFormu != null)
                            {
                                _hemsireFormu.hastaIsim = isim;
                                _hemsireFormu.hastaSoyisim = soyisim;
                                _hemsireFormu.dogumTarihi = dogumTarihi;
                                _hemsireFormu.telefon = telefon;
                                _hemsireFormu.adres = adres;
                                _hemsireFormu.cinsiyet = cinsiyet;
                                _hemsireFormu.anneIsim = anneAdi;
                                _hemsireFormu.babaIsim = babaAdi;
                                _hemsireFormu.tcNo = tcKimlik;
                                _hemsireFormu.kiloBoy = boyKilo;

                                _hemsireFormu.btnAsiAra.Enabled = true;
                                _hemsireFormu.btnIzlemAra.Enabled = true;
                                _hemsireFormu.btnRaporIncele.Enabled = true;
                                _hemsireFormu.btnSevkIncele.Enabled = true;
                                _hemsireFormu.btnAsiOlustur.Enabled = true;
                                _hemsireFormu.btnAsiBilgileri.Enabled = true;
                                _hemsireFormu.btnStokBilgileri.Enabled = true;
                                _hemsireFormu.btnSaglikRaporuIncele.Enabled = true;
                                _hemsireFormu.btnAskerlikRaporuIncele.Enabled = true;
                                _hemsireFormu.btnSurucuIncele.Enabled = true;
                                _hemsireFormu.btnHastalikRaporlariIncele.Enabled = true;
                                _hemsireFormu.btnNotAra.Enabled = true;

                                _hemsireFormu.BilgileriEkranaYansit();
                                _hemsireFormu.Show();
                            }

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            hastaBilgileriniGetir();
        }
    }
}
