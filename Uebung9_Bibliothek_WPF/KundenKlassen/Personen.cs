using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung9_Bibliothek_WPF.Kunden
{
    class Person
    { // Mitarbeiter aktiviert / deaktiviert

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

    }
}
