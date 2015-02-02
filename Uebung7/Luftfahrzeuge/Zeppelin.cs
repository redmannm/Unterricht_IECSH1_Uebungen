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

        public Zeppelin()
        {
            Gestartet = false;
            Eingabe();
        }

        public void Eingabe()
        {
            Console.WriteLine("Eigenschaften des Zeppelins eingeben.\n" +
                              "-------------------------------------\n");
            do
            {
                try
                {
                    Console.Write("Gasvolumen: ");
                    Gasvolumen = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nBitte geben Sie nur Ganzzahlen ein.\n");
                }
            } while (true);

            Console.Write("Hersteller: ");
            Hersteller = Console.ReadLine();

            do
            {
                try
                {
                    Console.Write("Baujahr: ");
                    Baujahr = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nBitte geben Sie nur Ganzzahlen ein.\n");
                }
            } while (true);
        }

        public override void Ausgabe()
        {

        }

        //public void Starten()
        //{
            
        //}
    }
}

