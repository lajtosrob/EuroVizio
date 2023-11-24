using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace EuroGUI
{
    internal class Versenyzo
    {
        public int Ev { get; set; }
        public string Eloado { get; set; }
        public string Cim { get; set; }
        public int Helyezes { get; set; }
        public int Pontszam { get; set; }
        public Versenyzo(MySqlDataReader reader)
        {
            Ev = reader.GetInt32(0);
            Eloado = reader.GetString(1);
            Cim = reader.GetString(2);
            Helyezes = reader.GetInt32(3);
            Pontszam = reader.GetInt32(4);
        }
    }
}
