using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung7
{
    public class Zeppelin : Luftfahrzeug
    {
        private int gasvolumen;

        public int Gasvolumen
        {
            get { return gasvolumen; }
            set { gasvolumen = value; }
        }

        public override void Ausgabe()
        {

        }

        public void Eingabe()
        {

        }

        public void Starten()
        {
            throw new System.NotImplementedException();
        }
    }
}

