using System;
using System.Collections.Generic;
using System.Text;

namespace BS_IECSH2_Marcus_Redmann.Konten
{
    public class Buchungsliste
    {
        private DateTime _datum;

        public DateTime Datum
        {
            get
            {
                return _datum;
            }
            set
            {
                _datum = value;
            }
        }
        private int _verwendungszweck;

        public int Verwendungszweck
        {
            get
            {
                return _verwendungszweck;
            }
            set
            {
                _verwendungszweck = value;
            }
        }
        private int _umsatz;

        public int Umsatz
        {
            get
            {
                return _umsatz;
            }
            set
            {
                _umsatz = value;
            }
        }
    }
}
