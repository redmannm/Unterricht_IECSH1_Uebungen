﻿using System;
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
            for (int i = 0; i < personenCollection.Count; i++)
            {
                if (personenCollection[i].FamilienStand == 1)
                    strFamStand = "ledig";
                else if (personenCollection[i].FamilienStand == 2)
                    strFamStand = "verheiratet";
                else if (personenCollection[i].FamilienStand == 3)
                    strFamStand = "geschieden";

                Console.WriteLine("| {0}| {1}| {2}| {3}| {4}| {5}|\n", i, personenCollection[i].Name, personenCollection[i].Vorname, personenCollection[i].GebDat.ToString(), strFamStand, personenCollection[i].AnzKinder.ToString());
                Console.WriteLine("|-----|---------------|---------------|------------|-------------|-------------|");
                Console.WriteLine("\n");
                
            }
        }
    }
}
