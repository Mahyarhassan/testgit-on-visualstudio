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
            htdata context = new htdata();

            int docs = context.tbl_doctors.Count();
            int dep = context.tbl_skills.Count();
            int research = context.tbl_Research.Count();
            int awards = context.tbl_awards.Count();

            ViewBag.doc = docs;
            ViewBag.dep = dep;
            ViewBag.research = research;
            ViewBag.awards = awards;



            return View();
        }



    }
}