using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentsTask
{
    class StudentTask
    {
        static void Main(string[] args)
        {
            Student az = new Student();
            az.firstName = "Asdf";
            az.middleName = "Asdf";
            az.lastName = "Asdf";
            az.address = "Bulgaria, Sofia, Mladost 5";
            az.SSN = 2569233358;
            az.mobilePhone = 088354895;
            az.email = @"asdf@gmail.com";
            az.cours = 3;
            az.specialty = Specialty.Business;
            az.university = University.UniversityOfNationalAndWorldEconomy;
            az.faculty = Faculty.Business;
            Console.WriteLine(az);

            Student az2 = new Student();
            az2.firstName = "Bsdf";
            az2.middleName = "Asdf";
            az2.lastName = "Asdf";
            az2.address = "Bulgaria, Sofia, Mladost 5";
            az2.SSN = 2569233358;
            az2.mobilePhone = 088354895;
            az2.email = @"asdf@gmail.com";
            az2.cours = 3;
            az2.specialty = Specialty.Business;
            az2.university = University.UniversityOfNationalAndWorldEconomy;
            az2.faculty = Faculty.Business;

            Console.WriteLine(az.CompareTo(az2));
        }
    }
}
