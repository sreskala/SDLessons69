using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces.Currency
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
        }

        //This calls it into test method without having to type it each time
        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.13m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(532.17m));

            decimal expectedDebt = 9000.13m - 1 - 532.17m;

            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            ICurrency dollar = new Dollar();
            ICurrency ePayment = new ElectronicPayment(317.2m);

            Transaction firstTransaction = new Transaction(dollar);
            Transaction secondTransaction = new Transaction(ePayment);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());
        }
    }
}
