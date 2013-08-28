using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentsTask
{
    class Student : ICloneable, IComparable<Student>
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public long SSN { get; set; }
        public string address { get; set; }
        public int mobilePhone { get; set; }
        public string email { get; set; }
        public byte cours { get; set; }
        public Specialty specialty { get; set; }
        public University university { get; set; }
        public Faculty faculty { get; set; }



        //Override Equals
        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }
            else if (!object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Override ==
        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        //Override !=
        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        //Override GetHashCode
        public override int GetHashCode()
        {
            return firstName.GetHashCode() ^ lastName.GetHashCode();
        }

        //Override ToString()
        public override string ToString()
        {
            StringBuilder studentFormat = new StringBuilder();
            studentFormat.AppendLine("-------------------- \n\rPersonal information \n\r--------------------");
            studentFormat.AppendFormat("Name: {0} {1} {2} \n\r", firstName, middleName, lastName);
            studentFormat.AppendFormat("SSN: {0} \n\r", SSN);
            studentFormat.AppendFormat("Address: {0} \n\r", address);
            studentFormat.AppendFormat("Mobile phone: {0} \n\r", mobilePhone);
            studentFormat.AppendFormat("Email: {0}", email);
            studentFormat.AppendLine();
            studentFormat.AppendLine("---------------------- \n\rUniversity information \n\r----------------------");
            studentFormat.AppendFormat("University: {0} \n\r", university);
            studentFormat.AppendFormat("Faculty: {0} \n\r", faculty);
            studentFormat.AppendFormat("Specialty: {0} \n\r", specialty);
            return studentFormat.ToString();
        }

        //Clone Method
        public object Clone()
        {
            var studentCopy = new Student();
            studentCopy.firstName = this.firstName;
            studentCopy.middleName = this.middleName;
            studentCopy.lastName = this.lastName;
            studentCopy.SSN = this.SSN;
            studentCopy.address = this.address;
            studentCopy.mobilePhone = this.mobilePhone;
            studentCopy.email = this.email;
            studentCopy.cours = this.cours;
            studentCopy.specialty = this.specialty;
            studentCopy.university = this.university;
            studentCopy.faculty = this.faculty;
            return studentCopy;
        }

        public int CompareTo(Student student)
        {
            if (firstName.CompareTo(student.firstName) != 0)
                return firstName.CompareTo(student.firstName);
            else if (middleName.CompareTo(student.middleName) != 0)
                return middleName.CompareTo(student.middleName);
            else if (lastName.CompareTo(student.lastName) != 0)
                return lastName.CompareTo(student.lastName);
            else
            {
                return SSN.CompareTo(student.SSN);
            }
        }
    }
}
