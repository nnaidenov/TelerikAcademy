using System;
using System.Linq;
using University.Models;
using University.Data;
using University.Data.Migrations;
using System.Data.Entity;

namespace University.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<UniversityContext, Configuration>());

            string fName = "Doncho";
            string lName = "Minkov";
            string number = "100000125";
            Course course = new Course { Name = "JavaScript", Description = "JavaScript Application", Materials = "None" };

            AddStudent(fName, lName, number, course);
            //LoadStudents();
            //LoadCourses();
        }

        private static void AddStudent(string fName, string lName, string number, Course course)
        {
            var db = new UniversityContext();

            var student = new Student();

            student.FirstName = fName;
            student.LastName = lName;
            student.Number = number;
            student.Courses.Add(course);

            db.Students.Add(student);
            db.SaveChanges();
        }

        private static void LoadStudents()
        {
            var db = new UniversityContext();

            var allStudents = db.Students.ToList();

            foreach (var studet in allStudents)
            {
                Console.WriteLine("{0} {1} - {2} - {3}", studet.FirstName, studet.LastName, studet.Number, studet.Courses.Count);
            }
        }

        private static void LoadCourses()
        {
            var db = new UniversityContext();

            var allCourses = db.Courses.ToList();

            foreach (var course in allCourses)
            {
                Console.WriteLine("{0}: {1} - {2} - {3}", course.Name, course.Description, course.Materials, course.Students.Count);
            }
        }
    }
}