using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using JXXY.Logic;

namespace JXXY.WebUI.Models
{
    public class LoginModel
    {
        [Required]
        public string LoginName { get; set; }

        [Required]
        public string Password { get; set; }

        private Teacher _teacherLogic = new Teacher();

        public bool IsLogicOk()
        {
            return _teacherLogic.IsLoginOk(this.LoginName, this.Password);
        }
    }
}