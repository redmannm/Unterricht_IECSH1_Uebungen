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

            Console.Write(getMenu()); // Hauptmenü aufrufen

            ConsoleKeyInfo menuKey;
            do
            {
                menuKey = Console.ReadKey(true);

                //
                // Person anlegen
                //
                if (menuKey.Key == ConsoleKey.D1)
                {
                    Console.Write(getMenu("mainMenu"));
                    personenListe.addPerson();
                    

                }

                //
                // Fahrzeug-Eigenschaften bearbeiten
                //
                if (menuKey.Key == ConsoleKey.D2)
                {
                    
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
        public static string getMenu(string type)
        {
            string strMenu;

            switch (type)
            {
                case "mainMenu": // Hauptmenü
                    clearScreen();
                    strMenu = "Personenverwaltung\n" +
                              "------------------\n\n" +
                              "(1) Neue Person anlegen\n" +
                              "(2) Personen auflisten\n";
                    return strMenu;
                case "addPerson": // Person hinzufügen
                    clearScreen();
                    strMenu = "";

                    return strMenu;
                default:
                    return strMenu;
            }
        }
        public static void clearScreen()
        {
            Console.Clear();
        }
    }
}
