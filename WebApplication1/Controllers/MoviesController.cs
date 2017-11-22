using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        MovieDBContext db = new MovieDBContext();
        // GET: Movies
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie m)
        {
            db.Movies.Add(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            Movie m = db.Movies.Find(id);
            return View(m);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Movie m = db.Movies.Find(id);
            if (m != null)
            {
                db.Movies.Remove(m);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            Movie m = db.Movies.Find(id);
            if (m != null)
            {
                return View(m);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            Movie m = db.Movies.Find(id);
            if (m != null)
            {
                return View(m);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Movie m)
        {
            db.Entry(m).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}