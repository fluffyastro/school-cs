using System.Reflection.Metadata.Ecma335;

namespace File01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string allText = File.ReadAllText("adatok.txt");

            string[] sorok = allText.Split("\r\n");

            foreach (string sor in sorok)
            {
                if (sor.Length > 3)
                {
                    string[] mezok = sor.Split(',');

                    string nev = mezok[0];
                    string imel = mezok[1];
                    string telefono = mezok[2];



                    Console.WriteLine(imel);
                }
            }


            Console.WriteLine("----------------");

            string[] sorok2 = File.ReadAllLines("adatok.txt");

            string hibaSzoveg = "It starts with one\r\n One thing, I don't know why\r\nIt doesn't even matter how hard you try\r\nKeep that in mind, I designed this rhyme\r\nTo explain in due time, all I know\r\nTime is a valuable thing\r\nWatch it fly by as the pendulum swings\r\nWatch it count down to the end of the day\r\nThe clock ticks life away, it's so unreal\r\nDidn't look out below\r\nWatch the time go right out the window\r\nTryin' to hold on, d-didn't even know\r\nI wasted it all just to watch you go\r\nI kept everything inside\r\nAnd even though I tried, it all fell apart\r\nWhat it meant to me will eventually be\r\nA memory of a time when I tried so hard\r\nI tried so hard and got so far\r\nBut in the end, it doesn't even matter\r\nI had to fall to lose it all\r\nBut in the end, it doesn't even matter\r\nOne thing, I don't know why\r\nIt doesn't even matter how hard you try\r\nKeep that in mind, I designed this rhyme\r\nTo remind myself how I tried so hard\r\nIn spite of the way you were mockin' me\r\nActin' like I was part of your property\r\nRemembering all the times you fought with me\r\nI'm surprised it got so far\r\nThings aren't the way they were before\r\nYou wouldn't even recognize me anymore\r\nNot that you knew me back then\r\nBut it all comes back to me in the end\r\nYou kept everything inside\r\nAnd even though I tried, it all fell apart\r\nWhat it meant to me will eventually be\r\nA memory of a time when I tried so hard\r\nI tried so hard and got so far\r\nBut in the end, it doesn't even matter\r\nI had to fall to lose it all\r\nBut in the end, it doesn't even matter\r\nI've put my trust in you\r\nPushed as far as I can go\r\nFor all this, there's only one thing you should know\r\nI've put my trust in you\r\nPushed as far as I can go\r\nFor all this, there's only one thing you should know\r\nI tried so hard and got so far\r\nBut in the end, it doesn't even matter\r\nI had to fall to lose it all\r\nBut in the end, it doesn't even matter";
            string elozoSzoveg = File.ReadAllText("log.txt");

            File.WriteAllText("log.txt",hibaSzoveg +"\r\n"+ elozoSzoveg);


            for (int i = 0; i < 10; i++)
            {
                string szamlalo = Convert.ToString(hibaSzoveg);
                File.AppendAllText("log.txt", hibaSzoveg);
            }






        }
    }
}
