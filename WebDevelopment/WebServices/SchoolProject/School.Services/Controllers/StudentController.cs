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
    public class StudentController : BaseController
    {
        private readonly IRepository<Student> studentRepository;

        public StudentController()
        {
            var dbContext = new SchoolContext();
            this.studentRepository = new DbStudentRepository(dbContext);
        }

        public StudentController(IRepository<Student> repository)
        {
            this.studentRepository = repository;
        }

        [HttpGet]
        public IQueryable<StudentModel> GetAll()
        {
            var students = this.studentRepository.All();

            List<StudentModel> models = new List<StudentModel>
                (from st in students
                 select new StudentModel
                 {
                     Id = st.Id,
                     FirstName = st.FirstName,
                     LastName = st.LastName,
                     StudentNumber = st.StudentNumber
                 });

            return models.AsQueryable();
        }

        [HttpGet]
        public StudentModel GetStudetById(int studentId)
        {
            var student = this.studentRepository.Get(studentId);

            var model = new StudentModel
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                StudentNumber = student.StudentNumber
            };

            return model;
        }

        [HttpPost]
        public HttpResponseMessage AddNewStudent(Student model)
        {
            var result = this.studentRepository.Add(model);

            var newStudent = new StudentModel
            {
                Id = result.Id,
                FirstName = result.FirstName,
                LastName = result.LastName,
                StudentNumber = result.StudentNumber
            };

            var response = this.Request.CreateResponse(HttpStatusCode.Created, newStudent);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = newStudent.Id }));

            return response;
        }

        public IQueryable<StudentModel> GetStudentBySubjectAndMark(string subject, double mark)
        {
            var students = this.studentRepository.All()
                .Where(st => st.Subjects.Any(sb => sb.Name == subject && sb.Marks.Any(m => m.Value >= mark)));

            var model =
                (from sts in students
                 select new StudentModel
                        {
                            Id = sts.Id,
                            FirstName = sts.FirstName,
                            LastName = sts.LastName,
                            StudentNumber = sts.StudentNumber
                        }
                );

            return model;
        }
    }
}