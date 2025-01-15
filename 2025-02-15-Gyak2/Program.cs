namespace _2025_02_15_Gyak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto bmw_doboz_m3 = new Auto("CLOUT-1", "WZ162194612726483", "XD123456", 1831479, 3, 30);
            Auto parti_busz = new Auto("VIRKELVIDO-1", "JTD62194681526801", "XD123456", 982, 8, 43);

            bmw_doboz_m3.set_uzemanyag(1, 30);
            bmw_doboz_m3.get_adatok();

            parti_busz.set_uzemanyag(0.25, 30);
            parti_busz.get_adatok();
        }
    }

    class Auto
    {
        public string rendszam;
        private string alvazszam;
        public string forgalmi_szama;
        public double kilometer_allasa;
        public double uzemanyag_szint;
        public double sebesseg;
        public double fogyasztas;

        public Auto(string rendszam, string alvazszam, string forgalmi_szama, int kilometer_allasa, int uzemanyag_szint, int fogyasztas)
        {
            this.rendszam = rendszam;
            this.alvazszam = alvazszam;
            this.forgalmi_szama = forgalmi_szama;
            this.kilometer_allasa = kilometer_allasa;
            this.uzemanyag_szint = uzemanyag_szint;
            this.fogyasztas = fogyasztas;
        }
        public void set_uzemanyag(double ido, double sebesseg)
        {
            this.kilometer_allasa += ido * sebesseg;
            this.uzemanyag_szint += ido * sebesseg * this.fogyasztas / 100;
        }

        public void get_adatok()
        {
            Console.WriteLine();
            Console.WriteLine($"Rendszám: {rendszam}");
            Console.WriteLine($"Alvázszám: {alvazszam}");
            Console.WriteLine($"Forgalmi száma: {forgalmi_szama}");
            Console.WriteLine($"A jármű kilóméter állása: {kilometer_allasa}");
            Console.WriteLine($"Üzemanyag szint: {uzemanyag_szint}");
            Console.WriteLine($"Fogyasztás: {fogyasztas}");
        }

    }
}
