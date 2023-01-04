using System;

namespace Bank
{
        public class BankAccount
        {
            private double balance;

            //1st constructor
            public BankAccount()
            {

            }


            //2nd constructor
            public BankAccount(double balance)
            {
                this.balance = balance;
            }


            //Property that returns the current balance
            public double Balance
            {
                get { return balance; }
                //Testing what happens if the balance returns 0;
                //get { return 0; }
            }


            //1st method-adding money to the account
            public void Add(double amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                balance += amount;
            }


            //2nd method that  that you withdraw
            public void Withdraw(double amount)
            {
                if (amount > balance)
                {
                    //Balance'ımdan daha büyük bi değer withdrawlarsam ama "out of range erroru verecek"
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount));
                }
                balance -= amount;
            }


            //3rd method to transfer money
            public void TransferFundsTo(BankAccount otherAccount, double amount)
            {
                if (otherAccount is null)
                {
                    throw new ArgumentNullException(nameof(otherAccount));
                }
                Withdraw(amount);
                otherAccount.Add(amount);
            }

        public static void Main()
        {
            BankAccount account = new BankAccount();
        }
    }
}
