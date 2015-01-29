using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenVerwaltung
{
    class PersonenListManager
    {
        List<Person> personenCollection = new List<Person>();

        

        public PersonenListManager()
        {

        }
        public void getTestPersonenList()
        {
            Random random = new Random();
            for (int i = 0; i < 25; i++)
			{
			Person personItem = new Person();
            personItem.Name = "Nachname_" + i;
            personItem.Vorname = "Vorname_" + i;
            personItem.GebDat = Convert.ToDateTime("11.10.74");
            personItem.FamilienStand = random.Next(1, 3);
            personItem.AnzKinder = random.Next(0, 4);
            personenCollection.Add(personItem);
            personItem = null;
			}
            string strFamStand = "";
            Console.Write("\n\nPersonen auflisten\n" +
                         "-------------------\n\n\n");
            Console.Write("| Nr. |     Name      |    Vorname    |  Geb. Dat. |  Fam.-Stand | Anz. Kinder |\n" +
                          "|-----|---------------|---------------|------------|-------------|-------------|\n");

            int i = 0;
            int count = 0;
            personenCollection.GetRange
            foreach (Person item in personenCollection)
            {
                if (item.FamilienStand == 1)
                    strFamStand = "ledig";
                else if (item.FamilienStand == 2)
                    strFamStand = "verheiratet";
                else if (item.FamilienStand == 3)
                    strFamStand = "geschieden";

                Console.WriteLine("| {0}| {1}| {2}| {3}| {4}| {5}|\n", count, item.Name, item.Vorname, item.GebDat.ToString(), strFamStand, item.AnzKinder.ToString());
                Console.WriteLine("|-----|---------------|---------------|------------|-------------|-------------|");
                Console.WriteLine("\n");
                i += 10;
            }
        }
        public void addPerson()
        {
            Person personItem = new Person();
            Console.Write("{0}", "Familienname: ".PadRight(15));
            personItem.Name = Console.ReadLine();

            Console.Write("{0}", "Vorname: ".PadRight(15));
            personItem.Vorname = Console.ReadLine();

            do
            {
                try
                {
                    Console.Write("{0}", "Geb.-Dat.: ".PadRight(15));
                    personItem.GebDat = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Falsches Format! (DD.MM.JJJ)");
                }
            } while (true);

            do
            {
                try
                {
                    Console.Write("{0}", "Fam.-Stand: ".PadRight(15));
                    Console.Write("{0}", "1 = ledig | 2 = verheiratet | 3 = geschieden".PadRight(15));
                    personItem.FamilienStand = Convert.ToInt32(Console.ReadLine());
                    if (personItem.FamilienStand != 0)
                        break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Falsches Format! Nur Ganzzahlen erlaubt");
                }
            } while (true);

            do
            {
                try
                {
                    Console.Write("{0}", "Anz.-Kinder: ".PadRight(15));
                    personItem.AnzKinder = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Falsches Format! Nur Ganzzahlen erlaubt");
                }
            } while (true);
            personenCollection.Add(personItem);
            personItem = null;
        }

        public void getPersonList()
        {
            string strFamStand = "";
            Console.Write("\n\nPersonen auflisten\n" +
                         "-------------------\n\n\n");
            Console.Write("| Nr. |     Name      |    Vorname    |  Geb. Dat. |  Fam.-Stand | Anz. Kinder |\n" +
                          "|-----|---------------|---------------|------------|-------------|-------------|\n");

            int i = 0;
            int count = 0;
            foreach (Person item in personenCollection)
            {
                if (item.FamilienStand == 1)
                    strFamStand = "ledig";
                else if (item.FamilienStand == 2)
                    strFamStand = "verheiratet";
                else if (item.FamilienStand == 3)
                    strFamStand = "geschieden";

                Console.WriteLine("| {0}| {1}| {2}| {3}| {4}| {5}|\n",count , item.Name, item.Vorname, item.GebDat.ToString(), strFamStand, item.AnzKinder.ToString());
                Console.WriteLine("|-----|---------------|---------------|------------|-------------|-------------|");
                Console.WriteLine("\n");
                i += 10;
            }
        }
    }
}
