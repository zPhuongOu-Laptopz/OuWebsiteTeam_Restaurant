using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            ViewBag.Phuongdeptrai = "Phuongdeptrai";
            ViewData["huycho"] = "HuyCho";
            return View();
        }
    }
}