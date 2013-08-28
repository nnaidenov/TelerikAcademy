using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Services.Models
{
    public class StudentModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentNumber { get; set; }
    }
}