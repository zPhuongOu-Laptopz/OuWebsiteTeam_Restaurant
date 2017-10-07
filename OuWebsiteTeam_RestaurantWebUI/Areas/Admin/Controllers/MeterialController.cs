using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using OuWebsiteTeam_RestaurantService.DBContext;
using System.Web.Mvc;
using System;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.Admin.Controllers
{
    public class MeterialController : Controller
    {
        // GET: Admin/Meterial
        private readonly IMeterials _context;
        public MeterialController(IMeterials context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PdbMeterial met)
        {
            if (ModelState.IsValid)
            {
                bool check = _context.Create(met);
                if (check)
                {
                    ModelState.AddModelError("", "Thêm successful");
                }
                else
                {
                    return RedirectToAction("Create");
                }
            }
            return View();
        }

        public ActionResult Delete(Guid id)
        {
            bool check = this._context.Delete(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(Guid id)
        {
            PdbMeterial mete = this._context.GetOne(id);
            return View(mete);
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            PdbMeterial met = this._context.GetOne(id);
            return View(met);
        }

        [HttpPost]
        public ActionResult Edit(PdbMeterial met)
        {
            if (ModelState.IsValid)
            {
                bool check = this._context.Edit(met);
                if (check)
                {
                    ModelState.AddModelError("", "Edit successful");
                }
                else
                {
                    return RedirectToAction("Edit");
                }
            }
            return View();
        }

        public ActionResult List()
        {
            return View(this._context.GetAll());
        }
    }
}