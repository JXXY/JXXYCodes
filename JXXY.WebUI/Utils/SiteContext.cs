using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using JXXY.WebUI.Models;

namespace JXXY.WebUI.Utils
{
    public class SiteContext
    {
        public static TeacherModel JxxyUser
        { 
            get
            {
                var teacher = HttpContext.Current.Session["Login_model"] as TeacherModel;                
                return teacher;
            }
            set 
            {
                HttpContext.Current.Session["Login_model"] = value;
            }
        }
    }
}