using Praksa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praksa.Common;

namespace Praksa.Repository.Common
{
    public interface IPraksaPersonRepository
    {
        Task <List<Person>> GetAllPeopleAsync(Filters filters, Pages page, Sorts sorts);
        Task<List<Person>> GetAllPeopleAsync();
        Task UpdatePersonAsync(Person person);
        Task DeletePersonAsync(Person person);
        Task AddPersonAsync(Person person);
    }
}
