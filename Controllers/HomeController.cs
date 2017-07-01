using CustomerWebApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerWebApp.Controllers
{
    public class HomeController : Controller
    {
        IMessageHelper _messageHelper;

        public HomeController(IMessageHelper messageHelper)
        {
            _messageHelper = messageHelper;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = _messageHelper.GetAboutMessage();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = _messageHelper.GetContactMessage();
            return View();
        }
    }
}