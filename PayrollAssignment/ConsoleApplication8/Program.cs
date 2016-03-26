using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
   public class Program
    {
        String sename, scname, cename, hename;
        string ssn1, ssn2, ssn3, ssn4;
        float salary;
        float hourlyWage;
        float hoursWorked;
        float grossSales;
        float commissionRate;
        float baseSalary;
        SalariedEmployee se = null;
        HourlyEmployee he = null;
        CommissionEmployee ce = null;
        SCEmployee sc = null;
        public SalariedEmployee salaried()
        {
            Console.Write("Salaried employee: ");
            sename = Console.ReadLine();
            Console.Write("Social security number: ");
            ssn1 = Console.ReadLine();
            Console.Write("Weekly salary: $ ");
            salary = float.Parse(Console.ReadLine());
            
            if (isValidSalaried(sename,ssn1,salary))
            {
                se = new SalariedEmployee(sename, ssn1, salary);
                return se;
            }
            else
            {
                salaried();
            }
           
            return se;

        }
        public bool isValidSalaried(String sename, String ssn1, float salary)
        {
            Regex regex = new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$");
           // Match match = regex.Match(sename.Trim());
            if ((new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$").Match(sename).Success) && (new Regex(@"^\d{3}-\d{2}-\d{4}$").Match(ssn1).Success) && (new Regex(@"^[0-9]*(?:\.[0-9]*)?$").Match(salary.ToString()).Success))
            {
                return true;
            }
            return false;
              
        }

        public HourlyEmployee hourly()
        {
            Console.Write("Hourly employee: ");
            hename = Console.ReadLine();
            Console.Write("Social security number: ");
            ssn2 = Console.ReadLine();
            Console.Write("Hourly wage: $");
            hourlyWage = float.Parse(Console.ReadLine());
            Console.Write("Hours worked: ");
            hoursWorked = float.Parse(Console.ReadLine());
            if (isValidHourly())
            {
                he = new HourlyEmployee(hename, ssn2, hoursWorked, hourlyWage);
                return he;
            }
            else
            {
                hourly();
            }
            return he;
        }
        

        public  bool isValidHourly()
        {
            if ((new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$").Match(hename).Success) && (new Regex(@"^\d{3}-\d{2}-\d{4}$").Match(ssn2).Success) && (new Regex(@"^[0-9]*(?:\.[0-9]*)?$").Match(hourlyWage.ToString()).Success) && (new Regex(@"^[0-9]*(?:\.[0-9]*)?$").Match(hoursWorked.ToString()).Success))
                return true;
            else return false;
        }

        public CommissionEmployee commission()
        {
            Console.Write("Commission employee: ");
            cename = Console.ReadLine();
            Console.Write("Social security number: ");
            ssn3 = Console.ReadLine();
            Console.Write("Gross sales: $");
            grossSales = float.Parse(Console.ReadLine());
            Console.Write("Commission rate:");
            commissionRate = float.Parse(Console.ReadLine());
            if (isValidCommision())
            {
                ce = new CommissionEmployee(cename, ssn3, grossSales, commissionRate);
                return ce;
            }
            else
            {
                commission();
            }
            return ce;
        }

        public  bool isValidCommision()
        {
            if ((new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$").Match(cename).Success) && (new Regex(@"^\d{3}-\d{2}-\d{4}$").Match(ssn3).Success) && (new Regex(@"^[0-9]*(?:\.[0-9]*)?$").Match(grossSales.ToString()).Success) && (new Regex(@"^[0-9]*(?:\.[0-9]*)?$").Match(commissionRate.ToString()).Success))
                return true;
            else return false;
        }

        public SCEmployee salc()
        {
            Console.Write("Base salaried commission employee: ");
            scname = Console.ReadLine();
            Console.Write("Social security number: ");
            ssn4 = Console.ReadLine();
            Console.Write("Gross sales: $");
            grossSales = float.Parse(Console.ReadLine());
            Console.Write("Commission rate:");
            commissionRate = float.Parse(Console.ReadLine());
            Console.Write("Base salary: $");
            baseSalary = float.Parse(Console.ReadLine());
            if (isValidSalCommision(scname, ssn4, grossSales, commissionRate, baseSalary))
            {
                sc = new SCEmployee(scname, ssn4, grossSales, commissionRate, baseSalary);
                return sc;
            }
            else
            {
                salc();
            }
            return sc;
        }

        public bool isValidSalCommision(String name, string ssn, float grossSales, float commissionRate, float baseSalary)
        {
            if ((new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$").Match(scname).Success) && (new Regex(@"^\d{3}-\d{2}-\d{4}$").Match(ssn4).Success) && (new Regex(@"^[0-9]*(?:\.[0-9]*)?$").Match(baseSalary.ToString()).Success) && (new Regex(@"^[0-9]*(?:\.[0-9]*)?$").Match(commissionRate.ToString()).Success) &&  (new Regex(@"^[0-9]*(?:\.[0-9]*)?$").Match(grossSales.ToString()).Success))
                return true;
            else return false;
        }

       public static void Main(string[] args)
        {

            Program p = new Program();

            SalariedEmployee se = p.salaried();
           
            if (se!=null)
            {

                float sePay = se.calculatePay();
                Console.WriteLine("Earned: $" + sePay);
                Console.WriteLine();
                Console.WriteLine();
            }
            
         

            HourlyEmployee he = p.hourly();
            if (he!=null)
            {
                float hePay = he.calculatePay();
                Console.WriteLine("Earned: $" + hePay);
                Console.WriteLine();
                Console.WriteLine();
            }
           

            CommissionEmployee ce = p.commission();
            if (ce!=null)
            {
                float cePay = ce.calculatePay();
                Console.Write("Earned: $" + cePay);
                Console.WriteLine();
                Console.WriteLine();
            }
            

            SCEmployee sc = p.salc();
            if (sc!=null)
            {
                float scPay = sc.calculatePay();
                Console.Write("Earned: $" + scPay);
                Console.ReadLine();
            }
           


        }
       
        
        



        }
    }

