using System.Text.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖVNING 1
            //Givet en lista med produkter(med egenskaperna Namn och Pris), skriv en LINQ - fråga
            //som filtrerar produkter med ett pris över 50 och sorterar dem i fallande ordning efter pris.

            string dataJSONfilPath = "data.json";
            string allaDataSomJSONType = File.ReadAllText(dataJSONfilPath);

            MinLillaDB minLillaDB = JsonSerializer.Deserialize<MinLillaDB>(allaDataSomJSONType)!;

            List<Produkt> allaProdukter = minLillaDB.AllaProdukterFrånDB;

            List<Produkt> allaProduktMedPrisÖver50 = allaProdukter.Where(produkt => produkt.Pris > 50).ToList();

            List<Produkt> allaProduktMedPrisÖver50IFallandeOrdning = allaProduktMedPrisÖver50.OrderByDescending(produkt => produkt.Pris).ToList();

            allaProduktMedPrisÖver50IFallandeOrdning.ForEach(produkt => Console.WriteLine(produkt.Namn));

            allaProdukter.Add(new Produkt("Mic", 2000));

            // ÖVNING 2
            //Givet en lista med studenter med egenskaperna Namn och Betyg, gruppera dem
            //enligt betyg och räkna hur många studenter som finns i varje betyg.
            List<Student> allaStudenter = minLillaDB.AllStudenterFrånDB;

            var grupperadeStudenterEnligtBetyg = allaStudenter.GroupBy(student => student.Betyg).Select(group => new { Betyg = group.Key, Count = group.Count() }).ToList();

            grupperadeStudenterEnligtBetyg.ForEach(group => Console.WriteLine($"Betyg: {group.Betyg} / antal studenter : {group.Count}"));

            allaStudenter.Add(new Student("Balen", 10));

            // ÖVNING 3
            //Givet en lista med anställda med egenskaperna Namn och Lön, skapa en ny lista som
            //innehåller namnen och ett beräknat värde som visar lönen ökad med 10 %.
            List<Anställd> allaAnställda = minLillaDB.AllaAnställdaFrånDB;

            allaAnställda.ForEach(anställd => anställd.Lön *= 1.1m);


            // ÖVNING 4
            //Givet en lista med heltal, skriv en LINQ - fråga som beräknar summan, medelvärdet,
            //det maximala och det minimala värdet.


            // UPDATERA DB - JSON fil som sista steg
            string updateradeLillaDB = JsonSerializer.Serialize(minLillaDB, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(dataJSONfilPath, updateradeLillaDB);

            Console.ReadLine();

        }
    }
}
