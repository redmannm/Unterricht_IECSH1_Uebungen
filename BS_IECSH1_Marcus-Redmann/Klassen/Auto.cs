using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermietung.Klassen
{
    class Auto
    {
        string _hersteller;
        public string Hersteller
        {
            get
            {
                return _hersteller;
            }
            set
            {
                _hersteller = value;
            }
        }

        string _modell;
        public string Modell
        {
            get
            {
                return _modell;
            }
            set
            {
                _modell = value;
            }
        }

        string _typ;
        public string Typ
        {
            get
            {
                return _typ;
            }
            set
            {
                _typ = value;
            }
        }

        string _kennzeichen;
        public string Kennzeichen
        {
            get
            {
                return _kennzeichen;
            }
            set
            {
                _kennzeichen = value;
            }
        }

        int _leistung;
        public int Leistung
        {
            get
            {
                return _leistung;
            }
            set
            {
                _leistung = value;
            }
        }

        double _kilometerstand;
        public double Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                _kilometerstand = value;
            }
        }

        bool _statusVermietet;
        public bool StatusVermietet
        {
            get
            {
                return _statusVermietet;
            }
            set
            {
                _statusVermietet = value;
            }
        }

        double _mietpreis;
        public double Mietpreis
        {
            get
            {
                return _mietpreis;
            }
            set
            {
                _mietpreis = value;
            }
        }

        public Auto()
        {
            StatusVermietet = false;
        }
    }
}
