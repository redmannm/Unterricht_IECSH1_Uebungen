using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung8.Klassen
{
    class Mitarbeiter : Personen
    {
        

        int steuerKlasse;
        public int SteuerKlasse
        {
            get
            {
                return steuerKlasse;
            }
            set
            {
                steuerKlasse = value;
            }
        }

        int kinder;
        public int Kinder
        {
            get
            {
                return kinder;
            }
            set
            {
                kinder = value;
            }
        }

        double bruttoLohn;
        public double BruttoLohn
        {
            get
            {
                return bruttoLohn;
            }
            set
            {
                bruttoLohn = value;
            }
        }
    }
}
