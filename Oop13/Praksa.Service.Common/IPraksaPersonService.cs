using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praksa.Model;
using Praksa.Common;
namespace Praksa.Service.Common
{
    public interface IPraksaPersonService
    {
        Task<List<Person>> GetAllPeopleAsync(Filters filters, Pages page, Sorts sorts);
        Task<List<Person>> GetAllPeopleAsync();
        Task UpdatePersonAsync(Person person);
        Task DeletePersonAsync(Person person);
        Task AddPersonAsync(Person person);
    }
}
