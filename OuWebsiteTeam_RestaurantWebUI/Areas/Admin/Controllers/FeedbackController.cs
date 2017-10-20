using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System;
using System.Web.Mvc;

namespace OuWebsiteTeam_RestaurantWebUI.Areas.Admin.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbacks _context;

        public FeedbackController(IFeedbacks context)
        {
            this._context = context;
        }

        // GET: Admin/Feedback
        public ActionResult List()
        {
            return View(this._context.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            PdbFeedback mete = this._context.GetOne(id);
            return View(mete);
        }
    }
}