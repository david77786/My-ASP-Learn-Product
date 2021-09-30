using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnConnectionString.Services;
using LearnConnectionString.ViewModels;
using System.Web.Mvc;

namespace LearnConnectionString.Content
{
    public class GuestbookController : Controller
    {
        private  GuestbooksService service = new GuestbooksService();
        

        public ActionResult Index()
        {
            GuestboolsViewModel model = new GuestboolsViewModel();
            model.DataList = service.GerDataList();
            return View(model);
        }
    }
}