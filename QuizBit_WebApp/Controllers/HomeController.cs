using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizBit_WebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (DateTime.Now.ToString("tt").Contains("AM"))
            {
                ViewBag.Title = String.Format("Hoạt động trong ngày({0} - {1} Sáng)", DateTime.Now.ToString("dd / MM / yyyy"), DateTime.Now.ToString("hh:mm"));
            }
            else
            {
                ViewBag.Title = String.Format("Hoạt động trong ngày({0} - {1} Chiều)", DateTime.Now.ToString("dd / MM / yyyy"), DateTime.Now.ToString("hh:mm"));
            }
            
            return View();
        }
    }
}