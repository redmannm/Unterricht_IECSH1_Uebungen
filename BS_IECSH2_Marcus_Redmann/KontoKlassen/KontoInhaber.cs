using System;
using System.Collections.Generic;
using System.Text;

namespace BS_IECSH2_Marcus_Redmann.Konten
{
    class KontoInhaber
    { // Mitarbeiter aktiviert / deaktiviert

        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        string _vorname;
        public string Vorname
        {
            get
            {
                return _vorname;
            }
            set
            {
                _vorname = value;
            }
        }

        DateTime _gebDat;
        public DateTime GebDat
        {
            get
            {
                return _gebDat;
            }
            set
            {
                _gebDat = value;
            }
        }

        string _strasse;
        public string Strasse
        {
            get
            {
                return _strasse;
            }
            set
            {
                _strasse = value;
            }
        }


        string _plz;
        public string Plz
        {
            get
            {
                return _plz;
            }
            set
            {
                _plz = value;
            }
        }

        string _ort;
        public string Ort
        {
            get
            {
                return _ort;
            }
            set
            {
                _ort = value;
            }
        }

    }
}
