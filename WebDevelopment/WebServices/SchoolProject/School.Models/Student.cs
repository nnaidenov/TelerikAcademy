using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

        public virtual University University { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
