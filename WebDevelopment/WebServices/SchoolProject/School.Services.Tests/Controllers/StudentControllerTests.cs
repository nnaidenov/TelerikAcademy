using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Services.Tests.Repository.Fake;
using School.Models;
using School.Services.Controllers;

namespace School.Services.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTests
    {
        [TestMethod]
        public void GetAllStudents_WhenASingleStudentInRepository_ShouldReturnSingleStudent()
        {
            var repository = new FakeRepository<Student>();

            var studentToAdd = new Student()
            {
               FirstName = "TestName"
            };

            repository.entities.Add(studentToAdd);

            var controller = new StudentController(repository);

            var studentModels = controller.GetAll();

            int counter = 0;

            foreach (var a in studentModels)
            {
                counter++;
            }

            Assert.IsTrue(counter == 1);

            foreach (var a in studentModels)
            {
                Assert.AreEqual(studentToAdd.FirstName, a.FirstName);
            }
        }
    }
}