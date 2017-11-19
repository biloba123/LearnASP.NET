using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DBModel;

namespace WebApplication1.Controllers
{
    public class TestEFController : Controller
    {
        DBEntities dbEntities = new DBEntities();

        // GET: TestEF
        public ActionResult Index()
        {
            return View(dbEntities.Students.ToList());
        }

        public ActionResult Add()
        {
            Student s = new Student();
            s.Name = "王五";
            s.Age = 20;

            dbEntities.Students.Add(s);
            dbEntities.SaveChanges();

            //return View("Index", dbEntities.Students.ToList());
            return RedirectToAction("Index");
        }
    }
}