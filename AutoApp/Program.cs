using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto;

namespace AutoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto.Auto fahrzeug1 = new Auto.Auto();

            Console.WriteLine(fahrzeug1.tuerOffen);
        }
    }
}
