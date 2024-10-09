namespace orai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = args[0];
            int szam = Convert.ToInt32(args[1]);


            for (int i = 0; i < szam; i++)
            {
                Console.Write(szoveg);
                Console.Write(' ');
            }



            Console.ReadLine();
        }
    }
}
