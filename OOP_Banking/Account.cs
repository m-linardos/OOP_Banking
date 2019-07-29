using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {

    public class Account {

        public string Number { get; set; }
        /*public*/
        private decimal Balance { get; set; } = 0.0M;   //  changed public to private / numbers with decimals are doubles and floats / add 'M' to it to treat as a decimal, not a float / Can also be '0'
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;      // default true


        public virtual string Print() {     // virtual
            return $"{this.Number} | {this.Balance} | {this.Name}";     // all properties are in savings and money market
        }

        public bool TransferTo(Account ToAccount, decimal Amount) { // add functionality for transfering $ from 1 acct to another / ToAccount can be Savings, SavingsChild, MoneyMarket, or MoneyMarketChild / To Account is an instance of an Account
            bool success = this.Withdraw(Amount);
                if(success) {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;    // if get to this line, we know something went wrong
        }
        public bool /*void*/ Deposit(decimal Amount) {                    // parameter for amount
            this.Balance += Amount;
           
            if (Amount <= 0) {
                Console.WriteLine("Deposit amount must be greater than 0");
            } else {
                this.Balance += Amount;
                return true;// p4 added
            }
            return false; // p4 added
        }
    
        public bool /*void*/ Withdraw(decimal Amount) {
        //    if(this.Balance >= Amount) {            
        //    this.Balance -= Amount;
        //    }
            if (Amount <= 0) {
                Console.WriteLine("Deposit amount must be greater than 0");
                return false;       // p4 added
            }
            else {
                if(this.Balance >= Amount) {
                    this.Balance -= Amount;
                    return true;        // p4 added
                }
            }
            return false;           // p4 added
        }

        public decimal GetBalance() {
            return this.Balance;
        }
    }
}
