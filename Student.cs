namespace ConsoleApp1
{
    public class Student
    {
        public string Namn { get; set; }

        public int Betyg { get; set; }

        public Student(string namn, int betyg)
        {
            Namn = namn;
            Betyg = betyg;
        }
    }
}
