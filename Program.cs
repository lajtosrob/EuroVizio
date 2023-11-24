namespace EuroVizio
{
    internal class Program
    {
        static List<Versenyzo> versenyzok = new List<Versenyzo>(); 
        static void Main(string[] args)
        {

            // 3. feladat

            StreamReader sr = new StreamReader(".\\DataSource\\eurovizio.csv");

            while (!sr.EndOfStream)
            {
                 string line = sr.ReadLine();

                Versenyzo adatsor = new Versenyzo(line);

                versenyzok.Add(adatsor);
            }

            sr.Close();

            // 4. feladat

            Console.WriteLine($"4. feladat: Versenyzők száma: {versenyzok.Count()}");

        }
    }
}