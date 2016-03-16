using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public abstract class Employee
    {
        private String name;
        private String ssn;
        public Employee(String name, String ssn)
        {
            this.name = name;
            this.ssn = ssn;
        }
        public abstract float calculatePay();
    }
}
