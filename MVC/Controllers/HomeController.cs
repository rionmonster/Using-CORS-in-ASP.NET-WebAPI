using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MajorTom.Controllers
{
    public class HomeController : Controller
    {
        //Example Index to render our Index View (that will handle all the communication)
        public ActionResult Index()
        {
            return View();
        }

    }
}
