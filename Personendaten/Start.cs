using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenVerwaltung
{
    class Start
    {
        static void Main(string[] args)
        {
            PersonenListManager personenListe = new PersonenListManager();

            Console.Write(getScreen(1)); // Hauptmenü aufrufen

            ConsoleKeyInfo menuKey;
            do
            {
                menuKey = Console.ReadKey(true);

                //
                // Person anlegen
                //
                if (menuKey.Key == ConsoleKey.D1)
                {
                    clearScreen();
                    personenListe.addPerson();
                    Console.Write(getScreen(1));
                    Console.Write("Person erfolgreich angelegt!");
                    

                }

                //
                // Fahrzeug-Eigenschaften bearbeiten
                //
                if (menuKey.Key == ConsoleKey.D2)
                {
                    personenListe.getPersonList();
                }

                //
                // Fahrzeugtür öffnen
                //
                if (menuKey.Key == ConsoleKey.D3)
                {
                    
                }

                //
                // Fahrzeugtür schließen
                //
                if (menuKey.Key == ConsoleKey.D4)
                {
                    
                }

                //
                // Motor starten
                //
                if (menuKey.Key == ConsoleKey.D5)
                {
                    
                }

                //
                // Motor stoppen
                //
                if (menuKey.Key == ConsoleKey.D6)
                {
                    
                }

            } while (menuKey.Key != ConsoleKey.E);
            
        }
        public static string getScreen(int menuType)
        {
            string strMenu;

            switch (menuType)
            {
                case 1: // Hauptmenü
                    clearScreen();
                    strMenu = "Personenverwaltung\n" +
                              "------------------\n\n" +
                              "(1) Neue Person anlegen\n" +
                              "(2) Personen auflisten\n" +
                              "(3) Person suchen\n" +
                              "(E) Programm beenden\n\n";
                    return strMenu;
                case 2: // Personen auflisten
                    string tabHead;
                    string tabRow;
                    //            4         14               14           11            12            12
                    tabHead = "| Nr. |     Name      |    Vorname    |  Geb. Dat. |  Fam.-Stand | Anz. Kinder |\n" +
                              "|-----|---------------|---------------|------------|-------------|-------------|\n";
                    tabRow  = "| {0}| {1}| {2}| {3}| {4}| {5}|\n";
                    strMenu = "Personen auflisten\n" +
                              "-------------------\n\n";
                    return strMenu;
            }
            return string.Empty;
        }
        public static void clearScreen()
        {
            Console.Clear();
        }
    }
}
