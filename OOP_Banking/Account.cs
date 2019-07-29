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


        public void Deposit(decimal Amount) {                    // parameter for amount
            this.Balance += Amount;
            if (Amount <= 0) {
                Console.WriteLine("Deposit amount must be greater than 0");
            } else {
                this.Balance += Amount;
            }

        }
    }
        //public void Withdraw(decimal Amount) {
        //    if(this.Balance >= Amount) {            
        //    this.Balance -= Amount;
        //    }
            if (Amount <= 0) {
                Console.WriteLine("Deposit amount must be greater than 0");
            }
            else {
                if(this.Balance >= Amount) {
        this.Balance -= Amount;                
                }
            }
        }

        public decimal GetBalance() {
            return this.Balance;
        }
    }
}
