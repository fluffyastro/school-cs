namespace _04_02_Exceptions
{

    class Operation
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public string opr { get; set; }
        public double output { get; set; }
        public Operation(string input)
        {
            this.opr = "null";

            if (input.Contains("+")) { this.opr = "+"; }
            if (input.Contains("+")) { this.opr = "-"; }
            if (input.Contains("+")) { this.opr = "*"; }
            if (input.Contains("+")) { this.opr = "/"; }

            string[] parts = { };

            if (input.Length >= 3)
            {
                parts = input.Split(this.opr);
            }
            else
            {
                this.opr = "null";
            }

            try
            {
                this.num1 = int.Parse(parts[0]);
            }
            catch (Exception)
            {
                this.opr = "null";
            }


            if(this.opr!="null")
            {
                if (this.opr == "+")
                {
                    this.output = this.num1 + this.num2;
                }
                if (this.opr == "-")
                {
                    this.output = this.num1 - this.num2;
                }
                if (this.opr == "*")
                {
                    this.output = this.num1 * this.num2;
                }
                if (this.opr == "/")
                {
                    this.output = this.num1 / this.num2;
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                StreamReader sr = null;

                try
                {
                    sr = new StreamReader("file.txt");
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Megnyitási hiba: " + ex.Message);
                }


                Operation x = new Operation("1.5*8");
                Console.WriteLine(x.output);
            }
        }
    }
}