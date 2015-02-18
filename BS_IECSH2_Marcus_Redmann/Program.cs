using System;
using System.Collections.Generic;
using System.Text;
using BS_IECSH2_Marcus_Redmann.Konten;

namespace BS_IECSH2_Marcus_Redmann
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo menuKey; // <-- Dort wird die Tastenauswahl gespeichert

            KontenVerwalten kontenVerwalten = new KontenVerwalten();


            do
            {
                Console.Clear();

                Console.WriteLine("\n Wenn's ums Geld geht? Spaßkasse!");
                Console.WriteLine(" ════════════════════════════════\n");
                Console.WriteLine(" Hauptmenü\n" +
                                  " ═════════\n\n" +
                                  " F1  - Konto anlegen\n\n" +
                                  " F2  - Buchung vornehmen\n\n" +
                                  " ═══════════════════════════════════════\n\n" +
                                  " ESC - Programm beenden\n\n");
                

                // Menüauswahl einlesen und an 'menuKey' übergeben
                menuKey = Console.ReadKey(true);

                // Menüauswahl Konto anlegen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    kontenVerwalten.KontoAnlegen();
                }

                // Menüauswahl Buchung vornehmen
                if (menuKey.Key == ConsoleKey.F2)
                {
                    kontenVerwalten.KontoBuchung();
                }

                // Menüauswahl Testdaten
                if (menuKey.Key == ConsoleKey.F12)
                {
                    // Programmcode oder Funktionsaufruf der bei Menüwahl ausgeführt wird
                    Console.WriteLine("Menüpunkt 4 ausgewählt (Taste Drücken)");
                    Console.ReadLine();
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }
    }
}
