using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_IEWCS1_Marcus_Redmann
{
    public class Mitarbeiter : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

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
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Vorname"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Strasse"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Hausnummer"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Plz"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Ort"));
            }
        }

        private DateTime? _geburtsdatum;
        public DateTime? Geburtsdatum
        {
            get
            {
                return _geburtsdatum;
            }
            set
            {
                _geburtsdatum = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Geburtsdatum"));
            }
        }

        private int _alter;
        public int Alter
        {
            get
            {
                return _alter;
            }
            set
            {
                _alter = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Alter"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Tel"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Konfession"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("LohnsteuerKlasse"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("Kinder"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("BruttoGehalt"));
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
                OnPropertyChanged(new PropertyChangedEventArgs("NettoGehalt"));
            }
        }
    }
}
