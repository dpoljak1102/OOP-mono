using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public class Page
    {
        public int PageIndex { get; set; } 
        public int PageSize { get; set; } // records that will be displayed in a page
        public int TotalPages { get; set; }
    }
}
