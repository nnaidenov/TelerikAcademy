using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Comments
    {
        private string comment;

        public Comments(string comment)
        {
            this.Comment = comment;
        }

        public Comments()
        {
        }

        public string Comment
        {
            get { return this.comment; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.comment = value;
                }
            }
        }
    }
}
