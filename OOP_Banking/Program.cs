using System;

namespace OOP_Banking {

    class Program {

        static void Main(string[] args) {

            Checking ch1 = new Checking();      //// class exercise
            ch1.Number = "CH001";
            ch1.Name = "My checking account";
            ch1.Deposit(100);       // Deposit is a method not a variable, so the '=' sign is not used
            ch1.Pay(100, 20);       // ch1 class ex

            Savings sav1 = new Savings();
            sav1.Number = "SAV001";
            sav1.Name = "My savings account";
            sav1.ChangeRate(0.02);

            Savings sav2 = new Savings();
            sav2.Number = "SAV002";
            sav2.Name = "Christmas Fund";
            sav2.ChangeRate(0.04);


            /////////// part 2. Create instance of savings
            /*
             Savings sav = new Savings();        // p2. Create instance of savings see vid 072919 part 4
             sav.Number = "1002";
             //sav.Balance = 0;           // p2. can't access it because it is private
             sav.Name = "Savings 1";
             sav.Intrate = 0.1;
             */

            //****                                                                     
            // ** Calculate interest rate for 12 mos; 6 mos **  see vid 072919 part 4
            //****


            ///////////  p2. Create instance of Money Market Acct **  see vid 072919 part 4
            MoneyMkt MMkt = new MoneyMkt();
            MMkt.Number = "MM001";
            MMkt.Name = "My money market account";
            MMkt.Deposit(100);
            MMkt.MMRate = 0.05;
            MMkt.PayInterest(12);

            Account[] accounts = new Account[] { sav1, ch1, MMkt };        // Polymorphism exhibited  // ch1 class ex
                foreach(Account acct in accounts) {         // foreach like array of accounts
                Console.WriteLine(acct.Print());            // Can print off what we want (interest showing as it would for sav/MM)  1) place  'virtual' on line 18 parent(Account) 2) place 'override' on line 18-sav/9-MM of child(sav/MM)
            }
            // printing out what comes back for these accounts
            Console.WriteLine(sav1.Print());                //outside the foreach loop- saving has interest
            Console.WriteLine(MMkt.Print());
            Console.WriteLine(ch1.Print());     // ch1 class ex
                                                /*
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

            //MMkt.Deposit(200);
            //MMkt.Withdraw(100);
            //interestToBePaid = MMkt.CalcInterest(12);
            //MMkt.PayInterest(interestToBePaid);
            //decimal MMktbal = sav.GetBalance();
            //Console.WriteLine($"Money Market balance is {MMktbal} ");

            /***
            // ** Add own tests for negative entries, etc.**  see vid 072919 part 4
            /***/



            /*
               bool ItWorkded = mm.TransferTo(sav1, 50);
               Console.WriteLine($"Money Market balance is {MMkt.GetBalance()} ");
               Console.WriteLine($"Money Market balance is {sav1.GetBalance()} ");
           */




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
