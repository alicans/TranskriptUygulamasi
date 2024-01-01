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
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Ahmet", Soyad = "Y�lmaz", Numara = 230301049 });
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Can", Soyad = "S�ylemez", Numara = 230301050 });
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Ece", Soyad = "Telk�v�ran", Numara = 230301051 });
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Ali", Soyad = "Kaya", Numara = 230301052 });
            Database.ogrenciler.Add(new Ogrenci() { Ad = "Kemal", Soyad = "Y�ld�r�m", Numara = 230301053 });

            Database.donemler.Add(new Donem() { Ad = "2019-2020 G�z D�nemi", No = "2019-1" });
            Database.donemler.Add(new Donem() { Ad = "2019-2020 Bahar D�nemi", No = "2019-2" });
            Database.donemler.Add(new Donem() { Ad = "2020-2021 G�z D�nemi", No = "2020-1" });
            Database.donemler.Add(new Donem() { Ad = "2020-2021 Bahar D�nemi", No = "2020-2" });
            Database.donemler.Add(new Donem() { Ad = "2021-2022 G�z D�nemi", No = "2021-1" });

            Database.dersler.Add(new Ders() { Adi = "Veri Yap�lar�", Kodu = "BLM201", Kredi = 2.5 });
            Database.dersler.Add(new Ders() { Adi = "Algoritma ve Programlama", Kodu = "BLM101", Kredi = 3.5 });
            Database.dersler.Add(new Ders() { Adi = "Nesne Tabanl� Programlama", Kodu = "BLM203", Kredi = 3 });
            Database.dersler.Add(new Ders() { Adi = "Bilgisayar Organizasyonu", Kodu = "BLM102", Kredi = 4 });
            Database.dersler.Add(new Ders() { Adi = "��letim Sistemleri", Kodu = "BLM202", Kredi = 5 });

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

            // bu ana formun �ocuklar� i�erisinde gezelim
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true;
                    form.Show(); //istenenin a��lmas�
                }
                else
                    form.Close(); //a��k olan varsa kapat�lmas�
            }
            if (!durum)
            {
                secilenForm.MdiParent = this;
                secilenForm.Show();
            }
        }


    }
}