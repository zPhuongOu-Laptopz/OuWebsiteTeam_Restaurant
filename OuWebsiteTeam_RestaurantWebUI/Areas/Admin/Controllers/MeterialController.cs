using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.Admin.Controllers
{
    public class MeterialController : Controller
    {
        // GET: Admin/Meterial
        private readonly 

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}