namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using University.Models;

    public sealed class Configuration : DbMigrationsConfiguration<UniversityContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(UniversityContext context)
        {
            context.Database.ExecuteSqlCommand("IF NOT EXISTS (SELECT name FROM sysindexes WHERE name = 'IX_Authors_Name') CREATE UNIQUE INDEX IX_Authors_Name ON Students (Number)");

            Course jsCourse = new Course { Name = "JavaScript", Description = "JavaScript Application", Materials = "None" };
            Course phpCourse = new Course { Name = "PHP", Description = "Some PHP", Materials = "None" };
            Course dbCourse = new Course { Name = "DB", Description = "All for DB", Materials = "None" };

            context.Courses.AddOrUpdate(jsCourse);
            context.Courses.AddOrUpdate(phpCourse);
            context.Courses.AddOrUpdate(dbCourse);

            var studentOne = new Student();
            studentOne.FirstName = "Nikolay";
            studentOne.LastName = "Kostov";
            studentOne.Number = "1000002533";
            studentOne.Courses.Add(jsCourse);

            var studentTwo = new Student();
            studentOne.FirstName = "Svetlin";
            studentOne.LastName = "Nakov";
            studentOne.Number = "10000025200";
            studentOne.Courses.Add(dbCourse);

            var studentThree = new Student();
            studentOne.FirstName = "Georgi";
            studentOne.LastName = "Georgiev";
            studentOne.Number = "1000003000";
            studentOne.Courses.Add(jsCourse);

            context.Students.AddOrUpdate(studentOne);
            context.Students.AddOrUpdate(studentTwo);
            context.Students.AddOrUpdate(studentThree);
        }
    }
}