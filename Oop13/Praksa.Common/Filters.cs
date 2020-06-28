using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public class Filters : IFilters
    {
        //names need to be improved but since this is a single person table this is fine
        // default values
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
