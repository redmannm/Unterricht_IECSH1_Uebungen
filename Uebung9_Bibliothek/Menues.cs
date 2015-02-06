using System;
using System.Collections.Generic;
using System.Text;
using Uebung9_Bibliothek.Klassen;

namespace Uebung9_Bibliothek
{
    class Menues
    {
        ConsoleKeyInfo menuKey;
        VerleihVerwaltung verleihVerwaltung = new VerleihVerwaltung();
        public Menues()
        {
            Hauptmenue();
        }
        public void Hauptmenue()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Hauptmenü\n" +
                                  "---------\n\n" +
                                  "F1  - Artikel Verwalten\n" +
                                  "F2  - Verleih Verwaltung\n" +
                                  "---------------------------\n" +
                                  "ESC - Programm beenden");
                menuKey = Console.ReadKey();

                // Menüauswahl Mitarbeiter anlegen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    verleihVerwaltung.MediumHinzufuegen();
                }

                // Menüauswahl Testdaten laden
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Console.Clear();
                    
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }
    }
}
