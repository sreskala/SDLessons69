using System;
using System.Collections.Generic;
using Challenge_KomodoInsurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoInsuranceRepoTests
{
    [TestClass]
    public class RepoTest
    {
        [TestMethod]
        public void AddCustomer_ShouldReturnTrue()
        {
            KomodoCustomer customer = new KomodoCustomer(12, "Jones", 30, new DateTime(2000, 10, 3));

            KomodoRepo repo = new KomodoRepo();

            bool addResult = repo.AddCustomer(customer);

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetCustomers_ShouldGetCorrectCustomerBase()
        {
            KomodoCustomer customer = new KomodoCustomer(12, "Jones", 30, new DateTime(2000, 10, 3));
            KomodoRepo repo = new KomodoRepo();

            repo.AddCustomer(customer);

            List<KomodoCustomer> customerBase = repo.GetKomodoCustomers();

            bool hasContent = customerBase.Contains(customer);

            Assert.IsTrue(hasContent);
        }

        [TestMethod]
        public void GetCustomerById_ShouldGetCorrectCustomer()
        {
            KomodoCustomer customer1 = new KomodoCustomer(12, "Jones", 30, new DateTime(2000, 10, 3));
            KomodoCustomer customer2 = new KomodoCustomer(13, "Smith", 25, new DateTime(1995, 8, 2));

            KomodoRepo repo = new KomodoRepo();

            repo.AddCustomer(customer1);
            repo.AddCustomer(customer2);

            KomodoCustomer returnCustomer = repo.GetKomodoCustomerById(13);

            Assert.AreEqual("Smith", returnCustomer.LastName);
        }

        [TestMethod]
        public void UpdateCustomer_ShouldReturnTrue()
        {
            KomodoCustomer customer1 = new KomodoCustomer(12, "Jones", 30, new DateTime(2000, 10, 3));

            KomodoRepo repo = new KomodoRepo();

            repo.AddCustomer(customer1);

            bool wasUpdated = repo.UpdateCustomerInformation(12, "Smith", 31);

            Assert.AreEqual(customer1.LastName, "Smith");
            Assert.AreEqual(customer1.Age, 31);
            Assert.IsTrue(wasUpdated);
        }

        [TestMethod]
        public void DeleteCustomer_ShouldReturnTrue()
        {
            KomodoCustomer customer1 = new KomodoCustomer(12, "Jones", 30, new DateTime(2000, 10, 3));

            KomodoRepo repo = new KomodoRepo();

            repo.AddCustomer(customer1);

            bool wasDeleted = repo.DeleteCustomerInformation(customer1);

            Assert.IsTrue(wasDeleted);
        }
    }
}
