using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

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
            String sqlString = "Select * from Students;";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost;initial catalog=Master;User ID = johnson; Password = a0930867605";

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlString, conn);

            ViewBag.Message = "賓果小遊戲";
            conn.Close();
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