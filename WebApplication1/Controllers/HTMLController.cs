using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HTMLController : Controller
    {
        // GET: HTML
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Login(User user)
        {
            HttpPostedFileBase file = Request.Files["pic"];
            if (file.ContentLength > 0)
            {
                file.SaveAs(Server.MapPath("~/Resource/Image/") + System.IO.Path.GetFileName(file.FileName));
                user.pic = file.FileName;
            }
            
            return View(user);
        }

        public ActionResult Css()
        {
            return View();
        }

        public String CheckUsername(String username)
        {
            if (username.Equals("wustzz"))
            {
                return "该用户名已注册";
            }
            else
            {
                return "OK";
            }
        }


    }
}