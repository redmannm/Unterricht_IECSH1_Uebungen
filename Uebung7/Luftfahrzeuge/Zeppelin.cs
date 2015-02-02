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
            Console.WriteLine("{0}{1}", "Luftfahrzeugtyp:".PadRight(17), "Zeppelin");
            Console.WriteLine("{0}{1}", "Gasvolumen:".PadRight(17), Gasvolumen.ToString());
            Console.WriteLine("{0}{1}", "Hersteller:".PadRight(17), Hersteller);
            Console.WriteLine("{0}{1}", "Baujahr".PadRight(17), Baujahr.ToString());
            Console.WriteLine("");
        }

        //public void StartenStoppen()
        //{
            
        //}
    }
}

