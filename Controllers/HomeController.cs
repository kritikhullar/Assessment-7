using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment_EF.Models;
using Assessment_EF.Common;

namespace Assessment_EF.Controllers
{
    public class HomeController : Controller
    {
        FormsAuthenticationDbEntities context = new FormsAuthenticationDbEntities();

        //GET:Home
        public ActionResult Index()
        {
            var table = new Table();
            table.emp = context.Employees.ToList();
            table.dept = context.Departments.ToList();

            return View(table);
        }

        
    }
}