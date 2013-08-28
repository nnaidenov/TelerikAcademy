using System;
using System.Data.Entity;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Data;
using School.Models;
using School.Repositories;

namespace School.Services.Tests.Repository
{
    [TestClass]
    public class DbStudentRepositoryTests
    {
        public DbContext dbContext { get; set; }

        public IRepository<Student> studentRepository { get; set; }

        private static TransactionScope tranScope;

        public DbStudentRepositoryTests()
        {
            this.dbContext = new SchoolContext();
            this.studentRepository = new DbStudentRepository(this.dbContext);
        }

        [TestInitialize]
        public void TestInit()
        {
            tranScope = new TransactionScope();
        }

        [TestCleanup]
        public void TestTearDown()
        {
            tranScope.Dispose();
        }

        [TestMethod]
        public void Add_WhenNameIsValid_ShouldAddStudentToDatabase()
        {
            var validStudent = new Student
            {
                FirstName = "ValidName",
                LastName = "Familia",
                StudentNumber = "200000589"
            };

            var response = this.dbContext.Set<Student>().Add(validStudent);
            this.dbContext.SaveChanges();

            Assert.IsTrue(response.Id > 0);
        }
    }
}