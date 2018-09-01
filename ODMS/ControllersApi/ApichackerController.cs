using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ODMS.ControllersApi
{
    public class ApichackerController : Controller
    {
        // GET: Apichacker
        public ActionResult LoginApi()
        {
            return PartialView();
        }
    }
}