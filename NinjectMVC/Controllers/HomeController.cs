using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using NinjectMVC.Service;

namespace NinjectMVC.Controllers
{
    public class HomeController : Controller
    {
        [Inject]
        public ITestService Service { get; set; }
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = Service.GetMessage("你当我是透明的啊!");
            return View();
        }

 
    }
}