using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Software3.Controllers
{
    public class PanelPrincipalController : Controller
    {
        // GET: PanelPrincipal
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}