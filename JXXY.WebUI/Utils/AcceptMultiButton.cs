using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JXXY.WebUI.Utils
{
    public class AcceptMultiButton:ActionNameSelectorAttribute
    {        

        public string ButtonName { get; set; }

        public AcceptMultiButton(string buttonName)
        {
            this.ButtonName = buttonName;
        }

        public override bool IsValidName(ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo)
        {
            bool state = !string.IsNullOrEmpty(ButtonName) && controllerContext.HttpContext.Request.Form.AllKeys.Contains(this.ButtonName);
            return state;
        }
        
    }
}