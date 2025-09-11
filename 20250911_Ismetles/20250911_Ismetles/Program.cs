using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _20250911_Ismetles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Console.WriteLine("1. FELADAT\n");
            Console.WriteLine("Írj be 5 számot!");
            int[] szamok = new int[5];
            int osszeg = 0;

            for(int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Add meg a {0} szamot: ", i + 1);
                szamok[i] = Convert.ToInt32(Console.ReadLine());
                osszeg += szamok[i];
            }

            Console.WriteLine("Számok összege: {0}", osszeg);
            Console.WriteLine("\n\n\n");

            //2. feladat
            Console.WriteLine("2. FELADAT\n");
            Console.WriteLine("A program 10 darab számot fog random generálni.");
            Random rnd = new Random();
            int[] szamok2 = new int[10];

            for (int i = 0; i < szamok2.Length; i++)
            {
                szamok2[i] = rnd.Next(0, 101);
                Console.WriteLine(szamok2[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Legnagyobb: " + szamok2.Max());
            Console.WriteLine("Legkisebb: " + szamok2.Min());
            Console.WriteLine("\n\n\n");

            //3. feladat
            Console.WriteLine("3. FELADAT\n");

            Console.WriteLine("Írj be bármennyi számot!");
            List<int> szamok3 = new List<int>();
            while (true) {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0) break;
                szamok3.Add(input);
            }

            Console.WriteLine("{0} számot adott meg.", szamok3.Count);
            Console.WriteLine("\n\n\n");

            //4. feladat
            Console.WriteLine("4. FELADAT\n");

            Console.WriteLine("Írjon be egy véletlenszerű számot: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; input2 +1 > j; j++) 
            {
                for(int h = 0; h < j; h++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}
