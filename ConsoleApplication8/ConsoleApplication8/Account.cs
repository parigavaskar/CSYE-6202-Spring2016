using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Account
    {
        private String accNumber { get; set; }
        public Account(String accNumber)
        {
            this.accNumber = accNumber;
        }
        float bal = 0;
        
        
        public float withdraw(float amount)
        {
            bal = bal - amount;
            return bal;
        }
        public float deposit(float amount)
        {
            bal = bal + amount;
            return bal;
        }
        public float balance()
        {
            return bal;
        }

    }
}
