namespace ConsoleApp1
{
    public class Produkt
    {
        public string Namn { get; set; }

        public int Pris { get; set; }

        public Produkt(string namn, int pris)
        {
            Namn = namn;
            Pris = pris;
        }
    }
}
