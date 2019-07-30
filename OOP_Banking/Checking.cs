using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {          
/// ///
/* CREATE CHECKING ACCOUNT FUNCTION WITH CHECK NUMBER AND */
    public class Checking : Account {

        private int LastCheckNumber { get; set; } = 0;      // 'private' so that no other class can do anything with it
        

            
            
        public bool Pay(int CheckNumber, decimal Amount) {
            bool success = this.Withdraw(Amount);
            if (success) {
                this.LastCheckNumber= CheckNumber;
                return true;
            }
            return false;
        }

        public override string Print() {
            return base.Print() + $" | { LastCheckNumber}";
                
            }
        }




    }

