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
            using (Models.masterEntities1 db = new Models.masterEntities1())
            {
                var dolist = db.todolist.SqlQuery("select * from todolist where userid = '" + (Session["userid"].ToString()) + "'").ToList();
                ViewBag.todolist = dolist;
                ViewBag.count = dolist.Count();
                return View();


            }

        }
    }
}