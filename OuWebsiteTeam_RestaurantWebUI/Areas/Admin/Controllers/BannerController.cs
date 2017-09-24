using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System.Web.Mvc;
using System;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.Admin.Controllers
{
    public class BannerController : Controller
    {
        private readonly IBanners _repos;

        public BannerController(IBanners repos)
        {
            this._repos = repos;
        }

        // GET: Admin/Banner
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(PdbBanner ban)
        {
            ban.ID = Guid.NewGuid();
            if (ModelState.IsValid)
            {
                bool check = this._repos.Create(ban);
                if (check)
                {
                    ModelState.AddModelError("", "Create Successful !");
                }
                else
                {
                    return RedirectToAction("Add");
                }
            }
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