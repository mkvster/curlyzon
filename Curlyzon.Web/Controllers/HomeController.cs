using Curlyzon.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curlyzon.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Test1()
        {
            return Content("Test1");
        }

        [Authorize(Roles = "Tester")]
        public ActionResult Test2()
        {
            return Content("Test2");
        }
    }
}
