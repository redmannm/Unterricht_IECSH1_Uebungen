using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek_WPF.Artikel
{
    class Dvd : ArtikelObj
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


        public override void Ausgabe()
        {
            
        }

        public override void Eingabe(int id)
        {

        }
    }
}
