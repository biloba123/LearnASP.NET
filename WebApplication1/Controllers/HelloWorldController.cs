using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        static List<Student> stuList=new List<Student> ();

        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

    
        public ActionResult Welcome(String username, String sex, int n)
        {
            if (sex.Equals( "男"))
            {
                ViewBag.Message = "欢迎" + username + "先生";
            }
            else if (sex.Equals("女"))
            {
                ViewBag.Message = "欢迎" + username + "女士";
            }

            ViewBag.Count = n;

            return View();
        }


        public void Add(Student stu)
        {
            var result = from s in stuList
                         where s.id == stu.id
                         select s;

            if (result.Count< Student >() > 0)
            {
                Response.Write("<script>alert('该记录已存在')</script>");
            }
            else
            {
                stuList.Add(stu);

                ViewBag.Count = stuList.Count;
                Response.Write("<script>alert('学生信息添加成功')</script>");
            }
        }

        public ActionResult Details(int id)
        {
            var result = from s in stuList
                         where s.id == id
                         select s;
            Student stu = result.FirstOrDefault<Student>();


            if (stu == null)
            {
                return View("None");
            }
            else
            {
                return View(stu);
            }
        }


        public ActionResult List()
        {
            //ViewBag.List = stuList;
            return View(stuList);
        }

    }
}