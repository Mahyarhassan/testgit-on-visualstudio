using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testgit_on_visualstudio.Models;
using System.Web.Mvc;

namespace testgit_on_visualstudio.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}