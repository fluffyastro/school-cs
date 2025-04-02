namespace Kivételek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valami = 10;

            Console.WriteLine("Kérek egy egész számot: ");
            int egeszSzam = int.Parse(Console.ReadLine());
            
            try
            {
                int[] tomb = new int[6];
                tomb[5] = 10;
            }
            catch(IndexOutOfRangeException ex) 
            {
                Console.WriteLine("Tömbindex hiba: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Hiba történt: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Általános hiba történt: " + ex.Message);
            }



            // 3 - Fájlkezelés

            StreamReader sr = null;
            try
            {
                sr = new StreamReader("fajl.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("A fájl nem található: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Általános hiba történt: " + ex.Message);
            }
            finally
            {
                sr?.Close();
                Console.WriteLine("A program folytatódik.");
            }

            // 4 - Fájlkezelés kivétele

            try
            {
                string tartalom = File.ReadAllText("fajl.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("A fájl nem található: " + ex.Message);
            }
            
            // 5 - kimaradt lmfao



            // 6 - Kivételkezelés file olvasásánál

            string fajlNev = "fajl.txt";
            try
            {
                if (File.Exists(fajlNev))
                {
                    string tartalom = File.ReadAllText(fajlNev);
                    Console.WriteLine(tartalom);
                }
                else
                {
                    //throw new FileNotFoundException("A fájl nem található.");
                    Console.WriteLine("A fájl nem létezik.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Fájlműveleti hiba: " + ex.Message);
            }
    }
}
