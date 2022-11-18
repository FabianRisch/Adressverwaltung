using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Adressverwaltung
{
    public class Adressverwaltung
    {
        public static int id = 0;
        public List<Adresse> Adressen { get; set; } = new List<Adresse>();

        public void AddAddress(Adresse adresseNeu)
        {
            Adressen.Add(adresseNeu);
        }

        public void DeleteAddress(int id) 
        {
            if (Adressen.Count() < id)
            {
                Console.WriteLine("Ungültiger Index");
                return;
            }
            Adressen.RemoveAt(id - 1);
        }

        public void ListAddresses()
        {
            foreach (var item in Adressen)
            {
                item.AdresseAusgeben();
            }
        }

        public void Menu()
        {
            Console.WriteLine("Wählen Sie eine Aktion");
            Console.WriteLine("1 - Adresse Hinzufügen");
            Console.WriteLine("2 - Adresse löschen");
            Console.WriteLine("3 - Adressen ausgeben");
            Console.WriteLine("4 - Beenden");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            switch (eingabe)
            {
                case 1:
                    Console.Clear();
                    using (StreamWriter sw = new StreamWriter(Path.Combine("file.csv")))
                    {


                        Console.WriteLine("PLZ eingeben:");
                        string plz = Console.ReadLine();
                        Console.WriteLine("Stadt eingeben:");
                        string stadt = Console.ReadLine();
                        Console.WriteLine("Strasse eingeben:");
                        string strasse = Console.ReadLine();
                        Console.WriteLine("HausNr eingeben:");
                        int nr = Convert.ToInt32(Console.ReadLine());
                        Adresse neu = new Adresse(stadt, strasse, nr, plz);

                        string content = $"{plz} {stadt}, {strasse} {nr}";
                        sw.WriteLine(content);

                    AddAddress(neu);
                    }
                    break;

                case 2:
                    Console.Clear();
                    foreach (var item in Adressen)
                    {
                        item.AdresseAusgeben();
                    }
                    Console.WriteLine("\nAdresse zum löschen auswählen");
                    int index = Convert.ToInt32(Console.ReadLine());
                    DeleteAddress(index);
                    break;

                case 3:
                    foreach (var item in Adressen)
                    {
                        item.AdresseAusgeben();
                    }
                    Console.WriteLine("Beliebige Taste zum fortfahren");
                    Console.ReadKey();
                    break;

                case 4:
                    Environment.Exit(-1);
                    break;

                default:
                    break;
            }
        }
    }
}
