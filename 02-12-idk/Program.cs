namespace _02_12_idk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allText = File.ReadAllText("input.txt");

            Console.WriteLine(allText);

            string[] allLines = File.ReadAllLines("input.txt");

            Console.WriteLine(  );

            foreach (string line in allLines)
            {


                string[] mezok = line.Split(';');
                // mezok[0] - város
                // mezok[1] - utca
                // mezok[2] - befizetett összeg
                // mezok[3] - tartozás

                int tartozas = Convert.ToInt32(mezok[3]);
                int befizetett = Convert.ToInt32(mezok[2]);
                bool csekk = false;
                if (mezok[4] == "IGEN")
                {
                    csekk = true;
                }

                if (tartozas > befizetett)
                {
                    Console.WriteLine("A tartozása nagyobb, mint a befizetett összeg");
                }
                Console.WriteLine(line);
            }
            {
                
            }
        }
    }
}
