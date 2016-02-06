﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JXXY.Logic;

namespace JXXY.WebUI.Models
{
    public class TeacherModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string SchoolId { get; set; }

        private Teacher _teacherLogic = new Teacher();

        


    }
}