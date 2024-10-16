namespace switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char betu = (char)Console.Read();

            switch (betu)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("BALRA");
                    break;

                case 'D':
                case 'd':
                    Console.WriteLine("JOBBRA");
                    break;

                case 'S':
                case 's':
                    Console.WriteLine("LEFELÉ/HÁTRA");
                    break;

                case 'W':
                case 'w':
                    Console.WriteLine("FELFELÉ/ELŐRE");
                    break;
            }
        }
    }
}
