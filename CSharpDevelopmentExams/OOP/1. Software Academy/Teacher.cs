using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : SoftwareAcademyCommandExecutor, ITeacher
    {
        public string Name { get; set; }
        private List<ICourse> CoursesList { get; set; }

        public void AddCourse(ICourse course)
        {
            this.CoursesList.Add(course);
        }

        public Teacher(string name)
        {
            this.CoursesList = new List<ICourse>();
            this.Name = name;            
        }

        public override string ToString()
        {
            if (this.CoursesList.Count != 0)
            {
                StringBuilder courseList = new StringBuilder();
                foreach (var course in this.CoursesList)
                {
                    courseList.AppendFormat("{0}, ", course.Name);
                }
                courseList.Length -= 2;
                return string.Format("Teacher: Name={0}; Courses=[{1}]", this.Name, courseList.ToString());
            }
            else
            {
                return string.Format("Teacher: Name={0};", this.Name);
            }
        }
    }
}
