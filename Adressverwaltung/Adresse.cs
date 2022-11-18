using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressverwaltung
{
    public class Adresse
    {
        public static int idCounter = 0;

        public int id { get; set; }
        public string Stadt { get; set; }

        public string Strasse { get; set; }

        public int HausNr { get; set; }

        public string PLZ { get; set; }

        public Adresse(string stadt, string strasse, int hausNr, string pLZ)
        {
            PLZ = pLZ;
            Stadt = stadt;
            Strasse = strasse;
            HausNr = hausNr;
            id = ++idCounter;
        }

        public Adresse()
        {

        }

        public void AdresseAusgeben()
        {
            Console.WriteLine($"{id} - {PLZ} {Stadt}, {Strasse} {HausNr}");
        }
    }
}
