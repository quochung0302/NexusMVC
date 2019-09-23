using Nexus.DAO;
using Nexus.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nexus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AdvantageDao advantageDao = new AdvantageDao();

            var advantages = advantageDao.GetList();
            return View( "Index", advantages);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult AddMessage(Feedback fb)
        {
            
            if (ModelState.IsValid)
            {
                FeedbackDao fbDao = new FeedbackDao();
                fb.TimeAdded = DateTime.Now;
                fbDao.AddMessage(fb);
                return RedirectToAction("Index");

            }
            else
            {
                return View("Contact");
            }

        }
    }
}