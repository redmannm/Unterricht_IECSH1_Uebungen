using AutoClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo menuKey;
            Auto fahrzeug1 = new Auto();

            Console.Write(getMenu(1));
            
            do
            {
                menuKey = Console.ReadKey(true);
                
                //
                // Fahrzeug-Eigenschaften anzeigen
                //
                if (menuKey.Key == ConsoleKey.D1)
                {
                    Console.Write(getMenu(1));
                    fahrzeug1.getPkwConfig();
                }

                //
                // Fahrzeug-Eigenschaften bearbeiten
                //
                if (menuKey.Key == ConsoleKey.D2)
                {
                    Console.Write(getMenu(1));
                    fahrzeug1.setPkwConfig();
                    Console.Write(getMenu(1));
                    Console.WriteLine("Die Fahrzeug-Eigenschaften wurden erfolgreich bearbeitet.");
                }

                //
                // Fahrzeugtür öffnen
                //
                if (menuKey.Key == ConsoleKey.D3)
                {
                    if (fahrzeug1.tuerOffen)
                    {
                        Console.Write(getMenu(1));
                        Console.WriteLine("Die Fahrzeugtür ist bereits geöfnet!");
                    }
                    else
                    {
                        fahrzeug1.TuerAction();
                        Console.Write(getMenu(1));
                        Console.WriteLine("Die Fahrzeugtür wurde geöfnet!");
                    }
                }

                //
                // Fahrzeugtür schließen
                //
                if (menuKey.Key == ConsoleKey.D4)
                {
                    if (!fahrzeug1.tuerOffen)
                    {
                        Console.Write(getMenu(1));
                        Console.WriteLine("Die Fahrzeugtür ist bereits geschloßen!");
                    }
                    else
                    {
                        fahrzeug1.TuerAction();
                        Console.Write(getMenu(1));
                        Console.WriteLine("Die Fahrzeugtür wurde geschloßen!");
                    }
                }

                //
                // Motor starten
                //
                if (menuKey.Key == ConsoleKey.D5)
                {
                    if (fahrzeug1.motorAn)
                    {
                        Console.Write(getMenu(1));
                        Console.WriteLine("Der Motor läuft bereits!");
                    }
                    else
                    {
                        fahrzeug1.MotorAction();
                        Console.Write(getMenu(1));
                        Console.WriteLine("Der Motor wurde gestartet!");
                    }
                }
                    
            } while (menuKey.Key != ConsoleKey.E);
            
            
        }

        /// <summary>
        /// <para>Gibt ein Programmmenü zurück.</para>
        /// </summary>
        /// <param name="type"><para>1 = Hauptmenü</para>Bestimmt das zurück gegebene Menü</param>
        /// <returns></returns>
        public static string getMenu(int type)
        {
            string menu;
            switch (type) {
                case 1:
                    clearScreen();
                    menu =  "Anwendungsbeispiel der Klasse Auto\n" +
                            "----------------------------------\n\n" +
                            "Fahrzeug-Eigenschaften\n" +
                            "----------------------\n\n" +
                            "(1) Fahrzeug Eigenschaften anzeigen\n" +
                            "(2) Fahrzeug Eigenschaften bearbeiten\n\n" +
                            "Fahrzeug-Methoden\n" +
                            "-----------------\n\n" +
                            "(3) Fahrzeugtüren öffnen\n" +
                            "(4) Fahrzeugtüren schließen\n" +
                            "(5) Motor starten\n" +
                            "(6) Motor stoppen\n\n" +
                            "(E) Programm beenden\n\n";
                            return menu;
                case 2:
                    menu = "";
                    clearScreen();
                    return menu;
            }
            return "";
        }

        public static void clearScreen()
        {
            Console.Clear();
        }
    }
}
