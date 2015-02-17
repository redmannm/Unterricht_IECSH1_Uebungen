using System;
using System.Collections.Generic;
using System.Text;

namespace MenüBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo menuKey; // <-- Dort wird die Tastenauswahl gespeichert
            do
            {
                Console.Clear(); 

                Console.WriteLine("Hauptmenü\n" +
                                  "---------\n\n" +
                                  "F1  - Menüpunkt 1\n\n" +
                                  "F2  - Menüpunkt 2\n\n" +
                                  "F3  - Menüpunkt 3\n\n" +
                                  "---------------------------\n\n" +
                                  "ESC - Programm beenden\n\n");

                // Menüauswahl einlesen und an 'menuKey' übergeben
                menuKey = Console.ReadKey(true);

                // Menüauswahl Testdaten laden
                if (menuKey.Key == ConsoleKey.F1)
                {
                    // Programmcode oder Funktionsaufruf der bei Menüwahl ausgeführt wird
                    Console.WriteLine("Menüpunkt 1 ausgewählt (Taste Drücken)");
                    Console.ReadLine();
                }

                // Menüauswahl Artikelverwaltung
                if (menuKey.Key == ConsoleKey.F2)
                {
                    // Programmcode oder Funktionsaufruf der bei Menüwahl ausgeführt wird
                    Console.WriteLine("Menüpunkt 2 ausgewählt (Taste Drücken)");
                    Console.ReadLine();
                }

                // Menüauswahl Kundenverwaltung
                if (menuKey.Key == ConsoleKey.F3)
                {
                    // Programmcode oder Funktionsaufruf der bei Menüwahl ausgeführt wird
                    Console.WriteLine("Menüpunkt 3 ausgewählt (Taste Drücken)");
                    Console.ReadLine();
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }
    }
}
