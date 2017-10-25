using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.HomePage.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbacks _context;

        public FeedbackController(IFeedbacks context)
        {
            this._context = context;
        }

        // GET: HomePage/Feedback       
        [HttpGet]
        public ActionResult Feedback() //Add
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedback(PdbFeedback feed) //Add
        {
            if (feed.NumberStar < 0 || feed.NumberStar > 5)
            {
                ModelState.AddModelError("", "Số sao chỉ nằm trong khoảng từ 1 đến 5");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool check = _context.Create(feed);
                    if (check)
                    {
                        ModelState.AddModelError("", "Cảm ơn phản hồi của bạn!");
                    }
                    else
                    {
                        return RedirectToAction("Create");
                    }
                }
            }
            return View();
        }
    }
}