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

        string _ean;

        public string Ean
        {
            get
            {
                return _ean;
            }
            set
            {
                _ean = value;
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

            if (Publisher.Length > 12)
                t2 = Publisher.Substring(0, 12);
            else
                t2 = Publisher;

            if (Kategorie.Length > 12)
                t3 = Kategorie.Substring(0, 12);
            else
                t3 = Kategorie;

            t4 = Bestand.ToString();
            t5 = Ean;

            string rowData = String.Format(" ║ {0} ║ {1} ║ {2} ║ {3} ║ {4} ║ {5} ║", t0.PadRight(8), t1.PadRight(15), t2.PadRight(15), t3.PadRight(15), t4.PadRight(8), t5.PadRight(18));

            return rowData;
        }

        public override void Eingabe()
        {
            throw new NotImplementedException();
        }
    }
}
