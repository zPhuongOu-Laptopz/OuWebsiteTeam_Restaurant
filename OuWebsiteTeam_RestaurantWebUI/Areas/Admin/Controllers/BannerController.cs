using OuWebsiteTeam_RestaurantService.DBContext;
using OuWebsiteTeam_RestaurantService.InterfaceEx.Module;
using System.Web.Mvc;
using System;
using System.Web;
using System.IO;

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
        public ActionResult Add(PdbBanner ban, HttpPostedFileBase file)
        {            
            if (file != null)
            {
                ban.ID = Guid.NewGuid();
                //string pic = System.IO.Path.GetFileName(file.FileName);
                //string path = System.IO.Path.Combine(Server.MapPath("~/images/profile"), pic);
                //// file is uploaded
                //file.SaveAs(path);

                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                    ban.ImageName = array;
                }
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
            }
            else
            {
                ModelState.AddModelError("", "Bạn Chưa Chọn hình!");
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