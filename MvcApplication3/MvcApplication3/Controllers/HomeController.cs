using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult Create(Person p)
        {
            // use your ORM of choice here to persist your model 

            // return feedback to jQuery
            return Json(new { Message = "Your name is " + p.Lastname + ", " + p.Firstname });
        }

    }
}
