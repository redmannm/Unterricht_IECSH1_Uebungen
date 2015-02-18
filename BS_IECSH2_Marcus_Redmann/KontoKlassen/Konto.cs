using System;
using System.Collections.Generic;
using System.Text;

namespace BS_IECSH2_Marcus_Redmann.Konten
{
    public abstract class Konto
    {
        private string _kontoInhaber;
        public string KontoInhaber
        {
            get
            {
                return _kontoInhaber;
            }
            set
            {
                _kontoInhaber = value;
            }
        }

        private string _kontoNummer;
        public string KontoNummer
        {
            get
            {
                return _kontoNummer;
            }
            set
            {
                _kontoNummer = value;
            }
        }

        private double _kontoStand;
        public double KontoStand
        {
            get
            {
                return _kontoStand;
            }
            set
            {
                _kontoStand = value;
            }
        }

        public Konto()
        {
            KontoStand = 0;
        }

        public abstract void Abbuchen(double _betrag);

        public abstract void Einzahlen(double _betrag);
    }
}
