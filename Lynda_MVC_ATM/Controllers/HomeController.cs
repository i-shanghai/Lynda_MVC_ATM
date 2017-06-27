using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lynda_MVC_ATM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string message)
        {
            ViewBag.Message = "Please feedback your opinion.";

            if (!string.IsNullOrEmpty(message))
            {
                ViewBag.Message = "Thakns for your suggestion.";
            }

              return View();

            //return PartialView();

            //return new HttpStatusCodeResult(403);

            //return RedirectToAction("Contact");

            //return Json(new { name="Leon", Age="18" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Serial(string letterCase)
        {
            string str = "ASPNETMVC5ATMDEMO";
            if (letterCase.ToUpper() != "UPPER")
            {
                str = str.ToLower();
            }
            return Content(str);
        }
    }
}