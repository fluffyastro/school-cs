using _25_Gyak_02_Onallo;

namespace _25_Gyak_02_Onallo
{



    class Csomag
    {
        public double a;
        public double b;
        public double c;
        public string kategoria;
        public double suly;
        private double maxMeret;

        public Csomag(double a, double b, double c, double suly)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            this.suly = suly;
            this.kategoria = "0";
            MaxMeretSzamolasa();
            setKategoria();
        }

        void MaxMeretSzamolasa()
        {
            this.maxMeret = 0;

            if (this.a > this.maxMeret)
            {
                this.maxMeret = a;
            }

            if (this.b > this.maxMeret)
            {
                this.maxMeret = b;
            }

            if (this.c > this.maxMeret)
            {
                this.maxMeret = c;
            }
        }

        public void tesztMaxMeret()
        {
            Console.WriteLine(this.maxMeret);
        }




        public void setKategoria()
        {
            if (this.maxMeret >= 20)
            {
                this.kategoria = "S";
                Console.WriteLine(this.kategoria);
            }

            else if (this.maxMeret > 20 && this.maxMeret < 40)
            {
                this.kategoria = "M";
                Console.WriteLine(this.kategoria);
            }

            else if (this.maxMeret > 40 && this.maxMeret < 100)
            {
                this.kategoria = "XL";
                Console.WriteLine(this.kategoria);
            }

            else if (this.maxMeret > 100)
            {
                this.kategoria = "0";
                Console.WriteLine(this.kategoria);
                Console.WriteLine("DAMN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                // S - legnagyobb méret 20cm alatt
                // M - legnagyobb méret 20-40cm között
                // XL - legnagyobb méret 40-100cm között
                // 0 - legnagyobb méret nagyobb 100cm-nél
                Csomag csomag1 = new Csomag(10, 10, 10, 0.2);

                csomag1.tesztMaxMeret();




                Csomag csomag2 = new Csomag(30, 30, 90, 4);

                Console.WriteLine("ha nem írja e felett ezek közül az egyiket: S, M, XL, 0");
                Console.WriteLine("akkor slight hint: nem működik xd");
            }
        }
    }
}
