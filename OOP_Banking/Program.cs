using System;

namespace OOP_Banking {

    class Program {

        static void Main(string[] args) {

            Savings sav1 = new Savings();

            

            /////////// p2. Create instance of savings
            Savings sav = new Savings();        // p2. Create instance of savings see vid 072919 part 4
            sav.Number = "1002";
            //sav.Balance = 0;           // p2. can't access it because it is private
            sav.Name = "Savings 1";
            sav.Intrate = 0.1;

            //****                                                                     
            // ** Calculate interest rate for 12 mos; 6 mos **  see vid 072919 part 4
            //****


            ///////////  p2. Create instance of Money Market Acct **  see vid 072919 part 4
            MoneyMkt MMkt = new MoneyMkt();
            MMkt.Number = "1003";
            MMkt.Name = "MoneyMarket 1";
            MMkt.Intrate = 0.1;

            Account[] accounts = new Account[] { sav1, MMkt };
                foreach(Account acct in accounts) {
                Console.WriteLine(acct.Print());
            }
            Console.WriteLine(sav1.Print());
            Console.WriteLine(MMkt.Print());

            sav.Deposit(200);
            sav.Withdraw(100);
            decimal interestToBePaid = sav.CalcInterest(12);
            sav.PayInterest(interestToBePaid);
            decimal savbal = sav.GetBalance();
            Console.WriteLine($"Savings balance is {savbal} ");
            /***/
            // ** Add own tests for negative entries, etc. **  see vid 072919 part 4
            /***/


            

            //****                                                                     
            // ** Calculate interest rate for 12 mos; 6 mos **  see vid 072919 part 4
            //****

            MMkt.Deposit(200);
            MMkt.Withdraw(100);
            interestToBePaid = MMkt.CalcInterest(12);
            MMkt.PayInterest(interestToBePaid);
            decimal MMktbal = sav.GetBalance();
            Console.WriteLine($"Money Market balance is {MMktbal} ");
            /***
            // ** Add own tests for negative entries, etc.**  see vid 072919 part 4
            /***/


            Console.WriteLine(sav1.Print());        // printing out what comes back for these accounts
            Console.WriteLine(MMkt.Print());

            bool ItWorkded = mm.TransferTo(sav1, 50);
            Console.WriteLine($"Money Market balance is {MMkt.GetBalance()} ");
            Console.WriteLine($"Money Market balance is {sav1.GetBalance()} ");





            //****                                                                     
            // ** Add own tests for negative entries, etc. **  see vid 072919 part 3
            //****




            //Account acct = new Account();           // calling default constructor from Account class / new instance
            //acct.Number = "1001";                          // (variable.propertyname) represent the instance of the Account class
            //acct.Name = "Test Acount";
            ///*acct.Balance = 0; */                // can't insert the number into balabce / initially set to 0

            //acct.Deposit(20);                      //
            //acct.Withdraw(10);
            //decimal balance = acct.GetBalance();
            //Console.WriteLine($"Account balance is {balance} (should be 10)");

            //acct.Deposit(-10);              // test for negative path - You can't deposit a neg. nbr
            //balance = acct.GetBalance();
            //Console.WriteLine($"Account balance is {balance} (should be 10)");

            //acct.Deposit(-10);              // test for negative path / produce error message
            //balance = acct.GetBalance();
            //Console.WriteLine($"Account balance is {balance} (should be 10)");

            //acct.Deposit(20);
            //balance = acct.GetBalance();
            //Console.WriteLine($"Account balance is {balance} (should be 10)");
        }
    }
}
