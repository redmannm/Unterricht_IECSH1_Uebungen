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
        public string   marke;
        public string   modell;
        public int      leistung;
        public int      kmStand;
        public string   farbe;
        public DateTime baujahr;
        public bool     tuerOffen;
        public bool     motorAn;

        public Auto()
        {
            this.tuerOffen = false;
            this.motorAn = false;
        }
        public void TuerOeffnen()
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

        public void MotorStarten()
        {

        }
    }
}
