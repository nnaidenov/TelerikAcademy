using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Data;

namespace TelerikAcademy.Client
{
    class Program
    {
        static TelerikAcademyEntities1 db = new TelerikAcademyEntities1();

        static void Main(string[] args)
        {
            //NoobSelect();
            //RightSelect();

            //NoobToList();
            //RightToList();
        }

        //1.Using Entity Framework write a SQL query to select all employees from the Telerik Academy database 
        //and later print their name, department and town. Try the both variants: with and without .Include(…).
        //Compare the number of executed SQL statements and the performance.

        public static void NoobSelect()
        {
            var empl = db.Employees.ToList();

            foreach (var emp in empl)
            {
                Console.WriteLine("{0} | {1} | {2}", emp.FirstName, emp.Department.Name, emp.Address.Town.Name);
            }
        }

        public static void RightSelect()
        {
            foreach (var emp in db.Employees.Include("Department").Include("Address").Include("Address.Town"))
            {
                Console.WriteLine("{0} | {1} | {2}", emp.FirstName, emp.Department.Name, emp.Address.Town.Name);
            }
        }

        //2.Using Entity Framework write a query that selects all employees from the Telerik Academy database,
        //then invokes ToList(), then selects their addresses, then invokes ToList(), then selects their towns,
        //then invokes ToList() and finally checks whether the town is "Sofia". Rewrite the same in more 
        //optimized way and compare the performance.
        public static void NoobToList()
        {
            var empl = db.Employees.ToList()
                .Select(x => x.Address).ToList()
                .Select(t => t.Town).ToList()
                .Where(t => t.Name == "Sofia");

            foreach (var t in empl)
            {
                Console.WriteLine(t);
            }
        }

        public static void RightToList()
        {
            var empl = db.Employees
                .Select(x => x.Address)
                .Select(t => t.Town)
                .Where(t => t.Name == "Sofia");

            foreach (var t in empl)
            {
                Console.WriteLine(t);
            }
        }
    }
}
