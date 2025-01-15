namespace _2025_02_15_Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Busz helyi_jaratos_busz = new Busz(5150, "EEE-621", "Kanalas Mercédesz");
            Busz tavolsagi_jarat = new Busz(6210, "XBD-621", "Lakatos Szkánia");
            Busz betol_busz = new Busz(0621, "XXE-621", "Terdik László");

            tavolsagi_jarat.set_hely_jegy(15);
            tavolsagi_jarat.set_hely_jegy(16);
            Console.WriteLine(tavolsagi_jarat.get_hely_jegy(15));
            Console.WriteLine(tavolsagi_jarat.get_hely_jegy(1));
            tavolsagi_jarat.get_hely_jegyek_listaja();

            helyi_jaratos_busz.set_hely_jegy(15);
            helyi_jaratos_busz.get_hely_jegyek_listaja();

            betol_busz.set_hely_jegy(1);
            betol_busz.set_hely_jegy(2);
            betol_busz.set_hely_jegy(3);
            Console.WriteLine(betol_busz.get_hely_jegy(1));
            Console.WriteLine(betol_busz.get_hely_jegy(2));
            Console.WriteLine(betol_busz.get_hely_jegy(3));
            betol_busz.get_hely_jegyek_listaja();

        }
    }

    class Busz
    {
        public int jarat_szama;
        public string rendszam;
        public string sofor_neve;
        private int[] foglalt_helyek = new int[60];

        public Busz(int jarat_szama, string rendszam, string sofor_neve)
        {
            this.jarat_szama = jarat_szama;
            this.rendszam = rendszam;
            this.sofor_neve = sofor_neve;
            for (int i = 0; i > 60; i++)
            {
                this.foglalt_helyek[i] = 0;
            }
        }

        public void set_hely_jegy(int ules_szama)
        {
            if (ules_szama > 0 && ules_szama < 60) {

                if (foglalt_helyek[ules_szama] == 1)
                {
                    Console.WriteLine($"Már a {ules_szama} foglalt!");
                }
                else
                {
                    this.foglalt_helyek[ules_szama] = 1;
                    Console.WriteLine("Sikeres foglalás!");
                }
            }
            else
            {
                Console.WriteLine("Érvénytelen hely!");
            }
        }

        //------------------------------------------------------
        public string get_hely_jegy(int ules_szama)
        {

            if (this.foglalt_helyek[ules_szama] == 1)
            {
                return "foglalt";
            }
            else
            {
                return "szabad";
            }
        }

        //------------------------------------------------------

        public void get_hely_jegyek_listaja()
        {
            for (int i = 1; i < 60; i++)
            {
                if (this.foglalt_helyek[i] == 1)
                {
                    Console.WriteLine($"{i}. ülés: foglalt");
                }
                else
                {
                    Console.WriteLine($"{i}. ülés: szabad");
                }
            }
        }
    }
}
