using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek.Klassen
{
    //VerleihArtikel:
    //- ISBN
    //- Titel
    //- Kategorie
    //- Verlag
    //- Bestand

    //Eingabe() {

    //};
    class VerleihArtikel
    {
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

        string _titel;
        public string Titel
        {
            get
            {
                return _titel;
            }
            set
            {
                _titel = value;
            }
        }

        string _kategorie;
        public string Kategorie
        {
            get
            {
                return _kategorie;
            }
            set
            {
                _kategorie = value;
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

        int    _bestand;
        public int Bestand
        {
            get
            {
                return _bestand;
            }
            set
            {
                _bestand = value;
            }
        }

        //public abstract void 
    }
}
