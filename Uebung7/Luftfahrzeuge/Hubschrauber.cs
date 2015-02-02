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

        public Hubschrauber()
        {
            Gestartet = false;
            Eingabe();
        }

        public void Eingabe()
        {
            Console.WriteLine("Eigenschaften des Hubschraubers eingeben.\n" +
                              "-----------------------------------------\n");
            do
            {
                try
                {
                    Console.Write("Rotor-Durchmesser: ");
                    Rotor = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("{0}{1}", "Luftfahrzeugtyp:".PadRight(16), "Hubschrauber");
            Console.WriteLine("{0}{1}", "Spannweite:".PadRight(16), Rotor.ToString());
            Console.WriteLine("{0}{1}", "Hersteller:".PadRight(16), Hersteller);
            Console.WriteLine("{0}{1}", "Baujahr".PadRight(16), Baujahr.ToString());
            Console.WriteLine("");
        }

        //public void Starten()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
