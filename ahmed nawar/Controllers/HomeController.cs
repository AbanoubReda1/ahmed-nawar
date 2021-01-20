using ahmed_nawar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ahmed_nawar.Controllers
{
    public class HomeController : Controller
    {
        private ahmed_nawarEntities db = new ahmed_nawarEntities();
        public ActionResult Index()
        {
            var tables = new ModelClass
            {
                abouts = db.Abouts.ToList(),
               sliders = db.Sliders.ToList(),
               projects=db.Projects.ToList()
            };
            return View(tables);
        }

        public ActionResult About()
        {
            return View(db.Abouts.ToList());
        }
        public ActionResult Contact()
        {
           

            return View();


        }
        [HttpPost]

        public ActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);

            
        }
        public ActionResult Home()
        {
          

            return View();
        }
        public ActionResult ARTICLES()
        {

            return View(db.Articles.ToList());
            
        }
        public ActionResult Projects()
        {

            return View(db.Projects.ToList());
          
        }
        public ActionResult ProjectsDetails()
        {


            return View();
        }
    }
}