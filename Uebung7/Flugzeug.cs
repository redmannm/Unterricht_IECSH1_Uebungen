using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebung7
{
    public class Flugzeug : Luftfahrzeug
    {
        private int spannweite;

        public int Spannweite
        {
            get { return spannweite; }
            set { spannweite = value; }
        }

        public Flugzeug()
        {
            Eingabe();
        }

        public void Eingabe()
        {
            Console.Write("Spannweite: ");
            this.Spannweite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hersteller: ");
            Hersteller = Console.ReadLine();
            Console.WriteLine("Baujahr: ");
            Baujahr = Convert.ToInt32(Console.ReadLine());
        }

        public void Ausgabe()
        {
            Console.WriteLine(this.Spannweite.ToString());
            Console.WriteLine(Hersteller);
            Console.WriteLine(Baujahr.ToString());
        }

        public new void Starten()
        {
            Console.WriteLine("Flugzeug ist gestartet");
        }
    }




}
