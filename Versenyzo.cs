using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EuroVizio
{
    internal class Versenyzo
    {
        public Versenyzo(string adatsor)
        {

            string[] adatok = adatsor.Split(";");

            if (int.TryParse(adatok[0], out int VersenyEve ))
            {
                this.versenyEve = VersenyEve;
            }
            else
            {
                Console.WriteLine("Hiba a verseny éve konvertálása során");
            }

            orszag = adatok[1];
            eloadoNeve = adatok[2];
            eloadoCime = adatok[3];

            if (int.TryParse(adatok[4], out int ElertHelyzes))
            {
                this.elertHelyezes = ElertHelyzes;
            }
            else
            {
                Console.WriteLine("Hiba az elért helyezés konvertálása során.");
            }

            if (int.TryParse(adatok[5], out int Pontszam))
            {
                this.pontszam = Pontszam;
            }
            else 
            {
                Console.WriteLine("Hiba a pontszám konvertálása során.");
            }

        }

        public int versenyEve {  get; set; }
        public string orszag {  get; set; }
        public string eloadoNeve { get; set; }
        public string eloadoCime { get; set; }

        public int elertHelyezes { get; set; }

        public int pontszam {  get; set; }



    }
}
