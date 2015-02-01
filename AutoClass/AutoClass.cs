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
        //-----------------//
        // Abschnitt Marke //
        //-----------------//
        private string marke; // Privates Feld Fahrzeug Marke
        /// <summary>
        /// Marke des Fahrzeugs
        /// </summary>
        public string Marke
        {
            get { return marke; }
            set
            {
                // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird der Wert auf
                // aktuellen Wert belassen
                if (value == "")
                    marke = marke;
                else
                    marke = value;
            }
        }

        //------------------//
        // Abschnitt Modell //
        //------------------//
        private string modell; // Privates Feld Fahrzeug Modell
        /// <summary>
        /// Modell des Fahrzeugs
        /// </summary>
        public string Modell
        {
            get { return modell; }
            set 
            {
                // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird der Wert auf
                // aktuellen Wert belassen
                if (value == "")
                    modell = modell;
                else
                    modell = value;
            }
        }

        //--------------------//
        // Abschnitt Leistung //
        //--------------------//
        private int leistung; // Privates Feld Fahrzeug Leistung
        /// <summary>
        /// Accessoren Leistung des Fahrzeugs
        /// </summary>
        public int Leistung
        {
            get { return leistung; }
            set
            {
                bool leistungFormatErr = false;   // Fehler Flag für Formatfehler setzen
                bool leistungOverflowErr = false; // Fehler Flag für überlauf setzen
                while (true)
                {
                    try // Anweisungsblock versuchen abzuarbeiten
                    {
                        // Fehler Meldungen
                        if (leistungFormatErr)
                            Console.WriteLine("Falsches Format eingegeben. Bitte nur Ganzzahlen eingeben.");
                        if (leistungOverflowErr)
                            Console.WriteLine("Respekt! Mehr als 2,147 Milliarden KW Leistung.");
                        if (value.ToString() == "")
                            leistung = leistung;
                        else
                            leistung = value;
                        break;
                    }
                    catch (FormatException) // Formatierungsfehler abfangen
                    {
                        leistungFormatErr = true;
                    }
                    catch (OverflowException) // Übergroße Werte abfangen
                    {
                        leistungOverflowErr = true;
                    }
                }
            }
        }
        
        //--------------------------//
        // Abschnitt Kilometerstand //
        //--------------------------//
        private double kmStand;
        /// <summary>
        /// Accessoren KmStand des Fahrzeugs
        /// </summary>
        public double KmStand
        {
            get { return kmStand; }
            set
            {
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

                        // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird 
                        // Kilometerstand auf aktuellen Wert belassen
                        if (Convert.ToString(value) == "")
                            kmStand = kmStand;
                        else
                            kmStand = Convert.ToDouble(value);
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
            }
        }

        //-----------------//
        // Abschnitt Farbe //
        //-----------------//
        private string farbe;
        /// <summary>
        /// Accessoren Farbe des Fahrzeugs
        /// </summary>
        public string Farbe
        {
            get { return farbe; }
            set
            {
                // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird der Wert auf
                // aktuellen Wert belassen
                if (value == "")
                    farbe = farbe;
                else
                    farbe = value;
            }
        }

        //-------------------//
        // Abschnitt Baujahr //
        //-------------------//
        private DateTime baujahr;
        /// <summary>
        /// Accessoren Baujahr des Fahrzeugs
        /// </summary>
        public DateTime Baujahr
        {
            get { return baujahr; }
            set
            {
                bool baujahrErr = false; // Fehler Flag für Formatfehler setzen

                // Schleife solange ausführen bis Eingaben korrekt sind
                while (true)
                {
                    try // Anweisungsblock versuchen abzuarbeiten
                    {
                        // Fehler Meldungen
                        if (baujahrErr)
                            Console.WriteLine("Falsches Format eingegeben. Bitte korregieren.");

                        // Wenn bei Abfrage ohne Eingabe Enter gedrückt wird 
                        // Baujahr auf aktuellen Wert belassen
                        if (value.Year.ToString() == "0001")
                            baujahr = baujahr;
                        else
                            baujahr = value;
                        break; // Schleife beenden
                    }
                    catch (FormatException) // Formatierungsfehler abfangen
                    {
                        try // Anweisungsblock versuchen abzuarbeiten
                        {
                            baujahr = value;
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

        //----------------------//
        // Abschnitt TuerStatus //
        //----------------------//
        private bool tuerStatus;
        /// <summary>
        /// Accessoren TuerStatus des Fahrzeugs
        /// </summary>
        public bool TuerStatus
        {
            get { return tuerStatus; }
            set { tuerStatus = value; }
        }
        
        //--------------------------------------//
        // Accessoren MotorStatus des Fahrzeugs //
        //--------------------------------------//
        private bool motorStatus;
        /// <summary>
        /// Accessoren MotorStatus des Fahrzeugs
        /// </summary>
        public bool MotorStatus
        {
            get { return motorStatus; }
            set { motorStatus = value; }
        }

        /// <summary>
        /// Konstruktor der Klasse Auto
        /// </summary>
        public Auto()
        {
            this.tuerStatus = false;
            this.motorStatus = false;
        }

        /// <summary>
        /// TuerAction Methode zum öffnen und schließen der Fahrzeug-Türen
        /// </summary>
        public void TuerAction()
        {
            if (tuerStatus == true)
            {
                tuerStatus = false;
            }
            else
            {
                tuerStatus = true;
            }

        }

        /// <summary>
        /// MotorAction Methode zum starten und stoppen des Motors
        /// </summary>
        public void MotorAction()
        {
            if (motorStatus == true)
            {
                motorStatus = false;
            }
            else
            {
                motorStatus = true;
            }
        }
    }
}
