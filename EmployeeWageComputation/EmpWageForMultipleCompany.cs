using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageForMultipleCompany
    {
        public const int fullTime = 2;
        public const int partTime = 1;
        private string company;
        private int ratePerHrs;
        private int numberOfWorkingDays;
        private int totalWorkingHrs;
        private int totalEmpWage;
        //Paramterized Constructor
        public EmpWageForMultipleCompany(string company, int ratePerHrs, int numberOfWorkingDay, int totalWorkingHrs)
        {
            this.company = company;
            this.ratePerHrs = ratePerHrs;
            this.numberOfWorkingDays = numberOfWorkingDay;
            this.totalWorkingHrs = totalWorkingHrs;
        }
        public void MultipleCompanyEmpWage()
        {
            //Variable Declaration
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs != this.totalWorkingHrs && totalWorkingDays != this.numberOfWorkingDays)
            {
                totalWorkingDays++;
                //Random Intialization
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case fullTime:
                        empHrs = 8;
                        break;
                    case partTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                //Formula For Getting daily Employee Wage
                totalEmpHrs += empHrs;
                Console.WriteLine("Days " + totalWorkingDays + "EmpHrs: " + totalEmpHrs);
            }
            //Formula For Getting Total Employee Wage
            int totalEmpWage = totalEmpHrs * ratePerHrs;
            Console.WriteLine("Total Emp Wage for company: " + company + " is " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for campny: " + this.company + " is " + this.totalEmpWage;
        }
    }
}
