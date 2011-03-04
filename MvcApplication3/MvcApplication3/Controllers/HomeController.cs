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

            if (ModelState.IsValid)
            {
                try
                {
                    // use your ORM of choice here to persist your model 

                    // return feedback to jQuery
                    return Json(new { Message = "Your name is " + p.Lastname + ", " + p.Firstname });
                }
                catch (Exception ex)
                {
                    return Json(new { Message = ex.Message });
                }
                
            }
            else
                // alert the user to tell the developer of an overlooked code
                return Json(new { Message = "Please contact the developer to enable client-side validation" });
        }

    }
}
