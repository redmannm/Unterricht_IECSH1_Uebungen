using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung8.Klassen
{
    class Mitarbeiter : Personen : IEnumerable<Mitarbeiter>
    {

        int steuerKlasse;
        public int SteuerKlasse
        {
            get
            {
                return steuerKlasse;
            }
            set
            {
                steuerKlasse = value;
            }
        }

        int kinder;
        public int Kinder
        {
            get
            {
                return kinder;
            }
            set
            {
                kinder = value;
            }
        }

        double bruttoLohn;
        public double BruttoLohn
        {
            get
            {
                return bruttoLohn;
            }
            set
            {
                bruttoLohn = value;
            }
        }

        public Mitarbeiter()
        {

        }

        public Mitarbeiter(Mitarbeiter[] ma)
        {

        }
        public Mitarbeiter(string _name, string _vorname, DateTime gebDat, string _strasse, string _hausnummer, string _plz, string _ort, string _konfession, bool _status)
        {

        }

        public override void Anlegen()
        {
            // Ausgabe vorbereiten
            Console.WriteLine("Mitarbeiter anlegen\n" +
                              "-------------------\n\n" +
                              "Persönliche Daten\n\n");
            Console.Write("{0}", "Familienname:".PadRight(14));
            Name = Console.ReadLine();

            Console.Write("{0}", "Vorname:".PadRight(14));
            Vorname = Console.ReadLine();

            do
            {
                try
                {
                    Console.Write("{0}", "Geb.-Datum:".PadRight(14));
                    GebDat = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("\n");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Das Datumsformat ist nicht richtig. Bitte in diesem Format eingeben: (DD.MM.JJJJ).");
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("\n");
                }
            } while (true);

            Console.Write("{0}", "Straße:".PadRight(14));
            Strasse = Console.ReadLine();

            Console.Write("{0}", "Nummer:".PadRight(14));
            Hausnummer = Console.ReadLine();

            Console.Write("{0}", "PLZ:".PadRight(14));
            Plz = Console.ReadLine();

            Console.Write("{0}", "Ort:".PadRight(14));
            Ort = Console.ReadLine();

            Console.WriteLine("{0}", "\n\nLohndaten:\n");

            Console.Write("{0}", "Bruttolohn:".PadRight(14));
            BruttoLohn = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0}", "Kinder:".PadRight(14));
            Kinder = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}", "Lohn-St.-Klasse:".PadRight(14));
            SteuerKlasse = Convert.ToInt32(Console.ReadLine());
        }

        internal void getList()
        {
            int pos = 0;

            Console.Write("Mitarbeiter-Liste anzeigen\n" +
                          "--------------------------\n\n");
            Console.Write("================================================================================\n" + 
                          "| Pos. | Famielienname       | Vorname             | Geb.-Datum   | Bruttolohn |\n" +
                          "================================================================================\n");
            Console.Write("| {0} | {1} | {2} | {3} | {4} |", pos.ToString().PadRight(4), Name.PadRight(19), Vorname.PadRight(19), GebDat.ToShortDateString().PadRight(10), BruttoLohn.ToString().PadRight(10));
            Console.Write("--------------------------------------------------------------------------------\n");
            Console.ReadKey();

        }
    }
}
