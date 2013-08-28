using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class LocalCourses : Courses, ILocalCourse
    {
        private string lab;
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                this.lab = value;
            }
        }

        public LocalCourses(string name, ITeacher teacher, string lab)
        {
            if (name == null || lab == null)
            {
                throw new ArgumentNullException();
            }
            this.Topic = new List<string>();
            this.Type = CourseType.LocalCourse;
            this.Name = name;
            this.Teacher = teacher;
            this.Lab = lab;
        }

        public override void AddTopic(string topic)
        {
            this.Topic.Add(topic);
        }

        public override string ToString()
        {            
            if (this.Topic.Count != 0 && this.Lab != null && this.Teacher.Name != null)
            {
                StringBuilder topics = new StringBuilder();
                foreach (var topic in this.Topic)
                {
                    topics.AppendFormat("{0}, ", topic);
                }
                topics.Length -= 2;
                return string.Format("{0}: Name={1}; Teacher={2}; Topics=[{3}]; Lab={4}", this.Type, this.Name, this.Teacher.Name, topics.ToString(), this.Lab);
            }
            else if (this.Topic.Count != 0 && this.Lab != null && this.Teacher.Name == null)
            {
                StringBuilder topics = new StringBuilder();
                foreach (var topic in this.Topic)
                {
                    topics.AppendFormat("{0}, ", topic);
                }
                topics.Length -= 2;
                return string.Format("{0}: Name={1}; Topics=[{3}]; Lab={4}", this.Type, this.Name, topics.ToString(), this.Lab);
            }
            else if (this.Topic.Count != 0 && this.Lab != null && this.Teacher.Name == null)
            {
                return string.Format("{0}: Name={1}; Lab={3}", this.Type, this.Name, this.Lab);
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
                return string.Format("{0}: Name={1}; Lab={2}", this.Type, this.Name, this.Lab);
            }
        }
    }
}
