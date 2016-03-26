using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
   public class HourlyEmployee : Employee
    {
        private float hours;
        private float hourlyWage;
        public HourlyEmployee(String name, String ssn, float hours, float hourlyWage): base(name,ssn)
        {
            this.hours = hours;
            this.hourlyWage = hourlyWage;
        }
        public override float calculatePay()
        {
            if (hours>=1 && hours <= 40)
            {
                return hours * hourlyWage;
            }
            else return ((hours - 40) *(float) 1.5 * hourlyWage)+ (40*hourlyWage);
        }
    }
}
