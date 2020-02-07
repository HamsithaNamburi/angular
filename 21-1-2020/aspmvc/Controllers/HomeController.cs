using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspmvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public string Mypage()
        {
            return "hii MVC";
        }
        public JsonResult mypage1()
        {
            return Json("{id:1 ; name:mvc}",JsonRequestBehavior.AllowGet);
        }
        public ViewResult mypage2()
        {
            return View();
        }
    }
}