using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Adressverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Adressverwaltung test = new Adressverwaltung();
            bool schalter = true;
            while (schalter)
            {
                test.Menu();

                Console.Clear();


            }
        }
    }
}
