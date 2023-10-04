using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testgit_on_visualstudio.Models;
using System.Web.Mvc;
using System.Runtime.Remoting.Contexts;

namespace testgit_on_visualstudio.Controllers
{
    public class DefaultController : Controller
    {

        htdata context = new htdata();
        // GET: Default
        public ActionResult Index()
        {
            

            int docs = context.tbl_doctors.Count();
            int dep = context.tbl_skills.Count();
            int research = context.tbl_Research.Count();
            int awards = context.tbl_awards.Count();

            ViewBag.docs = docs;
            ViewBag.dep = dep;
            ViewBag.research = research;
            ViewBag.awards = awards;



            return View();
        }

        public ActionResult getdep()
        {

            var dep = context.tbl_skills.Select(x => new {x.pkID , x.skills}).ToList();
            return Json(dep, JsonRequestBehavior.AllowGet);

        }
        public ActionResult getdoc( int dep)
        {

            var doc = context.tbl_doctors.Where(x => x.fkskills == dep).Select(x => new { x.pkID, x.Name , x.Family }).ToList();
            return Json(doc, JsonRequestBehavior.AllowGet);

        }
        //public ActionResult getvisit()
        //{

        //    var visit = context.tbl_visit.Select(x => new { x. }).ToList();
        //    return Json(visit, JsonRequestBehavior.AllowGet);

        //}




    }
}