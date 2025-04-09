namespace _03_05_doga_teszt
{
    static List<Alaplap> alaplapok = new List<Alaplap>();
    static void Feladat1()
    {
        Console.WriteLine($"1. feladat: {alaplapok.Count}");
    }

    static void Feladat6()
    {
        foreach (Alaplap item in alaplapok)
        {
            if (item.Kod == "ALO")
            {
                Console.WriteLine($"6. feladat: {item.Nev}");
            }
        }
    }

    static void Feladat7()
    {
        Console.WriteLine($"7. feladat: ");
        foreach (Alaplap item in alaplapok)
        {
            if (item.Datam.Substring(5, 5) == "01.01")
            {
                Console.WriteLine($"\t {item.Nev} ({item.Datam})");
            }
        }
    }

    static void Feladat3()

    static void Main(string[] args)
    {
        string[] alaplapok = File.ReadAllLines("alaplapok.txt");

        for (int i = 1; i < alaplapok.Length; i++)
        {
            string[] mezok = alaplapok[i].Split(';');

            Alaplap v1 = new Alaplap(mezok[0], mezok[1], mezok[2], mezok[3]);
            alaplapok.Add(v1);
        }
        Feladat1();
        Feladat6();
        Feladat7();
        Feladat8();
        Console.ReadKey();
    }
}



class Alaplap
{

    public Alaplap(string orszag, string gyarto, string alaplap_tipusa, string ara, string eladott_mennyiseg, string nepszerusegi_utmutato)
    {
        Orszag = orszag;
        Gyarto = gyarto;
        AlaplapTipusa = alaplap_tipusa;
        Ara = ara;
        EladottMennyiseg = eladott_mennyiseg;
        NepszerusegiUtmutato = nepszerusegi_utmutato;
    }

    public string Orszag { get; set; }
    public string Gyarto { get; set; }
    public string AlaplapTipusa { get; set; }
    public string Ara { get; set; }
    public string EladottMennyiseg { get; set; }
    public string NepszerusegiUtmutato { get; set; }

}
}
