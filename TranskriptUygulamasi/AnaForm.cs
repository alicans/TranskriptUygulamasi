using Transkript.Data;

namespace TranskriptUygulamasi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            OrnekVerileriYukle();
        }

        private void OrnekVerileriYukle()
        {
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Ahmet", Soyad = "Yýlmaz", Numara = 230301049 });
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Can", Soyad = "Söylemez", Numara = 230301050 });
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Ece", Soyad = "Telkývýran", Numara = 230301051 });
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Ali", Soyad = "Kaya", Numara = 230301052 });
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Kemal", Soyad = "Yýldýrým", Numara = 230301053 });

            Database.donemler.Add(new Donem() { Ad = "2019-2020 Güz Dönemi", No = "2019-1" });
            Database.donemler.Add(new Donem() { Ad = "2019-2020 Bahar Dönemi", No = "2019-2" });
            Database.donemler.Add(new Donem() { Ad = "2020-2021 Güz Dönemi", No = "2020-1" });
            Database.donemler.Add(new Donem() { Ad = "2020-2021 Bahar Dönemi", No = "2020-2" });
            Database.donemler.Add(new Donem() { Ad = "2021-2022 Güz Dönemi", No = "2021-1" });

            Database.dersler.Add(new Ders() { Adi = "Veri Yapýlarý", Kodu = "BLM201", Kredi = 2.5 });
            Database.dersler.Add(new Ders() { Adi = "Algoritma ve Programlama", Kodu = "BLM101", Kredi = 3.5 });
            Database.dersler.Add(new Ders() { Adi = "Nesne Tabanlý Programlama", Kodu = "BLM203", Kredi = 3 });
            Database.dersler.Add(new Ders() { Adi = "Bilgisayar Organizasyonu", Kodu = "BLM102", Kredi = 4 });
            Database.dersler.Add(new Ders() { Adi = "Ýþletim Sistemleri", Kodu = "BLM202", Kredi = 5 });

        }

        private void tsmOgrenciTanimla_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciEkleForm());
        }

        private void tsmDonemEkle_Click(object sender, EventArgs e)
        {
            FormGoster(new DonemEkleForm());
        }

        private void tsmDersEkle_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkleForm());
        }

        private void tsmNotAtama_Click(object sender, EventArgs e)
        {
            FormGoster(new DersAtamaForm());
        }

        private void tsmTranskript_Click(object sender, EventArgs e)
        {
            FormGoster(new TranskriptForm());
        }

        public void FormGoster(Form secilenForm)
        {
            secilenForm.StartPosition = 0;

            // bu ana formun çocuklarý içerisinde gezelim
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true;
                    form.Show(); //istenenin açýlmasý
                }
                else
                    form.Close(); //açýk olan varsa kapatýlmasý
            }
            if (!durum)
            {
                secilenForm.MdiParent = this;
                secilenForm.Show();
            }
        }


    }
}