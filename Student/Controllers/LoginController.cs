using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student.Models;

namespace Student.Controllers
{
    public class LoginController : Controller
    {
        UserDL Details = new UserDL();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult UpdateLoginStatus(String Email, String Password)
        {
            return Json(Details.UpdateLoginStatus(Email, Password), JsonRequestBehavior.AllowGet);
        }

    }
}