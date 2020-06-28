using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public class Sorts: ISorts
    {
        // default values
        public string OrderBy { get; set; } = "Age";
        public string AscDesc { get; set; } = "ASC";
    }
}
