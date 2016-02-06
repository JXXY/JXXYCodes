using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JXXY.DataAccess;
using JXXY.Helper;
using AutoMapper;

namespace JXXY.Logic
{
    public class Teacher
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

        private TeacherDBModel _teacherDBModel = new TeacherDBModel();

        public Teacher GetTeacher(string userName)
        {
            var dbTeacher = _teacherDBModel.GetTeacher(userName);
            return FromDBModel(dbTeacher);
        }

        public bool IsLoginOk(string userName, string pwd)
        {
            var teacher = GetTeacher(userName);
            if (teacher != null)
            {
                var encryptPwd = EncryptionHelper.EncryptPassword(pwd);
                return encryptPwd.Equals(teacher.Password);
            }
            return false;
        }

        public static Teacher FromDBModel(TeacherDBModel teacherDBModel)
        {
            if (teacherDBModel != null)
            {
                Mapper.CreateMap<TeacherDBModel, Teacher>();
                var teacher = Mapper.Map<Teacher>(teacherDBModel);
                return teacher;
            }
            return null;
        }
    }
}
