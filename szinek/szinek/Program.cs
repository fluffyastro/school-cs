namespace szinek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szinek = { "piros", "kék", "sárga", "lila", "zöld", "fekete", "fehér", "narancs" };
            string[] nevek = { "Krisztofer", "Krisztián", "András", "Ákos", "Dominik", "Mihály" };

            int szinek_szama = szinek.Length;
            int nevek_szama = nevek.Length;

            Console.WriteLine($"Színek száma: {szinek_szama} Nevek száma: {nevek_szama} ");

            for (int i = 0; i < szinek_szama; i++) {
                Console.WriteLine(szinek[i]);
            }

            int x = 1;
            foreach (string nev in nevek)
            {
                char b = nev[0];
                if (b=='A')
                {

                }
                
            }

        }
    }
}
