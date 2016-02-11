using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXXY.DataAccess
{
    public class SchoolDBModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public SchoolDBModel GetSchoolById(string id)
        {
            using (JxxyContext jxxyContext = new JxxyContext())
            {
                var dbSchool = (from school in jxxyContext.Schools
                                 where school.Id == id
                                 select school).FirstOrDefault();

                if (dbSchool != null)
                {
                    return FromModel(dbSchool);
                }

                return null;
            }
        }

        public List<SchoolDBModel> GetSchools()
        {
            using (JxxyContext jxxyContext = new JxxyContext())
            {
                var dbSchools = (from school in jxxyContext.Schools     
                                 orderby school.CreatedDate descending
                                select school).ToList();
               
                return FromModels(dbSchools);                
            }
        }

        public void Add(SchoolDBModel schoolDBModel)
        {
            var school = ToMode(schoolDBModel);
            using (JxxyContext jxxyContext = new JxxyContext())
            {
                jxxyContext.Schools.Add(school);
                jxxyContext.SaveChanges();
            }
        }

        public void Update(SchoolDBModel schoolDBModel)
        {            
            using (JxxyContext jxxyContext = new JxxyContext())
            {
                var schoolDB = (from school in jxxyContext.Schools
                             where school.Id == schoolDBModel.Id
                             select school).FirstOrDefault();

                schoolDB.Name = schoolDBModel.Name;
                schoolDB.Address = schoolDBModel.Address;
                schoolDB.Remark = schoolDBModel.Remark;
                schoolDB.UpdatedBy = schoolDBModel.UpdatedBy;
                schoolDB.UpdatedDate = DateTime.Now;

                jxxyContext.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            using (JxxyContext jxxyContext = new JxxyContext())
            {
                var schoolDB = (from school in jxxyContext.Schools
                                where school.Id == id
                                select school).FirstOrDefault();

                jxxyContext.Schools.Remove(schoolDB);
                jxxyContext.SaveChanges();
            }
        }

        private static List<SchoolDBModel> FromModels(List<School> schools)
        {
            var schoolDBModels = new List<SchoolDBModel>();
            if (schools != null && schools.Count > 0)
            {
                foreach (var school in schools)
                {
                    schoolDBModels.Add(FromModel(school));
                }
            }
            return schoolDBModels;
        }

        private static SchoolDBModel FromModel(School school)
        {
            Mapper.CreateMap<School, SchoolDBModel>();
            var schoolDBModel = Mapper.Map<SchoolDBModel>(school);
            return schoolDBModel;
        }

        private static School ToMode(SchoolDBModel schoolDBModel)
        {
            Mapper.CreateMap<SchoolDBModel, School>();
            var school = Mapper.Map<School>(schoolDBModel);
            return school;
        }

    }
}
