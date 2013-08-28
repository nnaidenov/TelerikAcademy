using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class : People
    {
        private string classIdent;
        private List<Teachers> listTeachers;
        private List<Students> listStudents;

        public Class()
        {
        }

        public Class(string classIdent, List<Teachers> listTeachers, List<Students> listStudents)
        {
            this.classIdent = classIdent;
            this.listTeachers = listTeachers;
            this.listStudents = listStudents;
        }
    }
}
