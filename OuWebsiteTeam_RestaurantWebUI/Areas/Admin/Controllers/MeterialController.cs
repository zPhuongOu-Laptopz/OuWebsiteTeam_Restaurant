using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using OuWebsiteTeam_RestaurantService.DBContext;
using System.Web.Mvc;

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

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(this._context.GetAll());
        }
    }
}