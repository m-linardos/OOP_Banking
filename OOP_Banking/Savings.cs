using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {
    public class Savings : Account {                    // ':' indicates that (left) class is inherited from (right) class
                                                        //able to access public properties and methods
        public double Intrate { get; set; } = 0.03;     // add interest rate; it's unique to savings; default - 3%
        
        public bool ChangeRate(double chgRate) {
            if((this.Intrate + chgRate) < 0) {
                return false;
            }
            this.Intrate += chgRate;
            return true;
        }

        public /*virtual*/ override string Print() {   // override allows it to print interest rates              // goget our print data and tack on interest rate
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
