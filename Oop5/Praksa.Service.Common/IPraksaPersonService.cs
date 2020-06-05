using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praksa.Model;
namespace Praksa.Service.Common
{
    public interface IPraksaPersonService
    {
        List<Person> GetAllPeople();
    }
}
