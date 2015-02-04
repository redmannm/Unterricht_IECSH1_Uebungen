using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autovermietung.Klassen;

namespace Autovermietung
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AutoVermietung autoVermietung = new AutoVermietung();
            ConsoleKeyInfo menuKey;
            do
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Hauptmenü\n" +
                                  "---------\n\n" +
                                  "F1  - Fahrzeugdaten erfassen\n" +
                                  "F2  - Alle Fahrzeugdaten anzeigen/bearbeiten\n" +
                                  "ESC - Programm beenden\n\n");

                menuKey = Console.ReadKey(true);

                // Menüauswahl
                if (menuKey.Key == ConsoleKey.F1)
                {
                    autoVermietung.addFahrzeug();
                }
                if (menuKey.Key == ConsoleKey.F2)
                {
                    autoVermietung.getFahrzeugliste();
                }
                if (menuKey.Key == ConsoleKey.F3)
                {

                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }
    }
}
