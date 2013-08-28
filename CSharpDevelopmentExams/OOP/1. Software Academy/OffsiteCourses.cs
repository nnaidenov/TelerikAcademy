using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class OffsiteCourses : Courses, IOffsiteCourse
    {
        public OffsiteCourses(string name, ITeacher teacher, string town)
        {
            if (name == null || town == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.Topic = new List<string>();
                this.Type = CourseType.OffsiteCourse;
                this.Name = name;
                this.Teacher = teacher;
                this.Town = town;
            }
        }

        private string town;
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        public override void AddTopic(string topic)
        {
            this.Topic.Add(topic);
        }

        public override string ToString()
        {
            if (this.Topic.Count != 0 && this.Town != null)
            {
                StringBuilder topics = new StringBuilder();
                foreach (var topic in this.Topic)
                {
                    topics.AppendFormat("{0}, ", topic);
                }
                topics.Length -= 2;
                return string.Format("{0}: Name={1}; Teacher={2}; Topics=[{3}]; Town={4}", this.Type, this.Name, this.Teacher.Name, topics.ToString(), this.Town);
            }
            //else if (this.Topic.Count != 0 && this.Lab == null)
            //{
            //    StringBuilder topics = new StringBuilder();
            //    foreach (var topic in this.Topic)
            //    {
            //        topics.AppendFormat("{0}, ", topic);
            //    }
            //    topics.Length -= 2;
            //    return string.Format("{0}: Name={1}; Teacher={2}; Topics=[{3}];", this.Type, this.Name, this.Teacher.Name, topics.ToString());
            //}
            else
            {
                return string.Format("{0}: Name={1}; Teacher={2}; Town={3}", this.Type, this.Name, this.Teacher.Name, this.Town);
            }
        }
    }
}
