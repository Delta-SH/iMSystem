using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers {
    public class SolutionController : Controller {
        public ActionResult Index() {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult Sidebar(string id) {
            return PartialView(id);
        }
    }
}