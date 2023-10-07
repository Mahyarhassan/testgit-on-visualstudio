using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testgit_on_visualstudio.Models;
using System.Web.Mvc;
using System.Runtime.Remoting.Contexts;
using System.ComponentModel;

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
        public ActionResult getdoc(int e)
        {

            var doc = context.tbl_doctors.Where(x=>x.fkskills==e).Select(x => new { x.pkID, x.Name , x.Family }).ToList();
            return Json(doc, JsonRequestBehavior.AllowGet);

        }
        public ActionResult getVisit(int e)
        {

            
            var visit = context.View_Visit.Where(x => x.fkDocID == e && x.fkPID==null).Select(x => new { x.pkID,x.PSDate,x.PSTime}).ToList();
            
            return Json(visit, JsonRequestBehavior.AllowGet);
            

        }

        public ActionResult setVisit (int vn , string name , string family ,string phone)
        {

            //var a = context.tbl_Visit.Where(x=> x.fkPID==vn ).SingleOrDefault();
            var np = context.tbl_Patient.Where(x => x.Mobile == phone).SingleOrDefault();
            var v = context.tbl_Visit.Where(x => x.pkID == vn).SingleOrDefault();
            var res = 0;
            if (v.fkPID == null) {
            res = 1;
                if (np == null)
                {

                    tbl_Patient newP = new tbl_Patient();
                    newP.Name = name;
                    newP.Family = family;
                    newP.Mobile = phone;

                    context.tbl_Patient.Add(newP);
                    //context.SaveChanges();



                }

                v.EDate = v.SDate.AddMinutes(20);
                v.fkVTID = 1;
                v.fkPID = np.pkID;
                context.SaveChanges();



            }
            else
            {
                res = 2;
            }


            return Json(res, JsonRequestBehavior.AllowGet);
        }




    }
}