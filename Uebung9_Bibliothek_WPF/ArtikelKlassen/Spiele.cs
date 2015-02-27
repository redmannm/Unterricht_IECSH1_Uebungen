using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung9_Bibliothek_WPF.Artikel
{
    class Spiele : ArtikelObj
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


        public override void Ausgabe()
        {
            
        }

        public override void Eingabe(int id)
        {
            
        }
    }
}
