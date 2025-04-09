namespace ListaFeldolgozo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("./adatok/db2.csv");
            int pirosSzamlalo = 0;
            int ip127szamlalo = 0;
            int decSzamlalo = 0;

            foreach (string sor in sorok)
            {
                string[] mezok = sor.Split(',');
                string ip = mezok[2];
                string datum = mezok[4];

                if (ip.Contains("127"))
                {
                    ip127szamlalo++;
                    File.AppendAllText("ip.txt", sor + "\r\n");
                }
                string szin = mezok[3];
                
                if (szin == "Red")
                {
                    pirosSzamlalo++;
                }

                if (datum.StartsWith("12/"))
                {
                    File.AppendAllText("december.txt", sor + "\r\n");
                }
            }

            Console.WriteLine($"127-es byte-ot tartalmazó IP címből {ip127szamlalo} darab van.");
            Console.WriteLine($"A piros színből {pirosSzamlalo} darab van.");

            






        }
    }
}
