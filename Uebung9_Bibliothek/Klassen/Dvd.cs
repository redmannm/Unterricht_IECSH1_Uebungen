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


        public override string Ausgabe()
        {
            string t0, t1, t2, t3, t4, t5, t6;

            // Art.-Id.
            t0 = Id.ToString();

            // Title
            if (Titel.Length > 12)
                t1 = Titel.Substring(0, 12) + "...";
            else
                t1 = Titel;

            if (Verlag.Length > 12)
                t2 = Verlag.Substring(0, 12);
            else
                t2 = Verlag;

            t3 = Laufzeit.ToShortTimeString();
            
            if (Kategorie.Length > 12)
                t4 = Kategorie.Substring(0, 12);
            else
                t4 = Kategorie;

            t5 = Bestand.ToString();
            t6 = Isbn;

            string rowData = String.Format(" ║ {0} ║ {1} ║ {2} ║ {3} ║ {4} ║ {5} ║ {6} ║", t0.PadRight(8), t1.PadRight(15), t2.PadRight(15), t3.PadRight(15), t4.PadRight(15), t5.PadRight(8), t6.PadRight(18));
            
            return rowData;
        }

        public override void Eingabe(List<VerleihArtikel> _artikel_collection)
        {
            throw new NotImplementedException();
        }
    }
}
