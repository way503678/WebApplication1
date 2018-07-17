using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TodolistController : Controller
    {
        // GET: Todolist

        public ActionResult TodoList(WebApplication1.Models.todolist todolist)
        {

            var userid = Session["userid"].ToString();
            using (Models.masterEntities1 db = new Models.masterEntities1())
            {
                var dolist = db.todolist.SqlQuery("select * from todolist where userid = '" + userid + "'").ToList();
                ViewBag.todolist = dolist;
                return View();


            }

        }
        [HttpPost]
        public ActionResult Deletestaff(WebApplication1.Models.todolist todolist,string button)
        {            
            var userid = Session["userid"].ToString();
            using (Models.masterEntities1 db = new Models.masterEntities1())
            {
                var update = db.todolist.Where(x => x.staffid.ToString() == button).FirstOrDefault();
                update.statu = "1";
                db.SaveChanges();               
                return RedirectToAction("Todolist");
            }
         }

        [HttpPost]
        public ActionResult Addnewstaff(WebApplication1.Models.todolist todolist, string addnewstaff)
        {
            Models.todolist todo = new Models.todolist
            {
                userid = Session["userid"].ToString(),
                staff = addnewstaff,
                statu = "0"
            };
            using (Models.masterEntities1 db = new Models.masterEntities1())
            {               
                db.todolist.Add(todo);
                db.SaveChanges();                
            }
            return RedirectToAction("Todolist");
        }


    }
}