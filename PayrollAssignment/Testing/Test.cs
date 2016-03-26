using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication8;


namespace Testing
{
    [TestFixture]
    public class Test
    {

        [Test]
        public void When_CalculateSalary_SalariedEmployee_ResultShouldBeEqualToWeeklyWage()

        {
           
            //prepare
            var expected = 80;
            //action
            SalariedEmployee se = new SalariedEmployee("John Smith", "111 - 11 - 1111", 80);
            var actual = se.calculatePay();
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_hoursgreaterthan40_salaryshouldbetimes()
        {
            
           
            var expected = 550;
            HourlyEmployee he= new HourlyEmployee("Pari Gavaskar", "222-22-2222", 50, 10);
            var actual = he.calculatePay();
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_calculatepayforsalariedcommission_salaryshouldbeaddedtocommission()
        {


            var expected = 1000;
            SCEmployee sc = new SCEmployee("Pari Gavaskar", "333-33-3333", 1000, 0.5f, 500);
            var actual = sc.calculatePay();
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_incorrectssn_callsalariedagain()
        {

            Program p = new Program();
            var expected = false;
            String name = "Pari Gavaskar";
            String ssn = "333";
            float salary = 1000;
            SalariedEmployee se = new SalariedEmployee(name,ssn,salary);
            var actual = p.isValidSalaried(name,ssn,salary);
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_incorrectname_returnfalse()
        {

            Program p = new Program();
            var expected = false;
            String name = "Pari gavaskar";
            String ssn = "333-33-3333";
            float salary = 1000;
            SalariedEmployee se = new SalariedEmployee(name, ssn, salary);
            var actual = p.isValidSalaried(name, ssn, salary);
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_incomplete_returnfalse()
        {

            Program p = new Program();
            var expected = false;
            String name = "Pari gavaskar";
            String ssn = "333-33-3333";
            float salary = 1000;
            SalariedEmployee se = new SalariedEmployee(name, ssn, salary);
            var actual = p.isValidSalaried("", "", 0 );
            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

       

    }
}
