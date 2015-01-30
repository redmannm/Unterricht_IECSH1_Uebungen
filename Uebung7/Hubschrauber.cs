using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung7
{
    public class Hubschrauber : Luftfahrzeug
    {
        private int rotor;

        public int Rotor
        {
            get { return rotor; }
            set { rotor = value; }
        }

        public override void Ausgabe()
        {
            throw new System.NotImplementedException();
        }

        public void Eingabe()
        {
            throw new System.NotImplementedException();
        }

        public void Starten()
        {
            throw new System.NotImplementedException();
        }
    }
}
