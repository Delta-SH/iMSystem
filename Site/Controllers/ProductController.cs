using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers {
    public class ProductController : Controller {
        [ChildActionOnly]
        public PartialViewResult Sidebar(Product product) {
            return PartialView(product);
        }

        public ActionResult DCIM() {
            ViewBag.HideFooter = true;
            var product = iMStore.Software.Find(s => s.Id == "P000101");
            if(product == null) throw new HttpException(404, "Page not found.");
            return View(product);
        }
    }
}