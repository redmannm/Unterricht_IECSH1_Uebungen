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
        Mitarbeiter mitarbeiter = new Mitarbeiter();
        public Menues()
        {

        }
        public void Hauptmenu()
        {
            ConsoleKeyInfo menuKey;
            do
            {
                Program.ClearScreen();
                Console.WriteLine("Hauptmenü\n" +
                                  "---------\n\n" +
                                  "F1  - Mitarbeiter anlegen\n" +
                                  "F2  - Mitarbeiter Testdaten laden\n" +
                                  "F3  - Mitarbeiterliste anzeigen\n" +
                                  "F4  - Mitarbeiter suchen\n" +
                                  "F5  - Mitarbeiter deaktivieren\n" +
                                  "F6  - Lohnkosten anzeigen\n" +
                                  "ESC - Programm beenden");
                menuKey = Console.ReadKey();

                // Menüauswahl Mitarbeiter anlegen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    mitarbeiter = new Mitarbeiter();
                    Program.ClearScreen();
                    mitarbeiter.Anlegen();
                }

                // Menüauswahl Testdaten laden
                if (menuKey.Key == ConsoleKey.F2)
                {
                    Program.ClearScreen();
                    Mitarbeiter mitarbeiter = new Mitarbeiter(true);
                }

                // Menüuswahl Mitarbeiterliste anzeigen
                if (menuKey.Key == ConsoleKey.F3)
                {
                    Program.ClearScreen();
                    mitarbeiter.getList();
                }

                // Menüauswahl Mitarbeiter suchen
                if (menuKey.Key == ConsoleKey.F4)
                {
                    
                }

                // Menüauswahl Mitarbeiter deaktivieren
                if (menuKey.Key == ConsoleKey.F5)
                {
                    
                }
                // Menüauswahl Lohnkosten anzeigen
                if (menuKey.Key == ConsoleKey.F6)
                {

                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }
    }
}
