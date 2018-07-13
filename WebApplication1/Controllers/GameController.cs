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

        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthorRize(WebApplication1.Models.Menber member)
        {
            using (Models.masterEntities db = new Models.masterEntities()) {
                var user = db.Menber.Where(x => x.Account == member.Account && x.passwd == member.passwd).FirstOrDefault();
                if (user == null)
                {
                    
                    member.LoginErrorMessage = user + "帳號或密碼錯誤";
                    return View("login", member);
                }
                else {
                    Session["userid"] = member.Account;
                    return RedirectToAction("Home", "Game");
                }
            }
        }

        public ActionResult TodoList(WebApplication1.Models.todolist todolist)
        {
            using (Models.masterEntities1 db = new Models.masterEntities1()) {
                //List<dolist> todolist1 = new List<dolist>;
                //var list = db.todolist.Where(x => x.staff == "123");
                var dolist = db.todolist.SqlQuery("select * from todolist where userid = '123'" ).ToList();                
                ViewBag.todolist = dolist;
                ViewBag.count = dolist.Count();
                return View();
                
                
            }
               
        }
    }
}