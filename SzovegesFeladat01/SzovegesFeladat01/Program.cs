namespace SzovegesFeladat01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------------------------------------------------
            //                      ADATBEKÉRÉS

            Console.Write("Adja meg a szoba szélességét! [méter] ");
            double Szelesseg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg a szoba hosszúságát! [méter] ");
            double Hosszusag = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg a szoba magasságát! [méter] ");
            double Magassag = Convert.ToDouble(Console.ReadLine());
            //------------------------------------------------------
            //                      SZÁMÍTÁSOK
            
            double f = 1.3;
            double terulet = Szelesseg * Hosszusag;
            double terfogat= terulet * Magassag;
            double tomeg = terfogat * f;

            //------------------------------------------------------
            //                      ÍRÁS KONZOLRA

            Console.WriteLine($"A szoba területe: {terulet}");
            Console.WriteLine($"A szoba térfogata: {terfogat}");


        }
    }
}
