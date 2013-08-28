using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortStudentsLambdaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] Students = new Students[5];

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

            Students fifthStudent = new Students();
            fifthStudent.firstName = "Zdravko";
            fifthStudent.lastName = "Hristov";
            Students[4] = fifthStudent;

            //Lambda
            Console.WriteLine("---------- LAMBDA ----------");
            var sortLAMBDA = Students.OrderByDescending(student => student.firstName).ThenByDescending((student => student.lastName));

            foreach (var student in sortLAMBDA)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }

            Console.WriteLine("---------- LINQ ----------");
            var sortLINQ = from student in Students
                           orderby student.firstName descending, student.lastName descending
                           select student;

            foreach (var student in sortLINQ)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
        }
    }
}
