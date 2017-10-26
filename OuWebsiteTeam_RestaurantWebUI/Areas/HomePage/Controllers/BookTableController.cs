using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.HomePage.Controllers
{
    public class BookTableController : Controller
    {
        private readonly IBookTable _context;

        public BookTableController(IBookTable context)
        {
            this._context = context;
        }

        // GET: HomePage/BookTable
        [HttpGet]
        public ActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Booking(PdbBookTable book)
        {
            if (ModelState.IsValid)
            {
                book.Time = DateTime.Now;
                bool check = this._context.Create(book);
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
    }
}