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
        private int leistung;
        /// <summary>
        /// Leistung des Fahrzeugs
        /// </summary>
        public int Leistung
        {
            get { return leistung; }
            set
            {
                
            }
        }
        public double kmStand;
        public string farbe;
        public DateTime baujahr;
        public bool tuerStatus;
        public bool motorStatus;

        public Auto()
        {
            this.tuerStatus = false;
            this.motorStatus = false;
        }

        /// <summary>
        /// Gibt die aktuellen Fahrzeug-Eigenschaften aus.
        /// </summary>

        /// <summary>
        /// Fahrzeug-Eigenschaften bearbeiten
        /// </summary>
        public void TuerAction()
        {
            if (this.tuerStatus == true)
            {
                this.tuerStatus = false;
            }
            else
            {
                this.tuerStatus = true;
            }

        }

        public void MotorAction()
        {
            if (this.motorStatus == true)
            {
                this.motorStatus = false;
            }
            else
            {
                this.motorStatus = true;
            }
        }
    }
}
