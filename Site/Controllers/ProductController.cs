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

        public ActionResult PEIMS() {
            ViewBag.HideFooter = true;
            var product = iMStore.Software.Find(s => s.Id == "p-01-001");
            if(product == null) throw new HttpException(404, "Page not found.");
            return View(product);
        }

        public ActionResult BOMS() {
            ViewBag.HideFooter = true;
            var product = iMStore.Software.Find(s => s.Id == "p-01-002");
            if (product == null) throw new HttpException(404, "Page not found.");
            return View(product);
        }

        public ActionResult IMMU() {
            ViewBag.HideFooter = true;
            var product = iMStore.Hardware.Find(s => s.Id == "p-02-001");
            if (product == null) throw new HttpException(404, "Page not found.");
            return View(product);
        }
    }
}