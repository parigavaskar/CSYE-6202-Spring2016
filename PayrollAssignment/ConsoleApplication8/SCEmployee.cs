using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class SCEmployee : Employee, IEmployee
    {
        private float grossSales;
        private float commissionRate;
        float basePay;
        public SCEmployee(String name, String ssn, float grossSales, float commissionRate, float basePay) : base(name,ssn)
        {
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
            this.basePay = basePay;
        }

        public float calculateBonus()
        {
            return commissionRate * grossSales;
        }

        public override float calculatePay()
        {
            return basePay + calculateBonus();
        }
    }
}
