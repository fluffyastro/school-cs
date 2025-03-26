using System.Runtime.CompilerServices;

namespace _03_26_Dobozok
{
    internal class Program
    {

        static List<Doboz> dobozok = new List<Doboz>();
        static void feladat3()
        {
            Doboz elso_doboz = new Doboz(100, 50, 40);
            Console.WriteLine("3. feladat: ");
            Console.WriteLine($"\t{elso_doboz.terfogat}");
            Console.WriteLine($"\t{elso_doboz.felszin}");
        }

        static void feladat6()
        {
            Random random1 = new Random();
            for (int i = 0; i < 50; i++)
            {
                dobozok.Add(new Doboz(random1.Next(10, 100),random1.Next(10, 100),random1.Next(10, 100)));
            }
            
            //debug
            /*
            foreach(Doboz doboz in dobozok)
            {
                Console.WriteLine($"doboz xd: {doboz.szelesseg},{doboz.magassag},{doboz.hosszusag},{doboz.terfogat},{doboz.felszin}");
            }
            */
        }
        static void feladat7()
        {
            int osszes = 0;
            foreach (Doboz doboz in dobozok)
            {
                osszes += doboz.terfogat;
            }
            int atlag = osszes / dobozok.Count;
            Console.WriteLine($"7. feladat: Az átlagos térfogat: {atlag}");
        }

        static void feladat8()
        {
            for (int i = 0;i < ;i++)
        }
        static void Main(string[] args)
        {
            feladat3();
            feladat6();
            feladat7();
            Console.WriteLine("fejbelovom magam");
        }
    }
    class Doboz
    {
        public int hosszusag { get; set; }
        public int szelesseg { get; set; }
        public int magassag { get; set; }
        public int terfogat { get; set; }
        public int felszin { get; set; }

        public Doboz(int szelesseg, int magassag, int hosszusag)
        {
            this.hosszusag = hosszusag;
            this.szelesseg = szelesseg;
            this.magassag = magassag;

            this.terfogat = hosszusag * szelesseg * magassag;
            this.felszin = 2 * (hosszusag * szelesseg + hosszusag * magassag + szelesseg * magassag);
        }
    }
}

