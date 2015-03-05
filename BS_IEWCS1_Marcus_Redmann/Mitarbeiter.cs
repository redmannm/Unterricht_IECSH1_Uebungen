using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            get;
            set;
        }

        private string _vorname;
        public string Vorname
        {
            get;
            set;
        }

        private string _strasse;
        public string Strasse
        {
            get;
            set;
        }

        private string _hausnummer;
        public string Hausnummer
        {
            get;
            set;
        }

        private string _plz;
        public string Plz
        {
            get;
            set;
        }

        private string _ort;
        public string Ort
        {
            get;
            set;
        }

        private string _geburtsdatum;
        public string Geburtsdatum
        {
            get;
            set;
        }

        private int _alter;
        public int Alter
        {
            get;
            set;
        }

        private string _tel;
        public string Tel
        {
            get;
            set;
        }

        private string _konfession;
        public string Konfession
        {
            get;
            set;
        }

        private LohnStKlasse _lohnsteuerKlasse;
        public LohnStKlasse LohnsteuerKlasse
        {
            get;
            set;
        }

        private int _kinder;
        public int Kinder
        {
            get;
            set;
        }

        private double _bruttoGehalt;
        public double BruttoGehalt
        {
            get;
            set;
        }

        private double _nettoGehalt;
        public double NettoGehalt
        {
            get;
            set;
        }
    }
}
