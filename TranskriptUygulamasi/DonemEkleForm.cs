using Transkript.Data;

namespace TranskriptUygulamasi
{
    public partial class DonemEkleForm : Form
    {
        public DonemEkleForm()
        {
            InitializeComponent();
            Guncelle();
        }

        private void btnDonemEkle_Click(object sender, EventArgs e)
        {
            Donem donem = new();

            string donemAdi = txtDonemAdi.Text.Trim();
            string donemNo = txtDonemNo.Text.Trim();
            // boş alan kontrolü
            if (donemAdi.Length == 0 || donemNo.Length == 0)
            {
                UyariGoster("Gerekli alanlar boş olamaz.");
                return;
            }

            // Dönem No unique.
            if (Database.donemler.Any(dnm => dnm.No == donemNo))
            {
                UyariGoster("Bu Dönem No'su daha önce eklenmiş.");
                return;
            }

            donem.No = donemNo;
            donem.Ad = donemAdi;

            // dönemi database'e ekle
            Database.donemler.Add(donem);

            Sifirla();
            Guncelle();

            txtDonemNo.Focus();
        }

        private void Sifirla()
        {
            txtDonemAdi.Text = "";
            txtDonemNo.Text = "";
        }

        private void Guncelle()
        {
            dgvDonemler.DataSource = null;
            if (Database.donemler.Count > 0)
                dgvDonemler.DataSource = Database.donemler;
            dgvDonemler.AutoGenerateColumns = false;
        }

        void UyariGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDonemDuzenle_Click(object sender, EventArgs e)
        {
            // eğer seçili satır yoksa
            if (dgvDonemler.SelectedRows.Count == 0)
            {
                UyariGoster("Düzenlemek için bir dönem seçiniz.");
                return;
            }

            // varsa seçili satırı al
            int seciliSatir = dgvDonemler.SelectedRows[0].Index;

            // textboxlardan verileri al
            string donemAdi = txtDonemAdi.Text.Trim();
            string donemNo = txtDonemNo.Text.Trim();

            // kontrol
            if (donemAdi.Length == 0 || donemNo.Length == 0)
            {
                UyariGoster("Gerekli alanlar boş olamaz.");
                return;
            }

            // Dönem No unique. (seçili satırın dışında olmamalı) 

            if (Database.donemler.Any(dnm => dnm.No == donemNo && dnm.No != Database.donemler[seciliSatir].No))
            {
                UyariGoster("Bu Dönem No'su daha önce eklenmiş.");
                return;
            }

            // seçili satırı güncelle
            Database.donemler[seciliSatir].Ad = txtDonemAdi.Text.Trim();
            Database.donemler[seciliSatir].No = txtDonemNo.Text.Trim();

            // güncelle
            Guncelle();

            // sıfırla
            Sifirla();

        }

        private void dgvDonemler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDonemler.SelectedRows.Count == 0) return;
            txtDonemNo.Text = dgvDonemler.SelectedRows[0].Cells[0].Value.ToString();
            txtDonemAdi.Text = dgvDonemler.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnDonemSil_Click(object sender, EventArgs e)
        {
            // eğer seçili satır yoksa
            if (dgvDonemler.SelectedRows.Count == 0)
            {
                UyariGoster("Silmek için bir dönem seçiniz.");
                return;
            }

            // silmek için onay al
            DialogResult sonuc = MessageBox.Show("Seçili dönemi silmek istediğinize emin misiniz?", "Dönem Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // hayırsa iptal et
            if (sonuc == DialogResult.No) return;

            // varsa seçili satırı al
            int seciliSatir = dgvDonemler.SelectedRows[0].Index;

            // sil
            Database.donemler.RemoveAt(seciliSatir);

            // güncelle
            Guncelle();

            // sıfırla
            Sifirla();
        }
    }
}
