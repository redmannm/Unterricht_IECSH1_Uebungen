using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoClass;

namespace AutoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto fahrzeug1 = new Auto();

            Console.WriteLine(fahrzeug1.tuerOffen.ToString());
            
            Console.ReadLine();
        }
        public string getMenu()
        {
            clearScreen();
            string menu = "Anwendungsbeispiel der Klasse Auto\n" +
                          "----------------------------------\n" +
                          ;

            return menu;
        }

        public void clearScreen()
        {
            Console.Clear();
        }
    }
}
