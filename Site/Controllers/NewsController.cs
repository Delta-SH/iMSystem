using Site.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Site.Controllers {
    public class NewsController : Controller {
        public ActionResult Index(int id = 1) {
            var pageSize = 10;
            return View(new NewsModel {
                TotalPages = (int)Math.Ceiling((double)iMStore.News.Count / pageSize),
                CurrentPage = id,
                PageNews = iMStore.News.Skip((id - 1) * pageSize).Take(pageSize).ToList()
            });
        }

        public ActionResult Industry(int id = 1) {
            var pageSize = 10;
            return View(new NewsModel {
                TotalPages = (int)Math.Ceiling((double)iMStore.News.Count / pageSize),
                CurrentPage = id,
                PageNews = iMStore.News.Skip((id - 1) * pageSize).Take(pageSize).ToList()
            });
        }
    }
}