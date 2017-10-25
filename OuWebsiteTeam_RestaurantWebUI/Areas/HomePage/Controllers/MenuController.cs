using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.HomePage.Controllers
{
    public class MenuController : Controller
    {
        // GET: HomePage/Menu
        public ActionResult Menu() // Menu Sang
        {
            return View();
        }

        public ActionResult Breakfast() // Menu Trua
        {
            return View();
        }

        public ActionResult Lunch() // Menu Trua
        {
            return View();
        }

        public ActionResult Dinner() // Menu Trua
        {
            return View();
        }

        public ActionResult Desserts() // Menu Trua
        {
            return View();
        }

        public ActionResult Drinks() // Menu Trua
        {
            return View();
        }
    }
}