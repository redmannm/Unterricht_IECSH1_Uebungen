using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung7
{
    public abstract class Luftfahrzeug
    {
        private int baujahr;
        public int Baujahr
        {
            get { return baujahr; }
            set { baujahr = value; }
        }

        private string hersteller;
        public string Hersteller
        {
            get { return hersteller; }
            set { hersteller = value; }
        }

        private bool gestartet;
        public bool Gestartet
        {
            get { return gestartet; }
            set { gestartet = value; }
        }

        public abstract void Ausgabe();
       
        public virtual void StartenStoppen()
        {
            if (Gestartet == true)
                Gestartet = false;
            else
                Gestartet = true;
        }
    }
}
