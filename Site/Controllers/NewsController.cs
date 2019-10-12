using Site.Models;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers {
    public class NewsController : Controller {
        private const int pageSize = 10;

        public ActionResult Index(int pageNumber = 1) {
            var totalNews = iMStore.News.FindAll(n => n.Type == 0).OrderByDescending(n => n.CreatedTime);
            return View(new NewsModel {
                TotalPages = (int)Math.Ceiling((double)totalNews.Count() / pageSize),
                CurrentPage = pageNumber,
                PageNews = totalNews.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            });
        }

        public ActionResult Industry(int pageNumber = 1) {
            var totalNews = iMStore.News.FindAll(n => n.Type == 1).OrderByDescending(n => n.CreatedTime);
            return View(new NewsModel {
                TotalPages = (int)Math.Ceiling((double)totalNews.Count() / pageSize),
                CurrentPage = pageNumber,
                PageNews = totalNews.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
            });
        }

        public ActionResult Detail(string id) {
            ViewBag.HideFooter = true;

            if (string.IsNullOrWhiteSpace(id))
                throw new HttpException(404, "Page not found.");

            var current = iMStore.News.Find(n => n.Id.Equals(id));
            if (current == null)
                throw new HttpException(404, "Page not found.");

            return View(current);
        }
    }
}