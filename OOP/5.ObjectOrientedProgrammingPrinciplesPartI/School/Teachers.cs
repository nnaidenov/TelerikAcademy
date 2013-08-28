using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teachers : People
    {
        private List<Disciplines> teacherDiscplines;

        public Teachers(string name)
        {
            this.Name = name;
            this.TeacherDiscplines = new List<Disciplines>();
        }

        public List<Disciplines> TeacherDiscplines
        {
            get { return this.teacherDiscplines; }
            set
            {
                this.teacherDiscplines = value;
            }
        }
    }
}