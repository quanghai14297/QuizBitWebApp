using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuizBit_WebApp.Models;
using Desktop.Lib;

namespace QuizBit_WebApp.Controllers
{
    public class LoginController : Controller
    {

        private dbContext db = new dbContext();
        public bool alertLogin = false;
        [HttpGet]
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        // GET: Login
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                var connect = CloudLibrary.CreateServiceConnection();
                Session["Token"] = connect.Login(user.UserName, user.Password);
                if (String.IsNullOrEmpty(Session["Token"].ToString()))
                {
                    alertLogin = true;
                    ViewBag.alertLogin = alertLogin;
                    //ModelState.AddModelError("", "Tài khoản không tồn tại trong hệ thống !");
                    Redirect("Login/Login");
                    ViewBag.Mes = "Sai mật khẩu hoặc tài khoản. Vui lòng kiểm tra lại!";
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}