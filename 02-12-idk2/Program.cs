using System.Globalization;

namespace _02_12_idk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string kimenet = "";

            for (int i = 0; i < 50; i++)
            {

                int num = rnd.Next(1000);
                Console.WriteLine(num);

                // kimenet += num.ToString() + "\r\n";
                kimenet += num.ToString() + Environment.NewLine;
            }

            File.WriteAllText("szamok.txt", kimenet);

            Random rx = new.Random();

            for (int i = 0 ; i < 10 ; i++)
            {
                string filename = "out";
                string nums = "";

                for (int s = 0; s < 100; s++)
                {
                    //------------------------------------------------
                    int n1 = rx.Next(10, 20);
                    nums += n1 + Environment.NewLine;
                }

                int n1 = rx.Next(10,20);
                nums += n1 + Environment.NewLine;
            }
        }
    }
}
