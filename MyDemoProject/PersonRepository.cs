using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoProject
{
    class PersonRepository
    {
        public List<Person> GetAllPersons()
        {
            return new List<Person>() {
                new Person() { Name="Tom Hanks", DateOfBirth="10/10/1951", City="Los Angeles", ZipCode="01478"},
                new Person() { Name="Robin Williams", DateOfBirth="06/06/1958", City="San Francisco", ZipCode="35358"},
                new Person() { Name="Peter Pan", DateOfBirth="12/05/1975", City="Boston", ZipCode="01234"},
                new Person() { Name="George Williamson", DateOfBirth="01/30/1963", City="New York", ZipCode="12367"}
            };
        }

        public List<Person> GetPersonByName(string name)
        {
            var persons = GetAllPersons();
            IEnumerable<Person> result = persons.Where(x => x.Name == name);
            return result.ToList();
        }

        public List<Person> GetPersonByZip(string zipCode)
        {
            var persons = GetAllPersons();
            IEnumerable<Person> result = persons.Where(x => x.ZipCode == zipCode);
            return result.ToList();
        }
    }
}
