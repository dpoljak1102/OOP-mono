﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Common
{
    public class Filters : IFilters
    {
        // default values
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}