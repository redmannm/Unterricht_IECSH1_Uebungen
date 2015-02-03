using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uebung8.Klassen;

namespace Uebung8
{
    public class Menues
    {
        public void Hauptmenu()
        {
            ConsoleKeyInfo menuKey;

            Mitarbeiter mitarbeiter = new Mitarbeiter();
            
            do
            {
                Program.ClearScreen();
                Console.WriteLine("Hauptmenü\n" +
                                  "---------\n\n" +
                                  "F1  - Mitarbeiter anlegen\n" +
                                  "F2  - Mitarbeiterliste anzeigen\n" +
                                  "F3  - Mitarbeiter suchen\n" +
                                  "F4  - Mitarbeiter deaktivieren\n" +
                                  "F5  - Lohnkosten anzeigen\n" +
                                  "ESC - Programm beenden");
                menuKey = Console.ReadKey();

                // Menüauswahl Mitarbeiter anlegen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    // Testdaten 
                    List<Mitarbeiter> testMaDaten = new List<Mitarbeiter>();
                    Mitarbeiter ma1 = new Mitarbeiter { "Redmann", "Marcus", System.DateTime.Parse("11.10.1974"), "Willhelm-Raabe-Weg", "13", "24159", "Kiel", 1, true };
                    
                    
                    Program.ClearScreen();
                    mitarbeiter.Anlegen();
                }

                // Menüuswahl Mitarbeiterliste anzeigen
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Program.ClearScreen();
                    mitarbeiter.getList();
                }

                // Menüauswahl Mitarbeiter suchen
                if (menuKey.Key == ConsoleKey.F3)
                {
                    
                }

                // Menüauswahl Mitarbeiter deaktivieren
                if (menuKey.Key == ConsoleKey.F4)
                {
                    
                }
                // Menüauswahl Lohnkosten anzeigen
                if (menuKey.Key == ConsoleKey.F4)
                {

                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }
    }
}
