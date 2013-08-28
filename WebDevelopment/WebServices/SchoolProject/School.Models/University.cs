using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Models
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
