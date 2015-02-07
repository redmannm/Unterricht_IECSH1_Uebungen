using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek.Klassen
{
    class Spiele : VerleihArtikel
    {
        string _publisher;
        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }

        string _ean;

        public string Ean
        {
            get
            {
                return _ean;
            }
            set
            {
                _ean = value;
            }
        }

    }
}
