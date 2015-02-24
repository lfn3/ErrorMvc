using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Exception()
        {
            throw new Exception("Exceptional!");
        }

        public ActionResult StackOverflow()
        {
            Overflow();

            return View();
        }

        public static void Overflow()
        {
          Overflow();
        }

        public ActionResult TemplateException()
        {
            return View();
        }

        public ActionResult TemplateOverflow()
        {
            return View();
        }
    }
}