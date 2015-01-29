using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenVerwaltung
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string vorname;

        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }
        private DateTime gebDat;

        public DateTime GebDat
        {
            get { return gebDat; }
            set { gebDat = value; }
        }
        private int familienStand;

        public int FamilienStand
        {
            get { return familienStand; }
            set 
            {
                if ((value < 1) || (value > 3))
                {
                    Console.WriteLine("Nur zahlen von 1 bis 3 sind erlaubt!");
                }
                else
                {
                    familienStand = value;
                }
            }
        }
        private int anzKinder;

        public int AnzKinder
        {
            get { return anzKinder; }
            set { anzKinder = value; }
        }

        public Person()
        {
            
        }
    }
}
