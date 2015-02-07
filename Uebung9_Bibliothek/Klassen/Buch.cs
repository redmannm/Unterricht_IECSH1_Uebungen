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
