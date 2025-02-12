namespace _02_12_self
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string output = "";

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    for (int chr = 0; chr < 50; chr++)
                    {
                        output += Convert.ToChar(rnd.Next(97, 122));
                    }
                    output += Environment.NewLine;
                }
                File.WriteAllText($"szoveg0{i}.txt", output);
            }
        }
    }
}
