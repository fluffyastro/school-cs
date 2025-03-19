namespace _03_19_hegyek_dolgozat
{


    internal class Program
    {
        static List<Hegy> Hegygek = new();

        static void feladat1()
        {
            Console.WriteLine("1. feladat: fájlok beolvasása");
        }
        static void feladat2()
        {
            Console.WriteLine("2. feladat: osztály létrehozása");
        }
        static void feladat3()
        {
            Console.WriteLine("3. feladat: lista feltöltése adatokkal");
        }
        static void feladat4()
        {
            int hegyekSzama = Hegygek.Count;
            Console.WriteLine($"4. feladat: Összesen {hegyekSzama} hegy található a .txt file-ban.");
        }
        static void feladat5()
        {
            int max = 0;

            foreach (Hegy item in Hegygek)
            {
                if (item.magassag > max)
                {
                    max = item.magassag;
                }
            }
            Console.WriteLine($"5. feladat: A legmagasabb hegy {max} méter magas.");
        }

        static void feladat6()
        {
            foreach (Hegy item in Hegygek)
            {
                if (item.magassag < 2000 &&  item.magassag > 1000)
                {
                    Console.WriteLine($"{item.nev}");
                }
            }
        }
        static void feladat7()
        {
            foreach (Hegy item in Hegygek)
            {
                if (item.nev.Contains("Mount"))
                {
                    Console.WriteLine($"Ez a hegy 'Mount'-tal kezdődik, neve {item.nev}, és magassága {item.magassag}");
                }
            }
        }

        static void Main(string[] args)
        {
            // 1. feladat
            string[] sorok = File.ReadAllLines("hegyek.txt");
            for (int i = 0; i < sorok.Length; i++)
            {
                string s = sorok[i];

                feladat1();
                feladat2();
                feladat3();
                feladat4();
                feladat5();
                feladat6();
            }
        }
    }
    class Hegy
    {
        public string nev { get; set; }
        public int magassag { get; set; }

        public Hegy(string sor)
        {
            string[] x = sor.Split('-');

            this.nev = x[0];
            this.magassag = int.Parse(x[1]);

        }
    }
}
