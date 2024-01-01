namespace Transkript.Data
{
    public class AtananDers
    {
        public Ogrenci Ogrenci { get; set; } = new();
        public string DersKodu => Ders.Kodu;
        public double DersKredi => Ders.Kredi;

        public Ders Ders { get; set; } = new();
        public Donem Donem { get; set; } = new();
        public HarfNotu HarfNotu { get; set; }
        public double Puan => PuanHesapla();

        public double PuanHesapla()
        {
            //öğrencinin aldığı dersin puanını hesapla
            return Ders.Kredi * ((int)HarfNotu / 10);
        }
    }
}
