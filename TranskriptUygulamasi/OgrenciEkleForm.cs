using Transkript.Data;

namespace TranskriptUygulamasi
{
    public partial class OgrenciEkleForm : Form
    {
        public OgrenciEkleForm()
        {
            InitializeComponent();
            Guncelle();

        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            // Ogrenci ekleme işlemi yapılacak.
            Ogrenci ogrenci = new();

            string ogrenciAdi = txtOgrenciAdi.Text.Trim();
            string ogrenciSoyadi = txtOgrenciSoyadi.Text.Trim();
            decimal ogrenciNumarasi = -1;

            // gerekli alanlar boş olamaz.
            if (ogrenciAdi.Length == 0 || ogrenciSoyadi.Length == 0)
            {
                UyariGoster("Gerekli alanlar boş olamaz.");
                return;
            }

            // öğrenci numarası sayısal olmalı.
            try
            {
                ogrenciNumarasi = Convert.ToDecimal(txtOgrenciNumarasi.Text.Trim());
            }
            catch (FormatException)
            {

                UyariGoster("Öğrenci numarasında sadece sayısal değer kullanınız.");
                return;
            }

            // öğrenci numarası unique. daha önce eklenmişse hata ver.
            if (Database.ogrenciler.Any(Ogrenci => Ogrenci.Numara == ogrenciNumarasi))
            {
                UyariGoster("Bu öğrenci numarası daha önce eklenmiş.");
                return;
            }

            // öğrenci nesnesini doldur.
            ogrenci.Ad = ogrenciAdi;
            ogrenci.Soyad = ogrenciSoyadi;
            ogrenci.Numara = ogrenciNumarasi;
            // öğrenci nesnesini db ekle.
            Database.ogrenciler.Add(ogrenci);

            Sifirla();
            Guncelle();

            txtOgrenciNumarasi.Focus();
        }

        private void Sifirla()
        {
            txtOgrenciAdi.Text = "";
            txtOgrenciSoyadi.Text = "";
            txtOgrenciNumarasi.Text = "";
        }

        private void Guncelle()
        {
            dgvOgrenciler.DataSource = null;
            if (Database.ogrenciler.Count > 0)
                dgvOgrenciler.DataSource = Database.ogrenciler;
            dgvOgrenciler.AutoGenerateColumns = false;
        }

        void UyariGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnOgrenciDuzenle_Click(object sender, EventArgs e)
        {
            // seçili öğrenci var mı?
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                UyariGoster("Düzenlemek için öğrenci seçiniz.");
                return;
            }

            // seçili satırı bulalım
            int seciliSatir = dgvOgrenciler.SelectedRows[0].Index;
            // textboxlardan verileri alalım
            string ogrenciAdi = txtOgrenciAdi.Text.Trim();
            string ogrenciSoyadi = txtOgrenciSoyadi.Text.Trim();
            decimal ogrenciNumarasi = -1;

            // gerekli alanlar boş olamaz.
            if (ogrenciAdi.Length == 0 || ogrenciSoyadi.Length == 0)
            {
                UyariGoster("Gerekli alanlar boş olamaz.");
                return;
            }

            // öğrenci numarası sayısal olmalı.
            try
            {
                ogrenciNumarasi = Convert.ToDecimal(txtOgrenciNumarasi.Text.Trim());
            }
            catch (FormatException)
            {

                UyariGoster("Öğrenci numarasında sadece sayısal değer kullanınız.");
                return;
            }

            // öğrenci numarası unique. daha önce eklenmişse hata ver.

            if (Database.ogrenciler.Any(Ogrenci => Ogrenci.Numara == ogrenciNumarasi && Ogrenci.Numara != Database.ogrenciler[seciliSatir].Numara))
            {
                UyariGoster("Bu öğrenci numarası daha önce eklenmiş.");
                return;
            }

            // öğrenci düzenle.
            Database.ogrenciler[seciliSatir].Ad = ogrenciAdi;
            Database.ogrenciler[seciliSatir].Soyad = ogrenciSoyadi;
            Database.ogrenciler[seciliSatir].Numara = ogrenciNumarasi;

            Sifirla();
            Guncelle();
        }

        private void dgvOgrenciler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // tıklayınca sol taraftaki kontrollere getir
            if (dgvOgrenciler.SelectedRows.Count == 0) return;
            txtOgrenciNumarasi.Text = dgvOgrenciler.SelectedRows[0].Cells[0].Value.ToString();
            txtOgrenciAdi.Text = dgvOgrenciler.SelectedRows[0].Cells[1].Value.ToString();
            txtOgrenciSoyadi.Text = dgvOgrenciler.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            // eğer seçili satır yoksa
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                UyariGoster("Silmek için öğrenci seçiniz.");
                return;
            }

            // silmek için onay al
            DialogResult sonuc = MessageBox.Show("Seçili öğrenciyi silmek istediğinize emin misiniz?", "Öğrenci Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // hayırsa iptal et
            if (sonuc == DialogResult.No)
            {
                return;
            }

            // varsa seçili satırı al
            int seciliSatir = dgvOgrenciler.SelectedRows[0].Index;

            // sil
            Database.ogrenciler.RemoveAt(seciliSatir);

            // güncelle
            Guncelle();

            // sıfırla
            Sifirla();
        }
    }
}
