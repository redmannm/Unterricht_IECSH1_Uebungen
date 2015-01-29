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
            int intMaxItems = 25;
            for (int i = 0; i < intMaxItems; i++)
			{
			    Person personItems = new Person();
                personItems.Name = "Nachname_" + i;
                personItems.Vorname = "Vorname_" + i;
                personItems.GebDat = Convert.ToDateTime("11.10.74");
                personItems.FamilienStand = random.Next(1, 3);
                personItems.AnzKinder = random.Next(0, 4);
                personenCollection.Add(personItems);
                personItems = null;
			}
            
            int y = 0;
            int x = 0;
            int count = 0;
            int intItemsPerPage = 10;
            int intRest = 0;
            string strFamStand = "";
            for (int i = 0; i < personenCollection.Count; i++)
            {
                Console.Write("\n\nPersonen auflisten\n" +
                              "-------------------\n\n\n");
                Console.Write("|-----|---------------|---------------|------------|-------------|-------------|\n" +
                              "| Nr. |     Name      |    Vorname    |  Geb. Dat. |  Fam.-Stand | Anz. Kinder |\n" +
                              "|-----|---------------|---------------|------------|-------------|-------------|\n");
                try
                {
                    intRest = (intMaxItems % intItemsPerPage);
                    if (y <= 19)
                        x = intItemsPerPage;
                    else
                        x = intRest;
                    List<Person> itemList = personenCollection.GetRange(y, x);
                    foreach (Person item in itemList)
                    {
                        if (item.FamilienStand == 1)
                            strFamStand = "ledig";
                        else if (item.FamilienStand == 2)
                            strFamStand = "verheiratet";
                        else if (item.FamilienStand == 3)
                            strFamStand = "geschieden";
                        ++count;
                        Console.Write("| {0}| {1}| {2}| {3}| {4}| {5}|\n", count.ToString().PadRight(4), item.Name.PadRight(14), item.Vorname.PadRight(14), item.GebDat.ToShortDateString().PadRight(11), strFamStand.PadRight(12), item.AnzKinder.ToString().PadRight(12));
                        Console.Write("|-----|---------------|---------------|------------|-------------|-------------|\n");
                    }
                    Console.Write("\n\n(W) - Weiter");
                    ConsoleKeyInfo menuKey;
                    do
                    {
                        menuKey = Console.ReadKey(true);
                        if (menuKey.Key == ConsoleKey.W)
                        {
                            Start.clearScreen();
                            break;
                        }
                    } while (true);
                    y += 10;
                    i += 9;
                }
                catch (ArgumentException)
                {
                    
                }
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
                    Console.Write("{0}", "1 = ledig | 2 = verheiratet | 3 = geschieden: ".PadRight(15));
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
            int y = 0;
            int x = 0;
            int count = 0;
            int intMaxTeilbar = 0;
            int intItemsPerPage = 10;
            int intRest = 0;
            int intMaxItems = 25;
            string strFamStand = "";
            for (int i = 0; i < personenCollection.Count; i++)
            {
                Console.Write("\n\nPersonen auflisten\n" +
                              "-------------------\n\n\n");
                Console.Write("|-----|---------------|---------------|------------|-------------|-------------|\n" +
                              "| Nr. |     Name      |    Vorname    |  Geb. Dat. |  Fam.-Stand | Anz. Kinder |\n" +
                              "|-----|---------------|---------------|------------|-------------|-------------|\n");
                try
                {
                    intRest = (intMaxItems % intItemsPerPage);
                    intMaxTeilbar = intMaxItems - (intMaxItems % intItemsPerPage);
                    if (y <= 19)
                        x = intItemsPerPage;
                    else
                        x = intRest;
                    List<Person> itemList = personenCollection.GetRange(y, x);
                    foreach (Person item in itemList)
                    {
                        if (item.FamilienStand == 1)
                            strFamStand = "ledig";
                        else if (item.FamilienStand == 2)
                            strFamStand = "verheiratet";
                        else if (item.FamilienStand == 3)
                            strFamStand = "geschieden";
                        ++count;
                        Console.Write("| {0}| {1}| {2}| {3}| {4}| {5}|\n", count.ToString().PadRight(4), item.Name.PadRight(14), item.Vorname.PadRight(14), item.GebDat.ToShortDateString().PadRight(11), strFamStand.PadRight(12), item.AnzKinder.ToString().PadRight(12));
                        Console.Write("|-----|---------------|---------------|------------|-------------|-------------|\n");
                    }
                    Console.Write("\n\n(W) - Weiter");
                    ConsoleKeyInfo menuKey;
                    do
                    {
                        menuKey = Console.ReadKey(true);
                        if (menuKey.Key == ConsoleKey.W)
                        {
                            Start.clearScreen();
                            break;
                        }
                    } while (true);
                    y += 10;
                    i += 9;
                }
                catch (ArgumentException)
                {

                }
            }
        }
    }
}
