namespace szovegFuggvenyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string demoSzoveg = "  Ez egy szöveg, aminem több része is van.  ";
            
            // 1. hossz
            int hossz = demoSzoveg.Length;
            Console.WriteLine($"A demo szöveg hossza: {hossz}");


            // 2. kisbetűre konvertál

            string kisBetusSzoveg = demoSzoveg.ToLower();

            Console.WriteLine($"A demo szöveg kisbetűs változata: {kisBetusSzoveg}");

            // 3. nagybetűre konvertál

            string nagyBetusSzoveg = demoSzoveg.ToUpper();
            Console.WriteLine($"A demo szöveg nagybetűs változata: {nagyBetusSzoveg}");

            // 4. trim

            string megtisztitottSzoveg = demoSzoveg.Trim();
            Console.WriteLine($"A demo szöveg tisztított változata: {megtisztitottSzoveg}");

            // 5. kivágás a szövegből

            string szovegEleje = demoSzoveg.Substring(0, 8);
            string szovegKozepe = demoSzoveg.Substring(9, 6);
            Console.WriteLine($"A demo szöveg eleje: !{szovegEleje}!");
            Console.WriteLine($"A demo szöveg közepe: !{szovegKozepe}!");

            string elsoFele = demoSzoveg.Substring(0, hossz / 2);
            Console.WriteLine($"A demo szöveg fele: {elsoFele}");

            string masikFele = demoSzoveg.Substring(hossz / 2);
            Console.WriteLine($"A demo szöveg másik fele: {masikFele}");

            // 6. csere

            string szokozNelkul = demoSzoveg.Replace(" ", "_");
            Console.WriteLine($"A demo szöveg szóköz változata: !{szokozNelkul}!");

            string felhasznaloNeve = " Kovács János    ";
            felhasznaloNeve = felhasznaloNeve.Trim();
            felhasznaloNeve = felhasznaloNeve.Replace(" ", "_");
            felhasznaloNeve = felhasznaloNeve.Replace('á', 'a');
            felhasznaloNeve = felhasznaloNeve.Replace('é', 'e');
            felhasznaloNeve = felhasznaloNeve.Replace('í', 'i');
            felhasznaloNeve = felhasznaloNeve.Replace('ó', 'o');
            felhasznaloNeve = felhasznaloNeve.Replace('ö', 'o');
            felhasznaloNeve = felhasznaloNeve.Replace('ő', 'o');
            felhasznaloNeve = felhasznaloNeve.Replace('ú', 'u');
            felhasznaloNeve = felhasznaloNeve.Replace('ü', 'u');
            felhasznaloNeve = felhasznaloNeve.Replace('ű', 'u');
            felhasznaloNeve = felhasznaloNeve.Replace('0', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('1', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('2', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('3', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('4', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('5', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('6', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('7', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('8', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('9', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('.', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace(',', ' ');
            felhasznaloNeve = felhasznaloNeve.Replace('-', ' ');
            felhasznaloNeve = felhasznaloNeve.Trim();
            felhasznaloNeve = felhasznaloNeve.ToLower();
            Console.WriteLine($"Felhasználó neve tsztítva: {felhasznaloNeve}");

            // 7. Tartalmazza-e a megadott szöveget

            string emailCim = "kovacs.janos@gmail.com";

            bool hiba1 = emailCim.Contains(" ");
            bool hiba2 = ! emailCim.Contains("@");

            Console.WriteLine("Az e-mail cím:");
            if ( hiba1 || hiba2 )
            {
                Console.WriteLine(" nem érvényes");
            }
            else
            {
                Console.Write(" érvényes");
            }

            // 8. StartsWith (string value) --> tartalmazza az elején a szöveget

            // 9. EndsWith -||-


            // 10. Megadott szöveg helyét, indexét adja meg

            string bemenetiSzoveg = "abcd123xyz123 ! ";

            int i = bemenetiSzoveg.IndexOf("1");
            Console.WriteLine($"A szövegben az első index az 1-es karakternek: {i}");

            // 11. darabolás

            string szinek = "piros,kék,híres sárga,zöld,lila,مرحباً، أوزة, Γεια σου χήνα, asalam aleykum, היי אווז, rózsaszín, neonzöld, meg ilyenek";

            string[] szinekTomb = szinek.Split(new char[] { ',' });

            foreach (string item in szinekTomb)
            {
                Console.WriteLine(item);
            }

            // 12. beszúrás megadott index helyre

            string s1 = "Ebbe a szövegbe kel beszúrni valamit.";
            string s2 = "valami";

            int holVan = s1.IndexOf("kell");
            string s3 = s1.Insert(holVan, s2);

            Console.WriteLine(s3);

            // 13.

            Console.WriteLine(s3.Remove(14, 5));

            // 14.

            string szovegA = s3.Remove(14, 5);
            string szovegB = s3.Remove(14, 5);


            // 17.

            string[] words = { "apple", "banana", "cherry", "היי אווז" };
            string result = string.Join("-", words);

            Console.WriteLine(result);
        }
    }
}
