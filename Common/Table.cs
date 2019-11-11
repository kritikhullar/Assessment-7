using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assessment_EF.Models;

namespace Assessment_EF.Common
{
    public class Table
    {
        public List<Employee> emp { get; set; }
        public List<Department> dept { get; set; }

    }
}