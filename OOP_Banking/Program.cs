using System;

namespace OOP_Banking {

    class Program {

        static void Main(string[] args) {

            Account acct = new Account();           // calling default constructor from Account class / new instance
            acct.Number = "1001";                          // (variable.propertyname) represent the instance of the Account class
            acct.Name = "Test Acount";
            /*acct.Balance = 0; */                // can't insert the number into balabce / initially set to 0
            acct.Deposit(20);                      //
            acct.Withdraw(10);
            decimal balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Deposit(-10);              // test for negative path - You can't deposit a neg. nbr
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Deposit(-10);              // test for negative path / produce error message
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Deposit(20);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");
        }
    }
}
