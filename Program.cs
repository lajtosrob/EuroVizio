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

            // 5. feladat

            Console.WriteLine("5. feladat: Nem magyarországi versenyzők");

            //List<Versenyzo> nemMagyar = versenyzok.Where(x => x.orszag != "Magyarország").ToList();

            versenyzok.Where(x => x.orszag != "Magyarország").ToList().ForEach(x => Console.WriteLine(x.eloadoCime));


            // 7. feladat 

            Console.WriteLine("7. feladat: Kéram az országot: ");

            string megadottOrszag =  Console.ReadLine();

            if (versenyzok.Any(y => y.orszag == megadottOrszag))
            {
                Console.WriteLine($"Az ország átlagos pontszáma: {Math.Round(versenyzok.Average(x => x.pontszam), 0)}");
            }
            else
            {
                Console.WriteLine("Nem található ilyen nevű ország");
            }

        }
    }
}