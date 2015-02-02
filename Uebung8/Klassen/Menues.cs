using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung8.Klassen
{
    public class Menues
    {
        public void Hauptmenu()
        {
            ConsoleKeyInfo menuKey;

            Program.ClearScreen();
            do
            {
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
                    
                }

                // Menüuswahl Mitarbeiterliste anzeigen
                if (menuKey.Key == ConsoleKey.F2)
                {
                    
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
