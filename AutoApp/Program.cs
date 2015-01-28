using AutoClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    if (thisApp.fahrzeug1.tuerStatus)
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
                    if (!thisApp.fahrzeug1.tuerStatus)
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
                    if (thisApp.fahrzeug1.motorStatus)
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
                    if (!thisApp.fahrzeug1.motorStatus)
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
            string kw = Convert.ToString(this.Leistung) + " KW";
            string ps = Convert.ToString(this.Leistung * 1.35962) + " PS";
            Console.WriteLine("{0}{1}", "Leistung:".PadRight(12), kw.PadLeft(15));
            Console.WriteLine("{0}{1}", "".PadRight(12), ps.PadLeft(15));

            // Kilometerstand ausgeben
            string km = Convert.ToString(this.kmStand) + " KM";
            Console.WriteLine("{0}{1}", "KM-Stand:".PadRight(12), km.PadLeft(15));

            // Farbe ausgeben
            if (this.farbe == null)
                Console.WriteLine("{0}{1}", "Farbe:".PadRight(12), "Nicht gesetzt".PadLeft(15));
            else
                Console.WriteLine("{0}{1}", "Farbe:".PadRight(12), this.farbe.PadLeft(15));

            // Baujahr ausgeben
            if (this.baujahr.ToShortDateString() == "01.01.0001")
                Console.WriteLine("{0}{1}", "Baujahr:".PadRight(12), "Nicht gesetzt".PadLeft(15));
            else
                Console.WriteLine("{0}{1}", "Baujahr:".PadRight(12), Convert.ToString(this.baujahr.ToShortDateString()).PadLeft(15));
        }

        public static void setPkwConfig(Auto @fahrzeug)
        {
            string tmp;
            Console.WriteLine("Fahrzeug-Eigenschaften bearbeiten");
            Console.WriteLine("---------------------------------\n");

            //
            // Marke eingeben
            //---------------

            Console.Write("Marke eingeben [" + Marke + "]: ");
            Marke = Console.ReadLine();

            //
            // Modell eingeben
            //----------------

            Console.Write("\nModell eingeben [" + Modell + "]: ");
            Modell = Console.ReadLine();

            //
            // Leistung eingeben
            //------------------
            bool leistungFormatErr = false;   // Fehler Flag für Formatfehler setzen
            bool leistungOverflowErr = false; // Fehler Flag für überlauf setzen

            // Schleife solange ausführen bis Eingaben korrekt sind
            while (true)
            {
                try // Anweisungsblock versuchen abzuarbeiten
                {
                    // Fehler Meldungen
                    if (leistungFormatErr)
                        Console.WriteLine("Falsches Format eingegeben. Bitte nur Ganzzahlen eingeben.");
                    if (leistungOverflowErr)
                        Console.WriteLine("Respekt! Mehr als 2,147 Milliarden KW Leistung.");

                    // Eingabe Meldung
                    Console.Write("\nLeistung in KW eingeben [" + this.Leistung.ToString() + "]: ");

                    // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird
                    // Leistung auf aktuellen Wert belassen
                    tmp = Console.ReadLine();
                    if (tmp == "")
                        this.Leistung = this.Leistung;
                    else
                        this.Leistung = Convert.ToInt32(tmp);
                    break; // Schleife beenden
                }
                catch (FormatException) // Formatierungsfehler abfangen
                {
                    leistungFormatErr = true;
                }
                catch (OverflowException) // Übergroße Werte abfangen
                {
                    leistungOverflowErr = true;
                }
            } // Schleifen ende

            //
            // Kilometerstand eingeben
            //------------------------
            bool kmStandFormatErr = false;   // Fehler Flag für Formatfehler setzen
            bool kmStandOverflowErr = false; // Fehler Flag für überlauf setzen

            // Schleife solange ausführen bis Eingaben korrekt sind
            while (true)
            {
                try // Anweisungsblock versuchen abzuarbeiten
                {
                    // Fehler Meldungen
                    if (kmStandFormatErr)
                        Console.WriteLine("Falsches Format eingegeben. Bitte Ganzzahl oder Fließkommazahl eingeben.");
                    if (kmStandOverflowErr)
                        Console.WriteLine("Wert zu groß!");

                    // Eingabe Meldung
                    Console.Write("\nKM-Stand eingeben [" + this.kmStand.ToString() + "]: ");

                    // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird 
                    // Kilometerstand auf aktuellen Wert belassen
                    tmp = Console.ReadLine();
                    if (tmp == "")
                        this.kmStand = this.kmStand;
                    else
                        this.kmStand = Convert.ToDouble(tmp);
                    break; // Schleife beende
                }
                catch (FormatException) // Formatierungsfehler abfangen
                {
                    kmStandFormatErr = true;
                }
                catch (OverflowException) // Übergroße Werte abfangen
                {
                    kmStandOverflowErr = true;
                }
            } // Schleifen ende

            //
            // Farbe eingeben
            //---------------

            // Eingabe Meldung
            Console.Write("\nFarbe eingeben [" + this.farbe + "]: ");

            // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird Farbe auf
            // aktuellen Wert belassen
            tmp = Console.ReadLine();
            if (tmp == "")
                this.farbe = this.farbe;
            else
                this.farbe = tmp;

            //
            // Baujahr eingeben
            //-----------------
            bool baujahrErr = false; // Fehler Flag für Formatfehler setzen

            // Schleife solange ausführen bis Eingaben korrekt sind
            while (true)
            {
                try // Anweisungsblock versuchen abzuarbeiten
                {
                    // Fehler Meldungen
                    if (baujahrErr)
                        Console.WriteLine("Falsches Format eingegeben. Bitte korregieren.");

                    // Eingabe Meldungen
                    if (this.baujahr.ToShortDateString() == "01.01.0001")
                        tmp = "Nicht gesezt";
                    else
                        tmp = this.baujahr.ToShortDateString();
                    Console.WriteLine("\nBaujahr eingeben [" + tmp + "] ");
                    Console.WriteLine("Format: Nur Jahr (bsp. 1999)");
                    Console.WriteLine("{0}{1}", "".PadRight(8), "Komplettes Datum (bsp. 11.10.1974)");

                    // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird 
                    // Baujahr auf aktuellen Wert belassen
                    tmp = Console.ReadLine();
                    if (tmp == "")
                        this.baujahr = this.baujahr;
                    else
                        this.baujahr = DateTime.Parse(tmp + ".01.01");
                    break; // Schleife beenden
                }
                catch (FormatException) // Formatierungsfehler abfangen
                {
                    try // Anweisungsblock versuchen abzuarbeiten
                    {
                        this.baujahr = DateTime.Parse(tmp);
                        break;
                    }
                    catch (FormatException) // Formatierungsfehler abfangen
                    {
                        baujahrErr = true;
                    }
                    baujahrErr = true;
                }
            } // Schleifen ende
        }

        


    }
}
