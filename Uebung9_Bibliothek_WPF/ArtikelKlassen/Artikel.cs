using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek_WPF.Artikel
{
    //Artikel:
    //- ISBN
    //- Titel
    //- Kategorie
    //- Verlag
    //- Bestand

    //Eingabe() {

    //};

    public abstract class ArtikelObj
    {

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

        public abstract void Ausgabe();

        public abstract void Eingabe(int id);

    }
}
