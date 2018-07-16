using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login


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
                    return RedirectToAction("Home", "Game");
                }
            }
        }
    }
}