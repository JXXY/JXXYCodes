using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JXXY.DataAccess;
using AutoMapper;

namespace JXXY.Logic
{
    public class School
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        private SchoolDBModel _schoolDBModel = new SchoolDBModel();

        public School GetSchoolById(string id)
        {
            var schoolDBModel = _schoolDBModel.GetSchoolById(id);
            var school = FromDBModel(schoolDBModel);
            return school;
        }

        public List<School> GetSchools()
        {
            var schoolDbModels = _schoolDBModel.GetSchools();
            return FromDBModels(schoolDbModels);
        }

        public void Add(School school)
        {
            var schoolDBModel = ToDBMode(school);
            _schoolDBModel.Add(schoolDBModel);
        }

        public void Update(School school)
        {
            var schoolDBModel = ToDBMode(school);
            _schoolDBModel.Update(schoolDBModel);
        }

        public void Delete(string id)
        {            
            _schoolDBModel.Delete(id);
        }

        private static List<School> FromDBModels(List<SchoolDBModel> schoolDBModels)
        {
            var schools = new List<School>();
            if (schoolDBModels != null && schoolDBModels.Count > 0)
            {
                foreach (var schoolDBModel in schoolDBModels)
                {
                    schools.Add(FromDBModel(schoolDBModel));
                }
                
            }
            return schools;
        }

        private static School FromDBModel(SchoolDBModel schoolDBModel)
        {
            Mapper.CreateMap<SchoolDBModel, School>();
            var school = Mapper.Map<School>(schoolDBModel);
            return school;
        }

        private static SchoolDBModel ToDBMode(School school)
        {
            Mapper.CreateMap<School, SchoolDBModel>();
            var schoolDBModel = Mapper.Map<SchoolDBModel>(school);
            return schoolDBModel;
        }
    }
}
