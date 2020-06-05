using Praksa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Repository.Common
{
    public interface IPraksaPersonRepository
    {
        List<Person> GetAllPeople();
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
        void AddPerson(Person person);
    }
}
