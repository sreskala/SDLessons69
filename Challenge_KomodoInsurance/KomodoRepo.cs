using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_KomodoInsurance
{
    public class KomodoRepo
    {

        //setting private repo field
        private List<KomodoCustomer> _customerDirectory = new List<KomodoCustomer>();

        //Add method - or Create from CRUD
        public bool AddCustomer(KomodoCustomer customer)
        {
            int startingCount = _customerDirectory.Count;

            _customerDirectory.Add(customer);

            bool wasAdded = startingCount < _customerDirectory.Count ? true : false;

            return wasAdded;
        }

        //Get method - or Read from CRUD
        public List<KomodoCustomer> GetKomodoCustomers()
        {
            return _customerDirectory;
        }

        //Get Customer by ID
        public KomodoCustomer GetKomodoCustomerById(int id)
        {
            //setup a foreach loop
            foreach(KomodoCustomer customer in _customerDirectory)
            {
                if (id == customer.CustomerID)
                {
                    return customer;
                }
            }

            return null;
        }

        //Update Customer Information
        public bool UpdateCustomerInformation(int id, string lastName, int age)
        {
            //first get customer by id
            KomodoCustomer customer = GetKomodoCustomerById(id);

            if(customer != null)
            {
                customer.LastName = lastName;
                customer.Age = age;
                return true;
            } else
            {
                return false;
            }
        }

        //Delete method
        public bool DeleteCustomerInformation(KomodoCustomer customer)
        {
            bool isDeleted = _customerDirectory.Remove(customer);
            return isDeleted;
        }
    }
}
