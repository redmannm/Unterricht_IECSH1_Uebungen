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

        string _isbn;

        public string Isbn
        {
            get
            {
                return _isbn;
            }
            //set
            //{
            //    _isbn = value;
            //}
        }
    }
}
