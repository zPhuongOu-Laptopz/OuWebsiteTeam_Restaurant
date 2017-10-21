using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.Admin.Controllers
{
    public class BookTableController : Controller
    {
        private readonly IBookTable _context;

        public BookTableController(IBookTable context)
        {
            this._context = context;
        }
        // GET: Admin/BookTable
        public ActionResult List()
        {
            return View(this._context.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            PdbBookTable mete = this._context.GetOne(id);
            return View(mete);
        }
    }
}