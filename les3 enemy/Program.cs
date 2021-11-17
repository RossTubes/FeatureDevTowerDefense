using System;

namespace enemy
{
    class Program
    {


        string[] adres;
        public int hp { get; set; }        
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persoon persoon = new Persoon()
            {
                voornaam = "Jordan",
                achternaam = "Ross"
            };
           // int = i + 1;


        }

    }
    public class Persoon
    {
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public Persoon(string vn, string an)
        {
            voornaam = vn;
            achternaam = an;
        }
        public Persoon()
        {

        }
    }
}