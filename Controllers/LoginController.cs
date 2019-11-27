using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFilters.Filters;

namespace MVCFilters.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            int numOne = 1;
            int numZero = 0;
            int numResult = numOne / numZero;
            return View();
        }
    }
}