﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] jegyek = { 5, 5, 3, 1, 4 };
            double atlag = (jegyek[0] + jegyek[1] + jegyek[2] + jegyek[3] + jegyek[4]) / 5;
            Console.WriteLine($"Az 5db szám átlaga: {atlag}");
            if (atlag > 4.5)
            {
                Console.WriteLine("Nagyon jó átlag!");
            }
            else if (atlag < 1.5) 
            {
                Console.WriteLine("Bukás!");
            }
            
            
            for (int i = 10; i <=120; i+= 2) 
            {
                Console.Write($"{i},");
            }
            

            Console.WriteLine();

            string elso_kod = Convert.ToString(66);
            string masodik_kod = Convert.ToString(97);
            string harmadik_kod = Convert.ToString(98);
            string negyedik_kod = Convert.ToString(97); //Itt igazából lehetne azzal rövidíteni, hogy a második kódot használjuk, hisz így feleslegesen csinálunk két ugyanolyan értékű változót.
            Console.WriteLine($"{elso_kod} {masodik_kod} {harmadik_kod} {negyedik_kod}");

            Console.ReadLine();
        }
    }
}