using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public abstract class Courses : SoftwareAcademyCommandExecutor, ICourse
    {
        protected CourseType Type;
        public List<string> Topic { get; set; }
        public string Name { get; set; }
        public ITeacher Teacher { get; set; }

        public abstract void AddTopic(string topic);
    }
}