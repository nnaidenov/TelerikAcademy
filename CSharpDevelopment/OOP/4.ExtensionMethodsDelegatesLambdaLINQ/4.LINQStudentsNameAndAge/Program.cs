using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.LINQStudentsNameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] Students = new Students[5];

            Students firstStudent = new Students();
            firstStudent.firstName = "Nikolay";
            firstStudent.lastName = "Naidenov";
            firstStudent.age = 20;
            Students[0] = firstStudent;

            Students secondStudent = new Students();
            secondStudent.firstName = "Anton";
            secondStudent.lastName = "Dimitrov";
            secondStudent.age = 24;
            Students[1] = secondStudent;

            Students thirdStudent = new Students();
            thirdStudent.firstName = "Boris";
            thirdStudent.lastName = "Zaimov";
            thirdStudent.age = 31;
            Students[2] = thirdStudent;

            Students fourthStudent = new Students();
            fourthStudent.firstName = "Zdravko";
            fourthStudent.lastName = "Buchev";
            fourthStudent.age = 15;
            Students[3] = fourthStudent;

            Students fifthStudent = new Students();
            fifthStudent.firstName = "Zdravko";
            fifthStudent.lastName = "Buchev";
            fifthStudent.age = 18;
            Students[4] = fifthStudent;

            var sort = from student in Students
                       where student.age > 18 && student.age < 24
                       select student;

            foreach (var student in sort)
            {
                Console.WriteLine("{0} {1} - {2} years old", student.firstName, student.lastName, student.age);
            }
        }
    }
}
