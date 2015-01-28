using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenVerwaltung
{
    class PersonenListManager
    {
        private List<Person> personenCollection = new List<Person>();

        private Person personItem = new Person();

        public PersonenListManager()
        {

        }

        public Person addPerson()
        {
            Console.Write("Familienname: ");
            personItem.Name = Console.ReadLine();
            return personItem;
        }
    }
}
