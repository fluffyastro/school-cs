namespace _2025_01_29_ISM
{
    internal class auto
    {
        public string rendszam;
        public string alvazszam;
        public double sebesseg;
        private int Km;
        
        public auto(string rendszam, string alvazszam, double sebesseg)
        {
            this.rendszam=rendszam;
            this.alvazszam=alvazszam;
            this.sebesseg=sebesseg;
        }

        public void sebesseg_modositasa(double v)
        {
            this.sebesseg = v;
        }

        public void KmModositasa(int Km)
        {
            this.Km = Km;
        }

        public void Stop()
        {
            this.sebesseg = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autó teszt");

            auto av8_harrier = new auto("NINCS-001", "76543210987654321", 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679);
        }
    }
}
