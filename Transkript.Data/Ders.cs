namespace Transkript.Data
{
    public class Ders
    {
        public string Kodu { get; set; } = ""; // HUK101
        public string Adi { get; set; } = ""; // Hukuk Felsefesi
        public double Kredi { get; set; } = 0; // 2.5

        public override string ToString()
        {
            return $"{Adi}";
        }
        
    }
}
