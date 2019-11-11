using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assessment_EF.Models;

namespace Assessment_EF.Common
{
    public class Table
    {
        public IEnumerable<Employee> emp { get; set; }
        public IEnumerable<Department> dept { get; set; }

    }
}