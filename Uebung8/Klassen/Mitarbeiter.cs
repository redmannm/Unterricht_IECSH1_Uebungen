using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung8.Klassen
{
    class Mitarbeiter : Personen
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

        public void Anlegen()
        {
            // Ausgabe vorbereiten
            Console.WriteLine("Mitarbeiter anlegen\n" +
                              "-------------------\n\n" +
                              "Persönliche Daten\n\n");
            Console.WriteLine("{0}", "Familienname:".PadRight(14));
            Name = Console.ReadLine();

            Console.WriteLine("{0}", "Vorname:".PadRight(14));
            Vorname = Console.ReadLine();

            try
            {
                Console.WriteLine("{0}", "Geb.-Datum:".PadRight(14));
                GebDat = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Das Datumsformat ist nicht richtig. Bitte in diesem Format eingeben: (DD.MM.JJJJ).");
            }

            Console.WriteLine("{0}", "Straße:".PadRight(14));
            Strasse = Console.ReadLine();

            Console.WriteLine("{0}", "Nummer:".PadRight(14));
            Hausnummer = Console.ReadLine();

            Console.WriteLine("{0}", "PL:".PadRight(14));
            Plz = Console.ReadLine();

            Console.WriteLine("{0}", "Ort:".PadRight(14));
            Ort = Console.ReadLine();

            Console.WriteLine("{0}", "\n\nLohndaten:".PadRight(14));

            Console.WriteLine("{0}", "Ort:".PadRight(14));
            Ort = Console.ReadLine();
        }
    }
}
