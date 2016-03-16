using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class SalariedEmployee : Employee
    {
        private float salary;
        public SalariedEmployee(String name, String ssn, float salary) : base(name,ssn)
        {
            this.salary = salary;
        }

        public override float calculatePay()
        {
            return salary;
        }

       
    }
}
