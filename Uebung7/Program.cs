using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung7
{
    class Program
    {
        private const bool DEBUG = true;
        public static Luftfahrzeug[] arr_Luftfahrzeuge = null; // Array für Luftfahrzeuge

        static void Main(string[] args)
        {
            //Program thisApp = new Program();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Luftfahrzeuge";
            Console.SetWindowSize(90, 60); // Konsolenfenster auf 90 Zeichen Breite und 50 Zeilen höhe stellen
            GetMenuMain();
        }

        public static void GetMenuMain()
        {
            ConsoleKeyInfo menuKey;
            string message = "";
            
            do
            {
                ClearScreen();
                Console.WriteLine("HauptMenü\n" +
                              "---------\n\n" +
                              "F1  - Luftfahrzeuge anlegen\n" +
                              "F2  - Luftfahrzeuge ausgen\n" +
                              "F3  - Luftfahrzeuge starten\n" +
                              "ESC - Programm beenden\n\n");
                if (message.Length > 0)
                    
                    Console.WriteLine(message);
                menuKey = Console.ReadKey(true);

                // Menüauswahl Luftfahrzeuge anlegen
                if (menuKey.Key == ConsoleKey.F1)
                {
                    if (AddLuftfahrzeuge())
                        message = "Luftfahrzeuge erfolgreich angelegt!\n";
                }

                // Menüuswahl Luftfahrzeuge ausgeben
                if (menuKey.Key == ConsoleKey.F2)
                {
                    GetLuftfarzeuge();
                }

                // Menüauswahl Luftfahrzeuge starten
                if (menuKey.Key == ConsoleKey.F3)
                {
                    StartLuftfahrzeuge();
                }
            } while (menuKey.Key != ConsoleKey.Escape);
        }

        public static bool AddLuftfahrzeuge()
        {
            ConsoleKeyInfo menuKey;
            int anzLuftfahrzeuge;

            ClearScreen();
            Console.WriteLine("Luftfahrzeuge anlegen\n" +
                              "---------------------\n\n");
            do
            {
                try
                {
                    Console.Write("Wie viele Luftfahrezeuge möchten Sie anlegen: ");
                    anzLuftfahrzeuge = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nBitte geben Sie nur Ganzzahlen ein.\n");
                }
            } while (true);

            arr_Luftfahrzeuge = new Luftfahrzeug[anzLuftfahrzeuge];

            for (int i = 0; i < anzLuftfahrzeuge; i++)
            {
                ClearScreen();
                Console.WriteLine("Fahrzeugtyp bestimmen\n" +
                                  "---------------------\n\n" +
                                  "Luftfahrzeug {0} von {1} anlegen.\n\n" +
                                  "F1 - Flugzeug\n" +
                                  "F2 - Hubschrauber\n" +
                                  "F3 - Zeppelin\n\n" +
                                  "Ihre Auswahl:", i + 1, anzLuftfahrzeuge);

                do
                {
                    menuKey = Console.ReadKey(true);

                    // Menüauswahl Flugzeug
                    if (menuKey.Key == ConsoleKey.F1)
                    {
                        ClearScreen();
                        arr_Luftfahrzeuge[i] = new Flugzeug();
                        break;
                    }

                    // Menüuswahl Hubschrauber
                    if (menuKey.Key == ConsoleKey.F2)
                    {
                        ClearScreen();
                        arr_Luftfahrzeuge[i] = new Hubschrauber();
                        break;
                    }

                    // Menüauswahl Zeppelin
                    if (menuKey.Key == ConsoleKey.F3)
                    {
                        ClearScreen();
                        arr_Luftfahrzeuge[i] = new Zeppelin();
                        break;
                    } 
                } while (true);
            }
            return true;
        }

        public static void GetLuftfarzeuge()
        {
            int count = 0;
            ClearScreen();
            foreach (Luftfahrzeug item in arr_Luftfahrzeuge)
            {
                ++count;
                Console.WriteLine("Ausgabe des {0}. Luftfahrzeugs\n" +
                                  "--------------------------------\n", count);
                item.Ausgabe();
                // Console.WriteLine(item.GetType().ToString());
            }
            Console.WriteLine("Hauptmenü - Taste drücken");
            Console.ReadKey(true);
        }
        public static void StartLuftfahrzeuge()
        {
            
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }
    }
}