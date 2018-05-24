using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Security.Controllers
{
    public class LeraarController : Controller
    {
        [Authorize(Roles = "Leraar")]
        // GET: Leraar
        public ActionResult Index()
        {

            return View();
        }
    }
}