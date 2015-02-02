using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                              "F2  - Luftfahrzeuge ausgeben\n" +
                              "F3  - Luftfahrzeuge starten\n" +
                              "F4  - Luftfahrzeuge stoppen\n" +
                              "ESC - Programm beenden\n\n");
                if (message.Length > 0)
                    Console.WriteLine(message);
                message = "";
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

                // Menüauswahl Luftfahrzeuge stoppen
                if (menuKey.Key == ConsoleKey.F4)
                {
                    StopLuftfahrzeuge();
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
            if (arr_Luftfahrzeuge != null)
            {
                foreach (Luftfahrzeug item in arr_Luftfahrzeuge)
                {
                    ++count;
                    Console.WriteLine("Ausgabe des {0}. Luftfahrzeugs\n" +
                                      "--------------------------------\n", count);
                    item.Ausgabe();
                    // Console.WriteLine(item.GetType().ToString());
                }
            }
            else
            {
                Console.WriteLine("Keine Luftfahrzeuge vorhanden.\n" +
                                  "------------------------------\n");
            }
            Console.WriteLine("Hauptmenü - Taste drücken");
            Console.ReadKey(true);
        }
        public static void StartLuftfahrzeuge()
        {
            int count = 0;
            string typ = "";
            ClearScreen();
            if (arr_Luftfahrzeuge != null)
            {
                foreach (Luftfahrzeug item in arr_Luftfahrzeuge)
                {
                    ++count;

                    // Fahrzeugtyp ermitteln
                    if (item.GetType().ToString().EndsWith("Flugzeug"))
                        typ = "Das Flugzeug";
                    else if (item.GetType().ToString().EndsWith("Hubschrauber"))
                        typ = "Der Hubschrauber";
                    else if (item.GetType().ToString().EndsWith("Zeppelin"))
                        typ = "Der Zeppelin";


                    Console.WriteLine("Das {0}. Fahrzeug wird gestartet\n" +
                                      "--------------------------------\n", count);
                    if (item.Gestartet)
                    {
                        Console.WriteLine("{0} ist bereits gestartet.\n", typ);
                    }
                    else
                    {
                        Console.Write("{0} wird gestartet", typ);
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write(" .");
                            Thread.Sleep(300);
                        }
                        Console.WriteLine("\n\n{0} wurde erfolgreich gestartet.\n", typ);
                        item.StartenStoppen();
                    }
                }
            }
            else
            {
                Console.WriteLine("Keine Luftfahrzeuge vorhanden.\n" +
                                  "------------------------------\n");
            }
            Console.WriteLine("Hauptmenü - Taste drücken");
            Console.ReadKey(true);
        }

        private static void StopLuftfahrzeuge()
        {
            int count = 0;
            string typ = "";
            ClearScreen();
            if (arr_Luftfahrzeuge != null)
            {
                foreach (Luftfahrzeug item in arr_Luftfahrzeuge)
                {
                    ++count;

                    // Fahrzeugtyp ermitteln
                    if (item.GetType().ToString().EndsWith("Flugzeug"))
                        typ = "Das Flugzeug";
                    else if (item.GetType().ToString().EndsWith("Hubschrauber"))
                        typ = "Der Hubschrauber";
                    else if (item.GetType().ToString().EndsWith("Zeppelin"))
                        typ = "Der Zeppelin";


                    Console.WriteLine("Das {0}. Fahrzeug wird gestoppt\n" +
                                      "-------------------------------\n", count);
                    if (!item.Gestartet)
                    {
                        Console.WriteLine("{0} ist bereits gestoppt.\n", typ);
                    }
                    else
                    {
                        Console.Write("{0} wird gestoppt", typ);
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write(" .");
                            Thread.Sleep(300);
                        }
                        Console.WriteLine("\n\n{0} wurde erfolgreich gestoppt.\n", typ);
                        item.StartenStoppen();
                    }
                }
            }
            else
            {
                Console.WriteLine("Keine Luftfahrzeuge vorhanden.\n" +
                                  "------------------------------\n");
            }
            Console.WriteLine("Hauptmenü - Taste drücken");
            Console.ReadKey(true);
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }
    }
}