namespace _02_26_Alonso
{
    internal class Program
    {

        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static void Feladat5()
        {
            Console.WriteLine($"5. feladat: {versenyzok.Count}");
        }

        static void Feladat6()
        {
            foreach (Versenyzo item in versenyzok)
            {
                if (item.Kod == "ALO")
                {
                    Console.WriteLine($"6. feladat: {item.Nev}");
                }
            }
        }

        static void Feladat7()
        {
            Console.WriteLine($"7. feladat: ");
            foreach (Versenyzo item in versenyzok)
            {
                if (item.Datam.Substring(5,5) == "01.01")
                {
                    Console.WriteLine($"\t {item.Nev} ({item.Datam})");
                }
            }
        }

        static void Feladat8() { 
            string rovidites = "";
            do
            {
                Console.WriteLine("8. feladat: Kérek egy rövidítést!")
                rovidites = Console.ReadLine();

                Console.WriteLine("9. feladat")
                foreach (Versenyzo item in versenyzok)
                {
                    if ( (item.Kod == rovidites) && (rovidites != "") )
                    {
                        Console.WriteLine($"\t Név: \t {item.Nev}");
                        Console.WriteLine($"\t Nemzetiség: \t\t {item.Nemzetiseg}");
                        Console.WriteLine($"\t Születési dátum: \t\t {item.Datam}");
                    }
                }

            } while (rovidites != "");
        }

        static void Main(string[] args)
        {
            string[] adatbazis = File.ReadAllLines("versenyzok.csv");

            for (int i = 1; i < adatbazis.Length; i++)
            {
                string[] mezok = adatbazis[i].Split(';');

                Versenyzo v1 = new Versenyzo(mezok[0], mezok[1], mezok[2], mezok[3]);
                versenyzok.Add(v1);
            }
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Console.ReadKey();
        }
    }



    class Versenyzo
    {

        public Versenyzo(string nev, string datam, string nemzetiseg, string kod)
        {
            Nev = nev;
            Datam = datam;
            Nemzetiseg = nemzetiseg;
            Kod = kod;
        }

        public string Nev { get; set; }
        public string Datam { get; set; }
        public string Nemzetiseg { get; set; }
        public string Kod { get; set; }

    }
}