using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public interface IPages
    {
        int PageIndex { get; set; }
        int PageSize { get; set; } // records that will be displayed in a page
        int TotalPages { get; set; }
    }
}
