using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoClass;
namespace AutoApp
{
    class AutoClassDemo
    {
        public Auto fahrzeug1 = new Auto(); // Fahrzeug erzeugen
        
        static void Main(string[] args)
        {
            AutoClassDemo thisApp = new AutoClassDemo();
            
            ConsoleKeyInfo menuKey;
            
            Console.Write(getMenu(1)); // Hauptmenü aufrufen
            
            do
            {
                menuKey = Console.ReadKey(true);
                
                //
                // Fahrzeug-Eigenschaften anzeigen
                //
                if (menuKey.Key == ConsoleKey.D1)
                {
                    Console.Write(getMenu(1));
                    getPkwConfig(thisApp.fahrzeug1);
                }

                //
                // Fahrzeug-Eigenschaften bearbeiten
                //
                if (menuKey.Key == ConsoleKey.D2)
                {
                    Console.Write(getMenu(1));
                    setPkwConfig(thisApp.fahrzeug1);
                    Console.Write(getMenu(1));
                    Console.WriteLine("Die Fahrzeug-Eigenschaften wurden erfolgreich bearbeitet.");
                }

                //
                // Fahrzeugtür öffnen
                //
                if (menuKey.Key == ConsoleKey.D3)
                {
                    if (thisApp.fahrzeug1.TuerStatus)
                    {
                        Console.Write(getMenu(1));
                        Console.WriteLine("Die Fahrzeugtür ist bereits geöfnet!");
                    }
                    else
                    {
                        thisApp.fahrzeug1.TuerAction();
                        Console.Write(getMenu(1));
                        Console.WriteLine("Die Fahrzeugtür wurde geöfnet!");
                    }
                }

                //
                // Fahrzeugtür schließen
                //
                if (menuKey.Key == ConsoleKey.D4)
                {
                    if (!thisApp.fahrzeug1.TuerStatus)
                    {
                        Console.Write(getMenu(1));
                        Console.WriteLine("Die Fahrzeugtür ist bereits geschloßen!");
                    }
                    else
                    {
                        thisApp.fahrzeug1.TuerAction();
                        Console.Write(getMenu(1));
                        Console.WriteLine("Die Fahrzeugtür wurde geschloßen!");
                    }
                }

                //
                // Motor starten
                //
                if (menuKey.Key == ConsoleKey.D5)
                {
                    if (thisApp.fahrzeug1.MotorStatus)
                    {
                        Console.Write(getMenu(1));
                        Console.WriteLine("Der Motor läuft bereits!");
                    }
                    else
                    {
                        thisApp.fahrzeug1.MotorAction();
                        Console.Write(getMenu(1));
                        Console.WriteLine("Der Motor wurde gestartet!");
                    }
                }

                //
                // Motor stoppen
                //
                if (menuKey.Key == ConsoleKey.D6)
                {
                    if (!thisApp.fahrzeug1.MotorStatus)
                    {
                        Console.Write(getMenu(1));
                        Console.WriteLine("Der Motor ist bereits aus!");
                    }
                    else
                    {
                        thisApp.fahrzeug1.MotorAction();
                        Console.Write(getMenu(1));
                        Console.WriteLine("Der Motor wurde gestopt!");
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
                case 1: // Hauptmenü
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
                case 2: // für ein eventuelles Submenü
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
        
        public static void getPkwConfig(Auto @fahrzeug)
        {
            Console.WriteLine("Aktuelle Fahrzeug-Eigenschaften");
            Console.WriteLine("-------------------------------\n");
            
            // Marke ausgeben
            if (@fahrzeug.Marke == null || @fahrzeug.Marke == "")
                Console.WriteLine("{0}{1}", "Marke:".PadRight(12), "Nicht gesetzt".PadLeft(15));
            else
                Console.WriteLine("{0}{1}", "Marke:".PadRight(12), @fahrzeug.Marke.PadLeft(15));

            // Modell ausgeben
            if (@fahrzeug.Modell == null || @fahrzeug.Modell == "")
                Console.WriteLine("{0}{1}", "Modell:".PadRight(12), "Nicht gesetzt".PadLeft(15));
            else
                Console.WriteLine("{0}{1}", "Modell:".PadRight(12), @fahrzeug.Modell.PadLeft(15));

            // Leistung ausgeben
            string kw = Convert.ToString(@fahrzeug.Leistung) + " KW";
            string ps = Convert.ToString(@fahrzeug.Leistung * 1.35962) + " PS";
            Console.WriteLine("{0}{1}", "Leistung:".PadRight(12), kw.PadLeft(15));
            Console.WriteLine("{0}{1}", "".PadRight(12), ps.PadLeft(15));

            // Kilometerstand ausgeben
            string km = Convert.ToString(@fahrzeug.KmStand) + " KM";
            Console.WriteLine("{0}{1}", "KM-Stand:".PadRight(12), km.PadLeft(15));

            // Farbe ausgeben
            if (@fahrzeug.Farbe == null)
                Console.WriteLine("{0}{1}", "Farbe:".PadRight(12), "Nicht gesetzt".PadLeft(15));
            else
                Console.WriteLine("{0}{1}", "Farbe:".PadRight(12), @fahrzeug.Farbe.PadLeft(15));

            // Baujahr ausgeben
            if (@fahrzeug.Baujahr.ToShortDateString() == "01.01.0001")
                Console.WriteLine("{0}{1}", "Baujahr:".PadRight(12), "Nicht gesetzt".PadLeft(15));
            else
                Console.WriteLine("{0}{1}", "Baujahr:".PadRight(12), Convert.ToString(@fahrzeug.Baujahr.Year).PadLeft(15));
        }

        public static void setPkwConfig(Auto @fahrzeug)
        {
            string tmp;
            Console.WriteLine("Fahrzeug-Eigenschaften bearbeiten");
            Console.WriteLine("---------------------------------\n");

            //
            // Marke eingeben
            //---------------
            Console.Write("Marke eingeben [" + @fahrzeug.Marke + "]: ");
            @fahrzeug.Marke = Console.ReadLine();

            //
            // Modell eingeben
            //----------------
            Console.Write("\nModell eingeben [" + @fahrzeug.Modell + "]: ");
            @fahrzeug.Modell = Console.ReadLine();

            //
            // Leistung eingeben
            //------------------
            Console.Write("\nLeistung in KW eingeben [" + @fahrzeug.Leistung.ToString() + "]: ");
            try
            {
                @fahrzeug.Leistung = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                @fahrzeug.Leistung = 0;
            }

            //
            // Kilometerstand eingeben
            //------------------------
            Console.Write("\nKM-Stand eingeben [" + @fahrzeug.KmStand.ToString() + "]: ");
            //tmp = Console.ReadLine();
            //if (tmp == "")
            //    @fahrzeug.KmStand = 0.0;
            //else
                try
                {
                    @fahrzeug.KmStand = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    @fahrzeug.KmStand = 0.0;
                }
                
            //
            // Farbe eingeben
            //---------------
            Console.Write("\nFarbe eingeben [" + @fahrzeug.Farbe + "]: ");
            @fahrzeug.Farbe = Console.ReadLine();

            //
            // Baujahr eingeben
            //-----------------
            if (@fahrzeug.Baujahr.Year.ToString() == "1")
                tmp = "";
            else
                tmp = @fahrzeug.Baujahr.Year.ToString();
            Console.WriteLine("\nBaujahr eingeben [" + tmp + "] ");
            Console.Write("Format: Nur Jahr (bsp. 1999): ");
            @fahrzeug.Baujahr = Convert.ToDateTime(Console.ReadLine() + ".01.01");
        }
    }
}
