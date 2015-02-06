using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek.Klassen
{
    class Buch : VerleihArtikel
    {
        string _author;

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
    }
}
