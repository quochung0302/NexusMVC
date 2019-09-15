using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nexus.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Pricing()
        {
            return View();
        }
        public ActionResult Elements()
        {
            return View();
        }
    }
}