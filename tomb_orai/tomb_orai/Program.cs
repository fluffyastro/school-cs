namespace tomb_orai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aha = { 10, 20, 50, 10, 20, 40, 10, 20, 100 };
            int szum = 0;
            int index = 0;
            int szam = 0;
            foreach (int i in aha)
            {
                Console.WriteLine(i);
            }

                foreach (int x in aha)
            {
                szum += x;
                if (x == 20)
                {
                    Console.WriteLine(index);
                }
                index++;
                
            }

            Console.WriteLine("Szum:" + szum);
            Console.ReadLine();
        }
    }
}
