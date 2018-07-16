using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult No1()
        {
            ViewBag.Message = "賓果小遊戲";

            return View();
        }

        public ActionResult No2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult No3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthorRize(WebApplication1.Models.Menber member)
        {
            using (Models.masterEntities db = new Models.masterEntities())
            {
                var user = db.Menber.Where(x => x.Account == member.Account && x.passwd == member.passwd).FirstOrDefault();
                if (user == null)
                {

                    member.LoginErrorMessage = "帳號或密碼錯誤";
                    return View("Login", member);
                }
                else
                {
                    Session["userid"] = member.Account;
                    ViewBag.userid = Session["userid"];
                    return RedirectToAction("Home", "Game");
                }
            }
        }

        
    }
}