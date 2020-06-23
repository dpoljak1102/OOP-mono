using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public class FilterName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HaveFilter => !string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);
    }
}
