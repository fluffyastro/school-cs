namespace _03_12_Alaplapok_Megoldas
{
    internal class Program
    {

        static List<Alaplap> Alaplapok = new List<Alaplap>();


        static void feladat1()
        {
            int alaplapokSzama = Alaplapok.Count;
            Console.WriteLine($"1. feladat: Összesen {alaplapokSzama} db alaplap van.");
        }

        static void feladat2()
        {
            int szamlalo = 0;

            foreach (var item in Alaplapok)
            {
                if (item.gyarto == "ASUS")
                {
                    szamlalo++;
                }
            }

            Console.WriteLine($"2. feladat: Összesen {szamlalo} db ASUS alaplap van.");
        }
        static void feladat3() {
            foreach (Alaplap item in Alaplapok)
            {
                if (item.ar < 100000)
                {
                    Console.WriteLine($" {item.gyarto} {item.tipus} {item.ar}");
                }
            }
        }
        static void feladat4()
        {
            int max = 0;

            foreach (Alaplap item in Alaplapok)
            {
                if (item.ar > max)
                {
                    max = item.ar;
                }
            }
            Console.WriteLine($"4. feladat: A legdrágább alaplap ára: {max} Ft.");
        }
            static void Main(string[] args)
        {


            string[] sorok = File.ReadAllLines("alaplapok.txt");
            for (int i = 1; i < sorok.Length; i++)
            {
                string s = sorok[i];

                feladat1();
                feladat2();
                feladat3();
                feladat4();
            }
        }
    }

    class Alaplap
    {
        public string orszag { get; set; }
        public string gyarto { get; set; }
        public string tipus { get; set; }
        public int ar { get; set; }
        public int mennyiseg { get; set; }
        public double mutato { get; set; }



        public Alaplap(string sor)
        {
            string[] x = sor.Split(',');

            this.orszag = x[0];
            this.gyarto = x[1];
            this.tipus = x[2];
            this.ar = int.Parse(x[3]);
            this.mennyiseg = int.Parse(x[4]);
            this.mutato = double.Parse(x[5].Replace(    '.' ,   ','));



        }
    }
}
