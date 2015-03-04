using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_IEWCS1_Marcus_Redmann
{
    class Mitarbeiter
    {
        private string _name;

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
        private string _vorname;

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
        private string _strasse;

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
        private string _hausnummer;

        public string Hausnummer
        {
            get
            {
                return _hausnummer;
            }
            set
            {
                _hausnummer = value;
            }
        }
        private string _plz;

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
        private string _ort;

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
        private string _geburtsdatum;

        public string Geburtsdatum
        {
            get
            {
                return _geburtsdatum;
            }
            set
            {
                _geburtsdatum = value;
            }
        }
        private string _tel;

        public string Tel
        {
            get
            {
                return _tel;
            }
            set
            {
                _tel = value;
            }
        }
        private string _konfession;

        public string Konfession
        {
            get
            {
                return _konfession;
            }
            set
            {
                _konfession = value;
            }
        }
        private LohnStKlasse _lohnsteuerKlasse;

        public LohnStKlasse LohnsteuerKlasse
        {
            get
            {
                return _lohnsteuerKlasse;
            }
            set
            {
                _lohnsteuerKlasse = value;
            }
        }
        private int _kinder;

        public int Kinder
        {
            get
            {
                return _kinder;
            }
            set
            {
                _kinder = value;
            }
        }
        private double _bruttoGehalt;

        public double BruttoGehalt
        {
            get
            {
                return _bruttoGehalt;
            }
            set
            {
                _bruttoGehalt = value;
            }
        }
        private double _nettoGehalt;

        public double NettoGehalt
        {
            get
            {
                return _nettoGehalt;
            }
            set
            {
                _nettoGehalt = value;
            }
        }


    }
}
