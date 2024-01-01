namespace Transkript.Data
{
    public class Ogrenci
    {
        public decimal Numara { get; set; } = 0;
        public string Ad { get; set; } = "";
        public string Soyad { get; set; } = "";

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }

}
