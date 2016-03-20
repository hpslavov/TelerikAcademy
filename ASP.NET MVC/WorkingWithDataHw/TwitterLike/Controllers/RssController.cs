using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterLike.Services;
using TwitterLike.Services.Contracts;

namespace TwitterLike.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RssController : Controller
    {
        private IRssService rssNews;

        public RssController(IRssService service)
        {
            rssNews = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetNewsBgFeed()
        {
            var items = rssNews.GetAllNewsBg();
            return this.PartialView("_FeedResults",items);
        }

        public ActionResult GetFrogNewsFeed()
        {
            var items = rssNews.GetAllFrogNews();
            return this.PartialView("_FeedResults", items);
        }

        public ActionResult GetDarikNewsFeed()
        {
            var items = rssNews.GetAllDarikNews();
            return this.PartialView("_FeedResults", items);
        }

        public ActionResult GetOffNewsFeed()
        {
            var items = rssNews.GetOffNewsBg();
            return this.PartialView("_FeedResults", items);
        }

        public ActionResult GetStandartNewsFeed()
        {
            var items = rssNews.GetStandartNewsBg();
            return this.PartialView("_FeedResults", items);
        }
    }
}