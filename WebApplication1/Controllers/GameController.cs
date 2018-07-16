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

        

        
    }
}