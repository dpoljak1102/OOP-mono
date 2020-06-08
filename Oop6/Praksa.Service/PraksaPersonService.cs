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
        public async Task<List<Person>> GetAllPeopleAsync() 
        {
            return await personRepository.GetAllPeopleAsync();
            //people = personRepository.GetAllPeopleAsync();
            //return people;
        }
        //Update person
        public async Task UpdatePersonAsync(Person person)
        {
             await personRepository.UpdatePersonAsync(person);
            //personRepository.UpdatePerson(person);
        }
        //Delete person
        public async Task DeletePersonAsync(Person person)
        {
             await personRepository.DeletePersonAsync(person);
        }
        //Add person
        public async Task AddPersonAsync(Person person)
        {
            await personRepository.AddPersonAsync(person);
        }

    }
}
