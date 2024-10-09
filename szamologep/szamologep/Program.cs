namespace szamologep
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {

                double x = Convert.ToDouble(args[0]);
                string operacio = args[1];
                double y = Convert.ToDouble(args[2]);

                double eredmeny = 0;
                if (operacio == "+") { eredmeny = x + y; }
                if (operacio == "-") { eredmeny = x - y; }
                if (operacio == "*") { eredmeny = x * y; }
                if (operacio == "/") { eredmeny = x / y; }
                

                if(operacio == "sin") {eredmeny = x Math.Sin
                Console.WriteLine("Az eredmény: " + eredmeny);

            }
            else
            {
                Console.WriteLine("nics paraméter");
                Console.WriteLine("büntetésből szét fogjuk húzni a lukadat");
            }








            Console.ReadLine();
        }
    }
}
