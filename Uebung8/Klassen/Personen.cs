using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung8.Klassen
{
    class Personen
    {
        bool status; // Mitarbeiter aktiviert / deaktiviert
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        string vorname;
        public string Vorname
        {
            get
            {
                return vorname;
            }
            set
            {
                vorname = value;
            }
        }

        string strasse;
        public string Strasse
        {
            get
            {
                return strasse;
            }
            set
            {
                strasse = value;
            }
        }

        string hausnummer;
        public string Hausnummer
        {
            get
            {
                return hausnummer;
            }
            set
            {
                hausnummer = value;
            }
        }

        string plz;
        public string Plz
        {
            get
            {
                return plz;
            }
            set
            {
                plz = value;
            }
        }

        string ort;
        public string Ort
        {
            get
            {
                return ort;
            }
            set
            {
                ort = value;
            }
        }

        DateTime gebDat;
        public DateTime GebDat
        {
            get
            {
                return gebDat;
            }
            set
            {
                gebDat = value;
            }
        }

        string konfession;
        public string Konfession
        {
            get
            {
                return konfession;
            }
            set
            {
                konfession = value;
            }
        }
    }
}
