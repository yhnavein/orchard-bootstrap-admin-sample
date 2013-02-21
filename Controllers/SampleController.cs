using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard.Themes;
using Orchard.UI.Admin;

namespace BootstrapAdminSample.Controllers
{
    [Admin]
    [Themed]
    [Authorize]
    public class SampleController : Controller
    {
        //
        // GET: /Sample/

        public ActionResult Index()
        {
            return View();
        }

    }
}
