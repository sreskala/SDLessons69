using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_KomodoInsurance
{
    public class KomodoCustomer
    {
        //unique customer ID
        private int _customerID;

        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        //last name
        public string LastName { get; set; }

        //age
        public int Age { get; set; }

        //enrollment date
        public DateTime EnrollmentDate { get; }

        //years using Komodo Insurance
        public int YearsAsCustomer
        {
            get
            {
                TimeSpan customerSpan = DateTime.Now - EnrollmentDate;
                double timeInYears = customerSpan.TotalDays / 365.241;
                int yearsInt = Convert.ToInt32(Math.Floor(timeInYears));
                return yearsInt;
            }
        }

        public KomodoCustomer(int id, string lastName, int age, DateTime enrollment)
        {
            CustomerID = id;
            LastName = lastName;
            Age = age;
            EnrollmentDate = enrollment;
        }

        public string SendMessage()
        {
            int yearsAsCustomer = YearsAsCustomer;

            if(yearsAsCustomer >= 1 && yearsAsCustomer <= 5)
            {
                return "Sending thank you note.";
            } else if(yearsAsCustomer > 5)
            {
                return "Thank you for being a Gold member!";
            } else
            {
                return "Get a year under your belt.";
            }
        }
    }
}
