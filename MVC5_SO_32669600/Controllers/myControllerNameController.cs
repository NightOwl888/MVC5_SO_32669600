using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_SO_32669600.Controllers
{
    public class myControllerNameController : Controller
    {
        // GET: myControllerName/myActionName
        public ActionResult myActionName(int id = 0, int id2 = 0, int id3 = 0)
        {
            return View();
        }
    }
}