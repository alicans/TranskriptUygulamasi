using System.Net;
using Transkript.Data;

namespace TranskriptUygulamasi
{
    public partial class DersEkleForm : Form
    {
        public DersEkleForm()
        {
            InitializeComponent();
            Guncelle();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            Ders ders = new();
            // ders adı, ders kodu, ders kredi bilgilerini alalım
            string dersAdi = txtDersAdi.Text.Trim();
            string dersKodu = txtDersKodu.Text.Trim();
            double dersKredi = (double)nudDersKredi.Value;

            // gerekli alanlar boş mu kontrol edelim
            if (dersAdi.Length == 0 || dersKodu.Length == 0)
            {
                UyariGoster("Gerekli alanlar boş olamaz.");
                return;
            }

            // ders kodu unique.
            if (Database.dersler.Any(Ders => Ders.Kodu == dersKodu))
            {
                UyariGoster("Bu ders kodu daha önce eklenmiş.");
                return;
            }
            // dersi ekle
            ders.Adi = dersAdi;
            ders.Kodu = dersKodu;
            ders.Kredi = dersKredi;

            Database.dersler.Add(ders);

            Sifirla();
            Guncelle();
            // ders eklendikten sonra ders kodu alanına focus
            txtDersKodu.Focus();
        }

        private void Sifirla()
        {
            txtDersAdi.Text = "";
            txtDersKodu.Text = "";
            nudDersKredi.Value = 0.5m;
        }

        private void Guncelle()
        {
            dgvDersler.DataSource = null;
            if (Database.dersler.Count > 0)
                dgvDersler.DataSource = Database.dersler;
            dgvDersler.AutoGenerateColumns = false;
        }

        void UyariGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // seçili ders var mı kontrol edelim
            if (dgvDersler.SelectedRows.Count == 0)
            {
                UyariGoster("Düzenlemek için bir ders seçiniz.");
                return;
            }

            // seçili satırı bulalım
            int seciliSatir = dgvDersler.SelectedRows[0].Index;

            string dersAdi = txtDersAdi.Text.Trim();
            string dersKodu = txtDersKodu.Text.Trim();
            double dersKredi = (double)nudDersKredi.Value;

            if (dersAdi.Length == 0 || dersKodu.Length == 0)
            {
                UyariGoster("Gerekli alanlar boş olamaz.");
                return;
            }

            // ders kodu unique. (seçili satırın dışında olmamalı)
            if (Database.dersler.Any(Ders => Ders.Kodu == dersKodu && Ders.Kodu != Database.dersler[seciliSatir].Kodu))
            {
                UyariGoster("Bu ders kodu daha önce eklenmiş.");
                return;
            }

            // seçili satırı güncelle
            Database.dersler[seciliSatir].Adi = dersAdi;
            Database.dersler[seciliSatir].Kodu = dersKodu;
            Database.dersler[seciliSatir].Kredi = dersKredi;


            Sifirla();
            Guncelle();

        }

        private void dgvDersler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // tıklayınca sol taraftaki kontrollere getir
            if (dgvDersler.SelectedRows.Count == 0) return;
            txtDersKodu.Text = dgvDersler.SelectedRows[0].Cells[0].Value.ToString();
            txtDersAdi.Text = dgvDersler.SelectedRows[0].Cells[1].Value.ToString();
            nudDersKredi.Value = (decimal)Convert.ToDouble(dgvDersler.SelectedRows[0].Cells[2].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // eğer seçili satır yoksa
            if (dgvDersler.SelectedRows.Count == 0)
            {
                UyariGoster("Silmek için bir atama seçiniz.");
                return;
            }

            // silmek için onay al
            DialogResult sonuc = MessageBox.Show("Seçili dersi silmek istediğinize emin misiniz?", "Ders Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // hayırsa iptal et
            if (sonuc == DialogResult.No) return;


            // varsa seçili satırı al
            int seciliSatir = dgvDersler.SelectedRows[0].Index;

            // sil
            Database.dersler.RemoveAt(seciliSatir);

            // güncelle
            Guncelle();

            // sıfırla
            Sifirla();
        }
    }
}
