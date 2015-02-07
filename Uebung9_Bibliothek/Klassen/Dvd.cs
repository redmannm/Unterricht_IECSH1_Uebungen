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

        string _isbn;
        public string Isbn
        {
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
            }
        }

        string _verlag;

        public string Verlag
        {
            get
            {
                return _verlag;
            }
            set
            {
                _verlag = value;
            }
        }

    }
}
