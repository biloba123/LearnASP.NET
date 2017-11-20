using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            dbEntities.Students.Add(s);
            dbEntities.SaveChanges();
            return View("Index", dbEntities.Students.ToList());
        }

        public ActionResult Delete(int? id)
        {
            Student stu = dbEntities.Students.Find(id);
            if (stu != null)
            {
                dbEntities.Students.Remove(stu);
                dbEntities.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            Student stu = dbEntities.Students.Find(id);
            if (stu != null)
            {
                return View(stu);
            }
            return RedirectToAction("Index");
        }        [HttpPost]
        public ActionResult Edit(Student stu)
        {
            dbEntities.Entry(stu).State = EntityState.Modified;
            dbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Query(String s, int? a)
        {
            var result = from stu in dbEntities.Students
                         where stu.Age < a && stu.Name.Contains(s)
                         select stu;
            return View("Index", result.ToList());
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