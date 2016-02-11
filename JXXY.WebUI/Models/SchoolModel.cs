using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using JXXY.Logic;
using AutoMapper;

namespace JXXY.WebUI.Models
{
    public class SchoolModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage="*必填")]
        [MaxLength(500,ErrorMessage="输入不能超过500个字")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*必填")]
        [MaxLength(500,ErrorMessage="输入不能超过500个字")]
        public string Address { get; set; }
        [MaxLength(500, ErrorMessage="输入不能超过500个字")]
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        private School _school = new School();

        public SchoolModel GetSchoolById(string id)
        {
            var school = _school.GetSchoolById(id);
            var schoolModel = FromLogicModel(school);
            return schoolModel;
        }

        public List<SchoolModel> GetSchools()
        {
            var schools = _school.GetSchools();
            return FromLogicModels(schools);
        }

        public void Add()
        {
            var school = ToLogicMode(this);
            _school.Add(school);
        }

        public void Update(SchoolModel schoolModel)
        {
            var school = ToLogicMode(schoolModel);
            _school.Update(school);
        }

        public void Delete(string id)
        {
            _school.Delete(id);
        }

        private static List<SchoolModel> FromLogicModels(List<School> schools)
        {
            var schoolModels = new List<SchoolModel>();
            if (schools != null && schools.Count > 0)
            {
                foreach (var school in schools)
                {
                    schoolModels.Add(FromLogicModel(school));
                }
            }
            return schoolModels;
        }

        private static SchoolModel FromLogicModel(School school)
        {
            Mapper.CreateMap<School, SchoolModel>();
            var schoolModel = Mapper.Map<SchoolModel>(school);
            return schoolModel;
        }

        private static School ToLogicMode(SchoolModel schoolModel)
        {
            Mapper.CreateMap<SchoolModel, School>();
            var school = Mapper.Map<School>(schoolModel);
            return school;
        }
    }
}