using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance.People
{
    //            inheritance
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }

        public Employee(int numberID)
        {
            EmployeeNumber = numberID;
        }
    }


    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
        public HourlyEmployee(int number) : base(number)
        {
            Console.WriteLine("Hourly employee hired");
        }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalaryEmployee(int number, decimal salary) : base(number)
        {
            Salary = salary;
        }
    }
}
