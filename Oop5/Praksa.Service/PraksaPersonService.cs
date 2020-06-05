using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praksa.Service;
using Praksa.Model;
using Praksa.Repository;
using Praksa.Service.Common;

namespace Praksa.Service
{
    public class PraksaPersonService: IPraksaPersonService
    {
        public List<Person> people = new List<Person>();
        PraksaPersonRepository personRepository = new PraksaPersonRepository();
        public PraksaPersonService() { }
        //Give all persons
        public List<Person> GetAllPeople() 
        {
            people = personRepository.GetAllPeople();
            return people;
        }
        //Update person
        public void UpdatePerson(Person person)
        {
            personRepository.UpdatePerson(person);
        }
        //Delete person
        public void DeletePerson(Person person)
        {
            personRepository.DeletePerson(person);
        }
        //Add person
        public void AddPerson(Person person)
        {
            personRepository.AddPerson(person);
        }

    }
}
