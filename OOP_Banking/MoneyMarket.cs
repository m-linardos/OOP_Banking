using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {
    public class MoneyMkt : Account {
        public double MMRate { get; set; } = 0.03;

        public override string Print() {    // override  allows it to print interest rates               // go get our print data and tack on interest rate
            return base.Print() + $" | {MMRate}";      // 'base' tells it reference the method in the parent class
        }
        public void PayInterest(int months) {
            double InterestToBePaid =                                       // calculate interest
                this.MMRate / 12 * months * (double)this.GetBalance();      // calculate interest
            decimal intToBePaidAsDecimal = (decimal)InterestToBePaid;       // turns double to decimal
                this.Deposit(intToBePaidAsDecimal);
        }
        //public double Intrate { get; set; } = 0.03;

        //public void PayInterest(decimal amountOfInterest) {
        //    this.Deposit(amountOfInterest);
        //}
        //public decimal CalcInterest(int months) {
        //    double interestToBePaid =
        //        this.Intrate / 12 * months * (double)this.GetBalance();
        //    return (decimal)interestToBePaid;
        //}
    }
}
