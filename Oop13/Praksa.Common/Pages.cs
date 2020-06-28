using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public class Pages: IPages
    {
        // default values
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 5; // records that will be displayed in a page
        public int TotalPages { get; set; }
    }
}
