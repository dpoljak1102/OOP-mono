using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public class Filters
    {
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
       // public bool HaveFilter => !string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);
    }
}
