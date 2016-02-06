using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXXY.DataAccess
{
    public class TeacherDBModel
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

        public void TeacherDBModel()
        {
            Mapper.CreateMap<Teacher, TeacherDBModel>();
        }

        public TeacherDBModel GetTeacher(string userName)
        {
            using (JxxyEntities jxxyContext = new JxxyEntities())
            { 
                var dbTeacher = (from teacher in jxxyContext.Teachers
                               where teacher.LoginName == userName
                               select teacher).FirstOrDefault();

                if(dbTeacher != null)
                {
                    return FromModeInDB(dbTeacher);
                }

                return null;
            }
        }

        private static TeacherDBModel FromModeInDB(Teacher teacher)
        {
            Mapper.CreateMap<Teacher, TeacherDBModel>();
            var teacherDBModel = Mapper.Map<TeacherDBModel>(teacher);
            return teacherDBModel;
        }
    }
}
