using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using OuWebsiteTeam_RestaurantService.Models.Module;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContact _context;

        public ContactController(IContact context)
        {
            this._context = context;
        }
        // GET: Admin/Contact
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(PdbContact con)
        {
            if (ModelState.IsValid)
            {
                bool check = _context.Create(con);
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

        public ActionResult List()
        {
            return View(this._context.GetAll());
        }
    }
}