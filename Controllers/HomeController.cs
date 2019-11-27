using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilters.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                int numOne = 1;
                int numZero = 0;
                int numResult = numOne / numZero;
            }
            catch (Exception ex)
            {
                var exx=ex;
            }
            return View();
        }
    }
}