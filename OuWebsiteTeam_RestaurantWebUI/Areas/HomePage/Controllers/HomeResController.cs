using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using OuWebsiteTeam_RestaurantService.Models.Module;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.HomePage.Controllers
{
    public class HomeResController : Controller
    {
        private readonly IFoods _context;

        public HomeResController(IFoods context)
        {
            this._context = context;
        }

        // GET: HomePage/HomeRes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadForBreakfast()
        {
            return View(this._context.GetFourFoodForBreakfast());
        }
    }
}