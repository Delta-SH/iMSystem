using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Development() {
            return View();
        }

        public ActionResult Certificate() {
            return View();
        }

        public ActionResult Customer() {
            return View();
        }

        public ActionResult Contact() {
            return View();
        }
    }
}