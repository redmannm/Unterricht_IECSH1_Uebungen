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


        public override string[] Ausgabe()
        {
            string[] Eigenschaften;
            return Eigenschaften = new string[7] { Id.ToString(), Titel, Laufzeit.ToShortTimeString(), Verlag, Kategorie, Bestand.ToString(), Isbn };
        }
    }
}
