using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public class Pages: IPages
    {
        public Pages()
        {
            this.PageSize = recordsOnPage;
            this.PageIndex = currentPage;
        }
        // default values 
        public int recordsOnPage { get; set; } = 5;
        public int currentPage { get; set; } = 1;

        public int PageIndex { get; set; }
        public int PageSize { get; set; } // records that will be displayed in a page
        public int TotalPages { get; set; }
    }
}
