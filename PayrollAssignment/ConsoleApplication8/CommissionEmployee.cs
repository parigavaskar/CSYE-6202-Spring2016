using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class CommissionEmployee : Employee
    {
        private float grossSales;
        private float commissionRate;
        public CommissionEmployee(String name, String ssn, float grossSales, float commissionRate) : base(name, ssn)
        {
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;

        }

      

        public override float calculatePay()
        {
            return commissionRate * grossSales;
        }
    }
}
