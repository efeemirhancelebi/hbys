using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HBYS
{
    public partial class girisFormu: Form
    {
        public Form AnaForm { get; private set; }

        public girisFormu()
        {
            InitializeComponent();
            databaseOlusturma();
        }
        protected void databaseOlusturma()
        {
            string databaseAdi = "HastaBilgiYonetimSistemi";
            string masterConnStr = "Server=localhost\\SQLEXPRESS;Database=master;Integrated Security=true;";
            string dbConnStr = $"Server=localhost\\SQLEXPRESS;Database={databaseAdi};Integrated Security=true;";

            // 1. Veritabanı yoksa oluştur
            using (SqlConnection conn = new SqlConnection(masterConnStr))
            {
                conn.Open();
                string query = $"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'{databaseAdi}') CREATE DATABASE [{databaseAdi}];";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // 2. Tabloları kontrol et ve gerekiyorsa oluştur
            using (SqlConnection conn = new SqlConnection(dbConnStr))
            {
                conn.Open();

                // Personel Tablosu
                // Personel Tablosu (oluşturuluyorsa, seni yönetici olarak ekle)
                string personelQuery = @"
        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Personel' AND xtype='U')
        BEGIN
            CREATE TABLE Personel (
                Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                Isim NVARCHAR(50),
                Soyisim NVARCHAR(50),
                DogumTarihi DATE,
                TCKimlikNo NVARCHAR(11),
                Telefon NVARCHAR(15),
                EvAdresi NVARCHAR(200),
                Yas INT,
                Cinsiyet NVARCHAR(10),
                AnneAdi NVARCHAR(50),
                BabaAdi NVARCHAR(50),
                Unvan NVARCHAR(50),
                Sifre NVARCHAR(32)
            );

            INSERT INTO Personel (
                Isim, Soyisim, DogumTarihi, TCKimlikNo, Telefon, EvAdresi, Yas, Cinsiyet,
                AnneAdi, BabaAdi, Unvan, Sifre
            )
            VALUES (
                'Efe Emirhan', 'Çelebi', '2000-12-02', '38470530482', '05435821084',
                'Tekirdağ', 21, 'Erkek', 'Sevgiye', 'Necati', 'Yönetici', 'admin'
            );
            INSERT INTO Personel (
                Isim, Soyisim, DogumTarihi, TCKimlikNo, Telefon, EvAdresi, Yas, Cinsiyet,
                AnneAdi, BabaAdi, Unvan, Sifre
            )
            VALUES (
                'Efe Emirhan', 'Çelebi', '2000-12-02', '38470530482', '05435821084',
                'Tekirdağ', 21, 'Erkek', 'Sevgiye', 'Necati', 'Doktor', 'deneme'
            );
            INSERT INTO Personel (
                Isim, Soyisim, DogumTarihi, TCKimlikNo, Telefon, EvAdresi, Yas, Cinsiyet,
                AnneAdi, BabaAdi, Unvan, Sifre
            )
            VALUES (
                'Efe Emirhan', 'Çelebi', '2000-12-02', '38470530482', '05435821084',
                'Tekirdağ', 21, 'Erkek', 'Sevgiye', 'Necati', 'Hemsire', 'deneme1'
            );
        END;";
                new SqlCommand(personelQuery, conn).ExecuteNonQuery();

                // Hasta Tablosu
                string hastaQuery = @"
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Hasta' AND xtype='U')
BEGIN
    EXEC('
        CREATE TABLE Hasta (
            Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
            Isim NVARCHAR(50),
            Soyisim NVARCHAR(50),
            TCKimlikNo NVARCHAR(11),
            DogumTarihi DATE,
            Yas INT,
            Telefon NVARCHAR(15),
            EvAdresi NVARCHAR(200),
            AnneAdi NVARCHAR(50),
            BabaAdi NVARCHAR(50),
            Cinsiyet NVARCHAR(10),
            BoyKilo NVARCHAR(50),
            Izlemler NVARCHAR(200),
            MuayeneNotu NVARCHAR(MAX),
            Ilaclar NVARCHAR(200),
            IlacMiktari INT,
            Tanilar NVARCHAR(200),
            Semptomlar NVARCHAR(200),
            IsGormezlikRaporu NVARCHAR(10),
            IsGormezlikRaporuSonTarihi DATE,
            IsGormezlikRaporuNedeni NVARCHAR(MAX),
            Sevk NVARCHAR(100),
            SevkNedeni NVARCHAR(MAX),
            GenelSaglikRaporu NVARCHAR(10),
            GenelSaglikRaporuSonTarihi DATE,
            GenelSaglikRaporuNedeni NVARCHAR(MAX),
            AskerlikRaporu NVARCHAR(10),
            AskerlikRaporuSonTarihi DATE,
            AskerlikRaporuAciklamasi NVARCHAR(MAX),
            SurucuRaporu NVARCHAR(10),
            SurucuRaporuSonTarihi DATE,
            SurucuRaporuAciklamasi NVARCHAR(MAX),
            HastalikRaporu NVARCHAR(100),
            HastalikRaporuSonTarihi DATE,
            HastalikRaporuNedeni NVARCHAR(MAX),
            AileHekimi NVARCHAR(50)
        )
    ')
END";
                new SqlCommand(hastaQuery, conn).ExecuteNonQuery();

                string asiQuery = @"
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Asi' AND xtype='U')
BEGIN
    CREATE TABLE Asi (
        Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        AsiAdi NVARCHAR(100),
        AsiMiktari INT,
        AsiKodu NVARCHAR(50)
    );
END

IF NOT EXISTS (SELECT * FROM Asi)
BEGIN
    INSERT INTO Asi (AsiAdi, AsiMiktari, AsiKodu) VALUES
        ('BCG (Verem Aşısı)', 100, 'ASI001'),
        ('Hepatit B (HBV)', 100, 'ASI002'),
        ('DaBT-IPA-Hib (Beşli Karma Aşı)', 100, 'ASI003'),
        ('KPA (Konjuge Pnömokok Aşısı)', 100, 'ASI004'),
        ('OPA (Oral Polio Aşısı)', 100, 'ASI005'),
        ('Kızamık-Kızamıkçık-Kabakulak (KKK)', 100, 'ASI006'),
        ('Suçiçeği Aşısı', 100, 'ASI007'),
        ('Hepatit A', 100, 'ASI008'),
        ('Td Aşısı (Erişkin Difteri Tetanoz)', 100, 'ASI009'),
        ('İnfluenza (Grip) Aşısı', 100, 'ASI010'),
        ('COVID-19 Biontech', 100, 'ASI011'),
        ('COVID-19 Sinovac', 100, 'ASI012'),
        ('HPV (Rahim Ağzı Kanseri Aşısı)', 100, 'ASI013'),
        ('Meningokok Aşısı', 100, 'ASI014'),
        ('Rotavirüs Aşısı', 100, 'ASI015'),
        ('Zatürre Aşısı (Pnömokok Polisakkarit)', 100, 'ASI016'),
        ('Kuduz Aşısı', 100, 'ASI017'),
        ('Tetanoz Aşısı', 100, 'ASI018'),
        ('Tüberküloz Aşısı', 100, 'ASI019'),
        ('Kızamık Aşısı (Tekli)', 100, 'ASI020');
END";

                new SqlCommand(asiQuery, conn).ExecuteNonQuery();

                string hastaAsiQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='HastaAsi' AND xtype='U')
                CREATE TABLE HastaAsi (
                    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    TCKimlikNo NVARCHAR(11), -- Hasta ile ilişkilendirme için
                    AsiAdi NVARCHAR(100),
                    AsiKodu NVARCHAR(50),
                    AsiVurulduguMiktar INT,
                    AsiVurulduguTarih DATETIME,
                    AsiNotu NVARCHAR(MAX)
                );";

                new SqlCommand(hastaAsiQuery, conn).ExecuteNonQuery();


                // İlaç Tablosu (miktar yok + ilk veri ekleme)
                string ilacQuery = @"
        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Ilac' AND xtype='U')
        BEGIN
            CREATE TABLE Ilac (
                Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                IlacAdi NVARCHAR(100),
                IlacKodu NVARCHAR(50)
            );

            INSERT INTO Ilac (IlacAdi, IlacKodu) VALUES
            ('Parol 500 mg Tablet', 'ILC001'),
            ('Augmentin 625 mg Film Tablet', 'ILC002'),
            ('Ventolin Inhaler', 'ILC003'),
            ('Nurofen Cold & Flu', 'ILC004'),
            ('Dolorex 50 mg Film Tablet', 'ILC005'),
            ('Aferin Forte', 'ILC006'),
            ('Flagyl 500 mg Tablet', 'ILC007'),
            ('Zyrtec 10 mg Tablet', 'ILC008'),
            ('Minoset 500 mg Tablet', 'ILC009'),
            ('Ranitab 150 mg Tablet', 'ILC010'),
            ('Dekort 4 mg Tablet', 'ILC011'),
            ('Biteral 500 mg Tablet', 'ILC012'),
            ('Otrivine Nazal Sprey', 'ILC013'),
            ('Klamoks 500 mg Tablet', 'ILC014'),
            ('Talcid 500 mg Tablet', 'ILC015'),
            ('Buscopan Tablet', 'ILC016'),
            ('Monurol 3g Saşe', 'ILC017'),
            ('Dikloron 50 mg Tablet', 'ILC018'),
            ('Tylol Hot', 'ILC019'),
            ('Gripin', 'ILC020'),
            ('Zinnat 500 mg Tablet', 'ILC021'),
            ('Beloc Zok 50 mg Tablet', 'ILC022'),
            ('Glifor 1000 mg Tablet', 'ILC023'),
            ('Arveles 25 mg Tablet', 'ILC024'),
            ('İburamin Cold', 'ILC025');
        END;";
                new SqlCommand(ilacQuery, conn).ExecuteNonQuery();

                // Sağlık Ocağı Tablosu
                string saglikOcagiQuery = @"
        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SaglikOcagi' AND xtype='U')
        CREATE TABLE SaglikOcagi (
            Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
            Adres NVARCHAR(200),
            TadilatBilgileri NVARCHAR(200),
            Calisanlar NVARCHAR(200),
            GiderBilgileri NVARCHAR(200)
        );";
                new SqlCommand(saglikOcagiQuery, conn).ExecuteNonQuery();
            }
        }

        protected void girisIslemi()
        {
            string sifre = textSifre.Text.Trim();
            string tc = textTc.Text.Trim();

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=HastaBilgiYonetimSistemi;Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sorgu = "SELECT Unvan, Isim FROM Personel WHERE TCKimlikNo = @tc AND Sifre = @sifre";

                using (SqlCommand komut = new SqlCommand(sorgu, connection))
                {
                    komut.Parameters.AddWithValue("@tc", tc);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string unvan = reader["Unvan"].ToString().ToLower();
                            string isim = reader["Isim"].ToString();

                            if (unvan == "yönetici" || unvan == "yonetici")
                            {
                                var form = new yoneticiHesabi();
                                form.yoneticiAdi = isim;          // doktorAdi'ya veriyi gönderiyoruz
                                AnaForm = form;
                            }
                            else if (unvan == "hemsire" || unvan == "ebe")
                            {
                                var form = new hemsireFormu();
                                form.hemsireAdi = isim;          // doktorAdi'ya veriyi gönderiyoruz
                                AnaForm = form;
                            }
                            else if (unvan == "doktor")
                            {
                                var form = new doktorForm();
                                form.doktorAdi = isim;          // doktorAdi'ya veriyi gönderiyoruz
                                AnaForm = form;
                            }
                            else
                            {
                                MessageBox.Show("Yetki tanımsız.");
                                return;
                            }

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("TC veya şifre hatalı.");
                        }
                    }
                }
            }
        }



        private void btnHemsire_Click(object sender, EventArgs e)
        {
            girisIslemi();
        }
    }
}
