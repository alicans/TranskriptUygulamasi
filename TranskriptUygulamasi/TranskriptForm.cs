using Transkript.Data;

namespace TranskriptUygulamasi
{
    public partial class TranskriptForm : Form
    {
        public TranskriptForm()
        {
            InitializeComponent();
            cmbOgrenciSec.DataSource = Database.ogrenciler;
            cmbDonemSec.DataSource = Database.donemler;
            lblUyari.Text = "Lütfen yukarıdan bir öğrenci seçiniz.";
        }

        private void btnTranskriptGoster_Click(object sender, EventArgs e)
        {
            lblUyari.Text = "";
            lblUyari.Visible = false;

            // Öğrenci seçilmediyse uyarı ver
            if (cmbOgrenciSec.SelectedIndex == -1)
            {
                UyariGoster("Lütfen Öğrenci seçiniz!");
                return;
            }

            // Dönem seçilmediyse uyarı ver
            if (cmbDonemSec.SelectedIndex == -1)
            {
                UyariGoster("Lütfen Dönem seçiniz!");
                return;
            }

            // paneli görünür yap
            pnlTranskript.Visible = true;

            // seçilen dönemi al
            Donem donem = (Donem)cmbDonemSec.SelectedItem;

            // labele dönem bilgisini yaz
            lblSecilenDonem.Text = donem.Ad;

            // Seçili öğrenci bilgilerini al
            Ogrenci secilenOgrenci = (Ogrenci)cmbOgrenciSec.SelectedItem;
            if (secilenOgrenci == null) { return; }

            // seçili dönem bilgilerini al
            Donem secilenDonem = (Donem)cmbDonemSec.SelectedItem;
            if (secilenDonem == null) { return; }

            // Öğrencinin aldığı dönem derslerini bul
            List<AtananDers> ogrencininDonemDersleri = new();

            ogrencininDonemDersleri = Database.atananDersler.Where(db =>

            db.Ogrenci.Numara == secilenOgrenci.Numara &&
            db.Donem.No == secilenDonem.No

            ).ToList();

            // öğrencinin tüm dönem derslerini bul
            List<AtananDers> ogrencininTumDersleri = new();
            ogrencininTumDersleri = Database.atananDersler.Where(db => db.Ogrenci.Numara == secilenOgrenci.Numara).ToList();


            if (ogrencininDonemDersleri.Count == 0)
            {
                pnlTranskript.Visible = false;
                lblUyari.Text = "Öğrencinin seçilen dönem aldığı ders bulunmamaktadır.";
                lblUyari.Visible = true;
                return;
            }



            // Öğrencinin aldığı dersleri datagridview'e aktar
            dgvTranskript.DataSource = ogrencininDonemDersleri.ToList();

            // Öğrencinin aldığı derslerin toplam kredisi
            double donemKredi = ogrencininDonemDersleri.Sum(x => x.Ders.Kredi);
            double toplamKredi = ogrencininTumDersleri.Sum(x => x.Ders.Kredi);

            // Öğrencinin aldığı derslerin toplam sayısı
            int toplamDonemDersSayisi = ogrencininDonemDersleri.Count;
            int toplamDersSayisi = ogrencininTumDersleri.Count;

            // Öğrencinin aldığı derslerin toplam notu
            double toplamDonemNot = ogrencininDonemDersleri.Sum(x => x.Puan);
            double toplamNot = ogrencininTumDersleri.Sum(x => x.Puan);

            // Öğrencinin dönem notu ortalaması
            double DNO = toplamDonemNot / donemKredi;
            double GNO = toplamNot / toplamKredi;

            lblDno.Text = DNO.ToString("0.00");
            lblGno.Text = GNO.ToString("0.00");

        }

        void UyariGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void BilgiGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TranskriptForm_Load(object sender, EventArgs e)
        {


        }
    }
}
