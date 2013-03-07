using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTask
{
    public class Worker : Human
    {
        //Fields
        private int weekSalary;
        private int workHourPerDay;
        private decimal salaryPerHour;
        //END Fields

        //Constructors
        public Worker(int weekSalary, int workHourPerDay, string firstName, string lastName, decimal salaryPerHour = 0)
            : base(firstName, lastName) //From Parent Class
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHourPerDay;
            this.SalaryPerHour = salaryPerHour; 
        }
        //END Constructors

        //Properties
        public int WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value > 0)
                {
                    this.weekSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int WorkHourPerDay
        {
            get { return this.workHourPerDay; }
            set
            {
                if (value > 0)
                {
                    this.workHourPerDay = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public decimal SalaryPerHour
        {
            get { return this.salaryPerHour; }
            set
            {
                if (value >= 0)
                {
                    this.salaryPerHour = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        //END Properties

        //Method
        public decimal MoneyPerHour()
        {
            decimal perHour = this.weekSalary / (decimal)this.workHourPerDay;
            return perHour;
        }

        //Override ToString()
        public override string ToString()
        {
            return String.Format("{0} {1} win {2:F2}", this.FirstName, this.LastName, this.salaryPerHour);
        }
        //END Override ToString()
    }
}