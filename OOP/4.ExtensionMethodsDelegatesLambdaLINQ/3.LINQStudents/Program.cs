using System;
using System.Linq;

namespace _3.LINQStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] Students = new Students[4];

            Students firstStudent = new Students();
            firstStudent.firstName = "Nikolay";
            firstStudent.lastName = "Naidenov";
            Students[0] = firstStudent;

            Students secondStudent = new Students();
            secondStudent.firstName = "Anton";
            secondStudent.lastName = "Dimitrov";
            Students[1] = secondStudent;

            Students thirdStudent = new Students();
            thirdStudent.firstName = "Boris";
            thirdStudent.lastName = "Zaimov";
            Students[2] = thirdStudent;

            Students fourthStudent = new Students();
            fourthStudent.firstName = "Zdravko";
            fourthStudent.lastName = "Buchev";
            Students[3] = fourthStudent;

            var sort = from student in Students
                       where student.firstName.CompareTo(student.lastName) == -1
                       select student;

            foreach (var student in sort)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
        }
    }
}
