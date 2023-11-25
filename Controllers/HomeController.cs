using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sessions.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["var1"] = " Data comes from ViewData";
            ViewBag.Var2 = "Data comes from ViewBag";
            TempData["Var3"] = "Data comes from TempData";
            Session["Var4"] = "Data comes from session";

            string[] Students = { "aa", "bb", "cc" };

            Session["Var5"] = Students;

            return View();
        }

        public ActionResult About()
        {
            if (Session["Var4"] != null)
            {
                Session["Var4"].ToString();
            }


            return View();
        }

        public ActionResult Contact()
        {

            if (Session["Var4"] != null)
            {
                Session["Var4"].ToString();
            }


            return View();
        }
    }
}