using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (ConferenceContext context = new ConferenceContext())
            {
                return View(context.Sessions.ToList());
            }
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
    }
}