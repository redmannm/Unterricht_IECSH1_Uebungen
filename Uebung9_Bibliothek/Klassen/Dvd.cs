using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek.Klassen
{
    class Dvd : VerleihArtikel
    {
        DateTime _laufzeit;

        public DateTime Laufzeit
        {
            get
            {
                return _laufzeit;
            }
            set
            {
                _laufzeit = value;
            }
        }
    }
}
