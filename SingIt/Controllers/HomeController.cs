using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SingIt.Models;

namespace SingIt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            var model = new ContactUsViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(ContactUsViewModel model)
        {

            var name = model.Name;
            var email = model.EmailAddress;
            var message = model.Message;
            return View(model);

        }

        public ActionResult Rules()
        {
            ViewBag.Message = "Your Rules Page";

            return View();
        }
    }
}