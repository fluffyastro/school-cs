namespace Switch01;

internal class Program
{
    static void Main(string[] args)
    {
        int[] jegyek = { 5, 5, 3, 5, 1, 5, 4, 5 };

        int szum = 0;
        for (int i = 0; i < jegyek.Length; i++)
        {
            szum += jegyek[i];
        }

        double atlag = Convert.ToDouble(szum) / jegyek.Length;


        switch (atlag)
        {
            case > 4.5:
                Console.WriteLine("Jeles! :3");
                break;
            case > 3.5:
                Console.WriteLine("Jó! :D");
                break;
            case > 2.5:
                Console.WriteLine("Közepes! :/");
                break;
            case > 1.5:
                Console.WriteLine("Elégséges! :(");
                break;
            default:
                Console.WriteLine("Elégtelen! :-C");
                break;
        }
    }
}