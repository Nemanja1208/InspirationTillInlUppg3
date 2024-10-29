using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class MinLillaDB
    {
        [JsonPropertyName("products")]
        public List<Produkt> AllaProdukterFrånDB { get; set; }

        [JsonPropertyName("studenter")]
        public List<Student> AllStudenterFrånDB { get; set; }

        [JsonPropertyName("anställda")]
        public List<Anställd> AllaAnställdaFrånDB { get; set; }
    }
}
