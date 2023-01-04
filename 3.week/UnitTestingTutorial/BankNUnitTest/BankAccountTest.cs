using Bank;
using NUnit.Framework;
using System;

namespace BankNUnitTest
{
    public class BankAccountTest
    {
        private BankAccount account;

        [SetUp]
        public void SetUp()
        {
            var account = new BankAccount(1000);
        }

        //This test is for adding money method
        [Test]
        public void Adding_Funds_Updates_Balance()
        {
            //SET UP yarattýgýmýz için bu kýsma gerek kalmadý.
            //ARRANGE
            //var account = new BankAccount(1000);

            //ACT
            account.Add(500);

            //ASSERT, write the result that we expect
            Assert.AreEqual(1500, account.Balance);
        }

        //NEGATIVE --- Testing for negative values-it doesnt updates the balance
        [Test]
        public void Adding_Negative_Funds_Throws()          //why throws?
        {
            //ARRANGE
            //var account = new BankAccount(1000);

            //ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-500));    //test hata verdi, throws out of rane erroru ama zaten bunu biz throw demiþtik þimdi "Throws<ArgumentOutOfRangeException>(() => account.Add(-500));" diyerek düzelttik 
        }











        //This test is for withdrawing
        [Test]
        public void Withdraw_Funds_Updates_Balance()
        {
            //ARRANGE
           // var account = new BankAccount(1000);

            //ACT
            account.Withdraw(500);

            //ASSERT, write the result that we expect
            Assert.AreEqual(500, account.Balance);
        }

        //NEGATIVE -- 
        [Test]
        public void Withdraw_Negative_Funds_Throws()
        {
            //ARRANGE
            //var account = new BankAccount(1000);

            //ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-500));
        }

        //MORE THAN BALANCE -- withdrawing, will give error again, so we fixed it but using "Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(2000));" code
        [Test]
        public void Withdraw_More_Than_Balance_Throws()
        {
            //ARRANGE
            //var account = new BankAccount(1000);  çünkü baþa set up kýsmý ekledik gerek yok buna daha clean code.

            //ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(2000));
        }








        //This test is for transfering money
        [Test]
        public void Transfer_Funds_Updates_Both_Account()
        {
            //ARRANGE
            //var account = new BankAccount(1000);
            var otherAccount = new BankAccount();

            //ACT
            account.TransferFundsTo(otherAccount, 500);

            //ASSERT, write the result that we expect
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, otherAccount.Balance);
        }


        //NON-EXISTENT ACCOUNT-Transfering money to,
        [Test]
        public void Transfering_To_Non_Existing_Account_Throws()
        {
            //ARRANGE
            //var account = new BankAccount(1000);

            //ACT + ASSERT
            Assert.Throws<ArgumentNullException>(() => account.TransferFundsTo(null, 2000));
            
        }
    }
}