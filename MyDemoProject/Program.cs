using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new PersonRepository().GetAllPersons();

            foreach(var person in persons)
            {
                Console.WriteLine(string.Format("Person name is -> {0}", person.Name));
            }
            var filteredPerson = new PersonRepository().GetPersonByName("Tom Hanks");

            foreach(var person in filteredPerson)
            {
                Console.WriteLine(string.Format("Found a match for the Person -> {0}", person.Name));
            }

            filteredPerson = new PersonRepository().GetPersonByZip("01234");
            foreach (var person in filteredPerson)
            {
                Console.WriteLine(string.Format("Found a match for the Person by zipcode -> {0}", person.Name));
            }

            Console.Read();
        }
    }
}
