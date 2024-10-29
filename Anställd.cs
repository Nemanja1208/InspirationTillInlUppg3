namespace ConsoleApp1
{
    public class Anställd
    {
        public string Namn { get; set; }

        public decimal Lön { get; set; }

        public Anställd(string namn, decimal lön)
        {
            Namn = namn;
            Lön = lön;
        }

    }
}
