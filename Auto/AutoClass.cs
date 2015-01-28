using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClass
{
    // Erstellen Sie ein Klasse mit deren Hilfe Sie ein PKW in Ihrer Anwendung erstellen können.
    //
    // Ein PKW soll folgende Eigenschaften und Zustände haben:
    //
    // - Marke;
    // - Model;
    // - Leistung;
    // - Km-Stand;
    // - Farbe;
    // - Baujahr;
    // - Tür offen;
    // - Motor gestartet;
    //
    // Für die genannten Eigenschaften und Zustände wählen Sie geeignete Datentypen.
    // Der PKW soll folgendes können:
    //
    // - Tür öffnen
    // - Motor starten
    // Zustandswechsel ändern der Zustände Tür offen/Motor gestartet über eine entsprechende Funktion.

    //Alle Eigenschaften sollen sich ausgeben lassen und auch ob der Motor läuft bzw. ob Türen geöffnet sind.
    public class Auto
    {
        public string marke;
        public string modell;
        public int leistung;
        public double kmStand;
        public string farbe;
        public DateTime baujahr;
        public bool tuerOffen;
        public bool motorAn;

        public Auto()
        {
            this.tuerOffen = false;
            this.motorAn = false;
        }
        
        /// <summary>
        /// Gibt die aktuellen Fahrzeug-Eigenschaften aus.
        /// </summary>
        public void getPkwConfig()
        {
            Console.WriteLine("Aktuelle Fahrzeug-Eigenschaften");
            Console.WriteLine("-------------------------------\n");
            
            // Marke ausgeben
            if (this.marke == null || this.marke == "")
                Console.WriteLine("{0}{1}", "Marke:".PadRight(12), "Nicht gesetzt".PadLeft(15));
            else
                Console.WriteLine("{0}{1}", "Marke:".PadRight(12), this.marke.PadLeft(15));

            // Modell ausgeben
            if (this.modell == null || this.modell == "")
                Console.WriteLine("{0}{1}", "Modell:".PadRight(12), "Nicht gesetzt".PadLeft(15));
            else
                Console.WriteLine("{0}{1}", "Modell:".PadRight(12), this.modell.PadLeft(15));

            // Leistung ausgeben
            string kw = Convert.ToString(this.leistung) + " KW";
            string ps = Convert.ToString(this.leistung * 1.35962) + " PS";
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

        /// <summary>
        /// Fahrzeug-Eigenschaften bearbeiten
        /// </summary>
        public void setPkwConfig()
        {
            string tmp;
            Console.WriteLine("Fahrzeug-Eigenschaften bearbeiten");
            Console.WriteLine("---------------------------------\n");

            //
            // Marke eingeben
            //---------------
            
            // Eingabe Meldung
            Console.Write("Marke eingeben [" + this.marke + "]: ");

            // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird Leistung auf
            // aktuellen Wert belassen
            tmp = Console.ReadLine();
            if (tmp == "")
                this.marke = this.marke;
            else
                this.marke = tmp;

            //
            // Modell eingeben
            //----------------
            
            // Eingabe Meldung
            Console.Write("Modell eingeben [" + this.modell + "]: ");

            // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird Modell auf
            // aktuellen Wert belassen
            tmp = Console.ReadLine();
            if (tmp == "")
                this.modell = this.modell;
            else
                this.modell = tmp;
            
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
                    Console.Write("Leistung in KW eingeben [" + this.leistung.ToString() + "]: ");
                    
                    // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird
                    // Leistung auf aktuellen Wert belassen
                    tmp = Console.ReadLine();
                    if (tmp == "")
                        this.leistung = this.leistung;
                    else
                        this.leistung = Convert.ToInt32(tmp);
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
                    Console.Write("KM-Stand eingeben [" + this.kmStand.ToString() + "]: ");

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
            Console.Write("Farbe eingeben [" + this.farbe + "]: ");

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
                    Console.WriteLine("Baujahr eingeben [" + this.baujahr.ToShortDateString() + "] ");
                    Console.WriteLine("Format: Nur Jahr (01.01.JJJJ)");
                    Console.WriteLine("{0}{1}","".PadRight(8), "Komplettes Datum (DD.MM.JJJJ)");

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
        public void TuerAction()
        {
            if (this.tuerOffen == true)
            {
                this.tuerOffen = false;
            }
            else
            {
                this.tuerOffen = true;
            }

        }

        public void MotorAction()
        {
            if (this.motorAn == true)
            {
                this.motorAn = false;
            }
            else
            {
                this.motorAn = true;
            }
        }
    }
}
