using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JXXY.WebUI.Models;

namespace JXXY.WebUI.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        { 
            if(ModelState.IsValid)
            {
                var isValidUser = loginModel.IsLogicOk();
                if (!isValidUser)
                {
                    ModelState.AddModelError("loginTip", "用户名或密码错误！");
                }
                else
                {
                    return RedirectToAction("show", "School");
                }
            }
            return View();
            
        }
    }
}