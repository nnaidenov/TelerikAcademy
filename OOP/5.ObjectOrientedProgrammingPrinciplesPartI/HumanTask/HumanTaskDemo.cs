using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTask
{
    class HumanTaskDemo
    {
        static void Main(string[] args)
        {
            //Fill StudentsList 
            List<Student> studentsList = new List<Student>(10) 
            {
                new Student(10, "Nikolay", "Naidenov"),
                new Student(8, "Georgi", "Ivanov"),
                new Student(1, "Filip", "Genov"),
                new Student(12, "Zdravki", "Gospodinov"),
                new Student(10, "Ignat", "Ignatov"),
                new Student(2, "Simeon", "Iliev"),
                new Student(8, "Anton", "Filipov"),
                new Student(7, "Andrei", "Lubenov"),
                new Student(11, "Gosho", "Liubenov"),
                new Student(10, "Cvetan", "Cvetanov"),
            };
            //END Fill StudentsList 

            //Make my workers
            Worker worker1 = new Worker(3500, 40, "Nikolay", "Naidenov");
            Worker worker2 = new Worker(1250, 35, "Geogri", "Ivanov");
            Worker worker3 = new Worker(2151, 40, "Zlatomir", "Zaimov");
            Worker worker4 = new Worker(7358, 38, "Petur", "Petrov");
            Worker worker5 = new Worker(520, 12, "Anastas", "Filipov");
            Worker worker6 = new Worker(385, 10, "Cvetan", "Cvetanov");
            Worker worker7 = new Worker(1100, 20, "Andrei", "Jelqskov");
            Worker worker8 = new Worker(2810, 37, "Vencislav", "Stoqnov");
            Worker worker9 = new Worker(2800, 36, "Kiril", "Krustev");
            Worker worker10 = new Worker(5355, 40, "Hristo", "Andreev");
            //END Make my workers

            //Add MoneyPerOur to my workers
            worker1.SalaryPerHour = worker1.MoneyPerHour();
            worker2.SalaryPerHour = worker2.MoneyPerHour();
            worker3.SalaryPerHour = worker3.MoneyPerHour();
            worker4.SalaryPerHour = worker4.MoneyPerHour();
            worker5.SalaryPerHour = worker5.MoneyPerHour();
            worker6.SalaryPerHour = worker6.MoneyPerHour();
            worker7.SalaryPerHour = worker7.MoneyPerHour();
            worker8.SalaryPerHour = worker8.MoneyPerHour();
            worker9.SalaryPerHour = worker9.MoneyPerHour();
            worker10.SalaryPerHour = worker10.MoneyPerHour();
            //END Add MoneyPerOur to my workers

            //Fill workersList
            List<Worker> workersList = new List<Worker>(10) 
            {
                worker1, worker2, worker3, worker4, worker5, worker6, worker7, worker8, worker9, worker10
            };
            //END Fill workersList

            //Order my students by Grade - ascending
            var orderStudents = from student in studentsList
                                orderby student.Grade ascending
                                select student;
            //END Order my students by Grade

            Console.WriteLine("---------- STUDENTS ----------");

            //Print my Ordered sutudents
            foreach (var orderStudent in orderStudents)
            {
                Console.WriteLine(orderStudent);
            }
            //END Print my Ordered sutudents

            

            //Order my students by SalaryPerHour - descending
            var orderWorkers = from werker in workersList
                               orderby werker.SalaryPerHour descending
                               select werker;
            //END Order my students by SalaryPerHour

            Console.WriteLine();
            Console.WriteLine("---------- WORKERS ----------");

            //Print my Ordered werkers
            foreach (var orderWorker in orderWorkers)
            {
                Console.WriteLine(orderWorker);
            }
            //END Print my Ordered werkers

            //Make humanList
            List<Human> humanList = new List<Human>(20);
            //Fill human list with Students and Workers
            humanList.AddRange(studentsList);
            humanList.AddRange(workersList);
            //END Fill human list with Students and Workers
            //END Make humanList
            

            //Order my human by First and Last name - ascending
            var sortHuman = from person in humanList
                            orderby person.FirstName ascending, person.LastName ascending
                            select person;
            //END Order my human by First and Last name

            Console.WriteLine();
            Console.WriteLine("---------- HUMAN ----------");

            //Print my Ordered human
            foreach (var person in sortHuman)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
            //END Print my Ordered human
        }
    }
}
