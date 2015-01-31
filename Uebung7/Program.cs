using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung7
{
    class Program
    {
        private const bool DEBUG = true;
    
        static void Main(string[] args)
        {
            Console.Write("Anzahl der Luftfahrezeuge: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());
            Luftfahrzeug[] arr_Luftfahrzeuge = new Luftfahrzeug[anzahl];

            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine("\nWas möchtest du anlegen");
                Console.WriteLine("F -  Flugzeug");
                Console.WriteLine("H -  Hubschrauber");
                Console.WriteLine("Z -  Zeppelin\n");

                Console.Write("Ihre Auswahl:");
                string auswahl = Console.ReadLine().ToUpper();

                switch (auswahl)
                {
                    case "F": arr_Luftfahrzeuge[i] = new Flugzeug();
                        break;

                    case "H":
                        arr_Luftfahrzeuge[i] = new Hubschrauber();
                        break;

                    case "Z":
                        arr_Luftfahrzeuge[i] = new Zeppelin();
                        break;
                }
            }


            Console.WriteLine("Ihre Eingaben waren:");
            foreach (Luftfahrzeug item in arr_Luftfahrzeuge)
            {
                item.Ausgabe();
            }
            
            Console.ReadLine();
        }
        //public static string getMenu()
        //{

        //}
    }
}