using Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult News(int id = 1) {
            var pageSize = 10;
            return View(new NewsModel {
                TotalPages = (int)Math.Ceiling((double)iMStore.News.Count / pageSize),
                CurrentPage = id,
                PageNews = iMStore.News.Skip((id - 1) * pageSize).Take(pageSize).ToList()
            });
        }
    }
}