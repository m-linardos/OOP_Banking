using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {
    public class Savings : Account {                    // ':' indicates that (left) of class is inherited from (right) class
                                                        //able to access public properties and methods
        public double Intrate { get; set; } = 0.03;     // add interest rate; it's unique to savings; default - 3%
        
        public bool ChangeRate(double chgRate) {        // Homework 7/29    //////////////////////////
            if((this.Intrate + chgRate) < 0) {          // don't want to have neg. int rate //////////
                return false;                           //                  //////////////////////////
            }                                           //                  //////////////////////////
            this.Intrate += chgRate;                    //                  //////////////////////////
            return true;                                // Homework 7/29    //////////////////////////
        }

        public  override string Print() {   // override allows it to print interest rates              // goget our print data and tack on interest rate  // override added to class that is inheriting from parent / Polymorphism
            return base.Print() + $" | {Intrate}";      // 'base' tells it reference the method in the parent class
        }
        // interest = .03/12 x months x balance
        public void PayInterest(decimal amountOfInterest) {
            this.Deposit(amountOfInterest);
        }
        public decimal CalcInterest(int months) {
            double interestToBePaid = 
                this.Intrate / 12 * months * (double)this.GetBalance();
            return (decimal)interestToBePaid;
        }

    } 
}
