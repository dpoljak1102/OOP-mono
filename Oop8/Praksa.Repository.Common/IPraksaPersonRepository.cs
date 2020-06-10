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
        Task <List<Person>> GetAllPeopleAsync();
        Task UpdatePersonAsync(Person person);
        Task DeletePersonAsync(Person person);
        Task AddPersonAsync(Person person);
    }
}
