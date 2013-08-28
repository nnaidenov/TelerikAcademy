using School.Data;
using School.Models;
using School.Repositories;
using School.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace School.Services.Controllers
{
    public class UniversityController : BaseController
    {
        private readonly IRepository<University> universityRepository;

        public UniversityController()
        {
            var dbContext = new SchoolContext();
            this.universityRepository = new DbSchoolRepository(dbContext);
        }

        public UniversityController(IRepository<University> repository)
        {
            this.universityRepository = repository;
        }

        [HttpGet]
        public IQueryable<SchoolModel> GetAll()
        {
            var schools = this.universityRepository.All();

            List<SchoolModel> models = new List<SchoolModel>
            (from sc in schools
             select new SchoolModel
             {
                 Id = sc.Id,
                 Name = sc.Name
             });

            return models.AsQueryable();
        }

        [HttpGet]
        public SchoolModel GetStudetById(int schoolId)
        {
            var school = this.universityRepository.Get(schoolId);

            var model = new SchoolModel
            {
                Id = school.Id,
                Name = school.Name
            };

            return model;
        }

        [HttpPost]
        public HttpResponseMessage AddNewSchool(University model)
        {
            var result = this.universityRepository.Add(model);

            var newSchool = new SchoolModel
            {
                Id = result.Id,
                Name = result.Name
            };

            var response = this.Request.CreateResponse(HttpStatusCode.Created, newSchool);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = newSchool.Id }));

            return response;
        }
    }
}