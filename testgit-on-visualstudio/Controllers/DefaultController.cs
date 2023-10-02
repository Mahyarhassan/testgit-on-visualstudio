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

            var docs = context.tbl_doctors.Count();
            var dep = context.tbl_skills.Count();
            var research = context.tbl_Research.Count();
            var awards = context.tbl_awards.Count();

            ViewBag.doc = docs;
            ViewBag.dep = dep;
            ViewBag.research = research;
            ViewBag.awards = awards;



            return View();
        }



    }
}