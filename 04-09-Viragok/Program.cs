namespace _04_09_Viragok
{
    
    class Virag
    {
        public string LatinNev   { get; set; }
        public string MagyarNev { get; set; }
    }

    internal class Program
    {
        static List<Virag> viragok = new List<Virag>();
        static void Main(string[] args)
        {
            try
            {
                string[] viragok_tomb = File.ReadAllLines("viragok.txt");
                foreach (string item in viragok_tomb)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("A fájl nem nyitható meg!");
            }




            string kertViragNeve = Console.ReadLine();

        }
    }
}
