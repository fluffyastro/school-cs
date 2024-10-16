namespace doga2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tömbök elnevezése, tömb tartalmainak megadása

            string[] honap_tomb = ["Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December"];
            string[] nap_tomb = ["Vasárnap", "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek", "Szombat"];


            // szám(ok) bekérése/beírása

            Console.WriteLine("Írjon be egy hónap számát!");
            int honap_bekeres = Convert.ToInt32(args[0]);
            int nap_bekeres = Convert.ToInt32(args[1]);
            {
                {
                    Console.WriteLine(honap_tomb[honap_bekeres-1]);
                    Console.WriteLine(nap_tomb[nap_bekeres - 1]);
                    Console.ReadLine();
                }
            }
        }
    }
}
