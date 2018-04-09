using NewApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApp.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        // GET: Profile
        public ActionResult ProfileOverview()
        {
            ProfileViewModels model = new ProfileViewModels()
            {
                
            };
            return View(model);
        }

        // GET: Profile/Edit/5
        

        // POST: Profile/Edit/5
        
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase upload)
        {
            if (upload != null)
            {
                // получаем имя файла
                string fileName = System.IO.Path.GetFileName(upload.FileName);
                // сохраняем файл в папку в проекте
                upload.SaveAs(Server.MapPath("~/App_Data/" + fileName));
            }
            return RedirectToAction("ProfileOverview");
        }
    }
}
