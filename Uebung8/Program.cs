using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uebung8.Klassen;

namespace Uebung8
{
    class Program
    {
        //Erstellen Sie eine Anwendung zur Mitarbeiterverwaltung. Über die Mitarbeiter sollen folgende
        //Informationen erfasst werden können:
        //- Name, Vorname,
        //- vollständige Adresse,
        //- Geburtsdatum,
        //- Konfession
        //- Lohnsteuerklasse
        //- Kinder
        //- Bruttogehalt

        //Das Brutto/Netto eines Mitarbeiters soll übersichtlich angezeigt werden können.
        //Die Lohnkosten aller Mitarbeiter sollen bei Wahl des entsprechenden Menüpunktes angezeigt werden.

        //Zur Vereinfachung verzichten wir auf die Nutzung der Lohnsteuertabelle und nehmen einheitliche
        //Steuersätze in den unterschiedlichen Lohnsteuerklassen.

        //Steuersätze in den unterschiedlichen Lohnsteuerklassen.
        //Lohnsteuerklasse 1: 21%
        //Lohnsteuerklasse 2: 20%
        //Lohnsteuerklasse 3: 19%
        //Lohnsteuerklasse 4: 23%
        //Lohnsteuerklasse 5: 21%
        //Lohnsteuerklasse 6: 30%

        //Für die Kirchensteuer werden einheitlich 9 % von der Lohnsteuer festgesetzt.
        //Solidaritätszuschlag: 5% von der Lohnsteuer

        //Weitere Abzüge sind (Diese werden zur Hälfte durch den Arbeitgeber und Arbeitnehmer getragen:
        //Krankenversicherung: 15,5%
        //Pflegeversicherung: 1,95% erhöht sich um 0,25 % wenn der Arbeitnehmer über 23 Jahre
        //alt ist und Kinderlos (die 0,25 % sind komplett durch den Arbeitnehmer zu leisten)
        //Rentenversicherung: 19,9 %
        //Arbeitslosenversicherung: 2,8%

        //Wenn Sie fertig sind bitte Haken setzen.
        
        static void Main(string[] args)
        {
            Menues menues = new Menues();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Lohnberechnung";
            Console.SetWindowSize(120, 60); // Konsolenfenster auf 90 Zeichen Breite und 50 Zeilen höhe stellen
            
            menues.Hauptmenu();
            // Programm ende
        }
        //public static void Mitarbeiteranlegen()
        //{

        //}

        public static void ClearScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}
