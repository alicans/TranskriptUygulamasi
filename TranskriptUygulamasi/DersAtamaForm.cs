using System.Security.Policy;
using Transkript.Data;

namespace TranskriptUygulamasi
{
    public partial class DersAtamaForm : Form
    {
        public DersAtamaForm()
        {
            InitializeComponent();
            Guncelle();

        }

        private void DersAtamaForm_Load(object sender, EventArgs e)
        {
            cmbOgrenciler.DataSource = Database.ogrenciler;
            cmbDersAdlari.DataSource = Database.dersler;
            cmbDonemler.DataSource = Database.donemler;

            // harf notlarını sıralayalım.
            List<HarfNotu> notlar = new List<HarfNotu>();
            foreach (var not in Enum.GetNames(typeof(HarfNotu)))
            {
                notlar.Add((HarfNotu)Enum.Parse(typeof(HarfNotu), not));
            }
            //üstteki kodu tek satırda yazmak istersek
            List<HarfNotu> notlare = Enum.GetValues(typeof(HarfNotu)).Cast<HarfNotu>().ToList();
            cmbHarfNotlari.DataSource = notlar.OrderByDescending(x => x).ToList();



        }

        private void btnAtamaYap_Click(object sender, EventArgs e)
        {
            // Öğrenci seçilmediyse uyarı ver
            if (cmbOgrenciler.SelectedIndex == -1)
            {
                UyariGoster("Lütfen Öğrenci seçiniz!");
                return;
            }

            // Ders seçilmediyse uyarı ver
            if (cmbDersAdlari.SelectedIndex == -1)
            {
                UyariGoster("Lütfen Ders seçiniz!");
                return;
            }

            // Dönem seçilmediyse uyarı ver
            if (cmbDonemler.SelectedIndex == -1)
            {
                UyariGoster("Lütfen Dönem seçiniz!");
                return;
            }

            // Harf notu seçilmediyse uyarı ver
            if (cmbHarfNotlari.SelectedIndex == -1)
            {
                UyariGoster("Lütfen Harf Notu seçiniz!");
                return;
            }

            // Öğrenci, ders ve dönem bilgilerini al
            Ogrenci ogrenci = (Ogrenci)cmbOgrenciler.SelectedItem;
            Ders ders = (Ders)cmbDersAdlari.SelectedItem;
            Donem donem = (Donem)cmbDonemler.SelectedItem;
            HarfNotu harfNotu = (HarfNotu)cmbHarfNotlari.SelectedItem;

            // AtananDers nesnesini oluştur
            AtananDers atananDers = new();

            atananDers.Ogrenci = ogrenci;
            atananDers.Ders = ders;
            atananDers.Donem = donem;
            atananDers.HarfNotu = harfNotu;

            // Öğrenciye daha önce bu ders verilmiş mi?
            if (Database.atananDersler.Any(atanan => atanan.Ogrenci == ogrenci && atanan.Ders == ders && atanan.Donem == donem))
            {
                UyariGoster("Bu öğrenciye seçilen dönem için daha önce bu ders verilmiş.");
                return;
            }

            // Verilmemişse AtananDers nesnesini Database'e ekle
            Database.atananDersler.Add(atananDers);

            // güncelle
            Guncelle();



        }

        void UyariGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void BilgiGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Guncelle()
        {

            dgvAtanan.DataSource = null;
            if (Database.atananDersler.Count > 0)
                dgvAtanan.DataSource = Database.atananDersler;
            dgvAtanan.AutoGenerateColumns = false;
        }


        private void cmbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Guncelle();
        }

        private void dgvAtanan_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvAtanan.SelectedRows.Count == 0) return;
            // Seçili satırı al
            int seciliSatir = dgvAtanan.SelectedRows[0].Index;

            // Seçili satırdaki AtananDers nesnesini al
            AtananDers atananDers = Database.atananDersler[seciliSatir];

            // AtananDers nesnesinin özelliklerini ilgili ComboBox'lara aktar
            cmbOgrenciler.SelectedItem = atananDers.Ogrenci;
            cmbDersAdlari.SelectedItem = atananDers.Ders;
            cmbDonemler.SelectedItem = atananDers.Donem;
            cmbHarfNotlari.SelectedItem = atananDers.HarfNotu;


        }

        private void btnAtamaDuzenle_Click(object sender, EventArgs e)
        {
            // seçili satırı al
            int seciliSatir = dgvAtanan.SelectedRows[0].Index;

            // seçili satırdaki AtananDers nesnesini al
            AtananDers atananDers = Database.atananDersler[seciliSatir];
            List<AtananDers> atananDersinListesi = new List<AtananDers>();
            atananDersinListesi.Add(atananDers);

            // Öğrenci, ders ve dönem bilgilerini al
            Ogrenci ogrenci = (Ogrenci)cmbOgrenciler.SelectedItem;
            Ders ders = (Ders)cmbDersAdlari.SelectedItem;
            Donem donem = (Donem)cmbDonemler.SelectedItem;
            HarfNotu harfNotu = (HarfNotu)cmbHarfNotlari.SelectedItem;

            // Öğrenciye daha önce bu ders verilmiş mi?
            if (Database.atananDersler.Except(atananDersinListesi).Any(atanan => atanan.Ogrenci == ogrenci && atanan.Ders == ders && atanan.Donem == donem))
            {
                UyariGoster("Bu öğrenciye seçilen dönem için daha önce bu ders verilmiş.");
                return;
            }

            // seçili satırdaki AtananDers nesnesinin özelliklerini güncelle
            atananDers.Ogrenci = (Ogrenci)cmbOgrenciler.SelectedItem;
            atananDers.Ders = (Ders)cmbDersAdlari.SelectedItem;
            atananDers.Donem = (Donem)cmbDonemler.SelectedItem;
            atananDers.HarfNotu = (HarfNotu)cmbHarfNotlari.SelectedItem;



            // güncelle
            Guncelle();

            // seçili satırı tekrar seçili hale getir
            dgvAtanan.Rows[seciliSatir].Selected = true;
        }

        private void btnAtamaSil_Click(object sender, EventArgs e)
        {
            // eğer seçili satır yoksa
            if (dgvAtanan.SelectedRows.Count == 0)
            {
                UyariGoster("Silmek için bir ders seçiniz.");
                return;
            }

            // silmek için onay al
            DialogResult sonuc = MessageBox.Show("Seçili atamayı silmek istediğinize emin misiniz?", "Atama Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // hayırsa iptal et
            if (sonuc == DialogResult.No) return;

            // seçili satırı al
            int seciliSatir = dgvAtanan.SelectedRows[0].Index;

            // seçili satırdaki AtananDers nesnesini al
            AtananDers atananDers = Database.atananDersler[seciliSatir];

            // AtananDers nesnesini Database'den sil
            Database.atananDersler.Remove(atananDers);

            // güncelle
            Guncelle();

        }
    }
}
