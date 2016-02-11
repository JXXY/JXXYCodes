using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JXXY.WebUI.Utils;
using JXXY.WebUI.Models;

namespace JXXY.WebUI.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolModel _schoolModel = new SchoolModel();

        // GET: School
        public ActionResult Show()
        {
            GetSchools();
            GetOtherActionModelState();

            return View();
        }

        

        [AcceptMultiButton("btnAdd")]
        [HttpPost]
        public ActionResult Add(SchoolModel schoolModel)
        {
            if (ModelState.IsValid)
            {
                schoolModel.Id = Guid.NewGuid().ToString();
                schoolModel.CreatedBy = SiteContext.JxxyUser.LoginName;
                schoolModel.CreatedDate = DateTime.Now;
                schoolModel.Add();
            }
            else
            {
                TempData["ModelState"] = ModelState;                
            }

            return RedirectToAction("show");
        }

        [AcceptMultiButton("btnUpdate")]
        [HttpPost]
        public ActionResult Update(SchoolModel schoolModel)
        {
            if (ModelState.IsValid)
            {
                schoolModel.Id = Guid.NewGuid().ToString();
                schoolModel.CreatedBy = SiteContext.JxxyUser.LoginName;
                schoolModel.CreatedDate = DateTime.Now;
                schoolModel.Add();
            }

            return RedirectToAction("show");
        }



        private void GetSchools()
        {
            var schools = new List<SchoolModel>();
            if (SiteContext.JxxyUser.LoginName == "admin")
            {
                schools = _schoolModel.GetSchools();
            }
            else
            {
                var schoolId = SiteContext.JxxyUser.SchoolId;
                var school = _schoolModel.GetSchoolById(schoolId);
                schools.Add(school);
            }
            ViewBag.schools = schools;
        }

        private void GetOtherActionModelState()
        {
            var tmpStateDictionary = TempData["ModelState"] as ModelStateDictionary;
            if (tmpStateDictionary != null && tmpStateDictionary.Count > 0)
            {
                foreach (var key in tmpStateDictionary.Keys)
                {
                    ModelState.Add(key, tmpStateDictionary[key]);
                }
            }
        }
    }
}