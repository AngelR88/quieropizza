using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quieropizza.webadmin.Controllers
{
    public class home : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
    }
}