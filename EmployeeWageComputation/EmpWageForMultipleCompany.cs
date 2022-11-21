using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public static class EmpWageForMultipleCompany
    {
        public const int fullTime = 2;
        public const int partTime = 1;
        //Parameterized Method
        public static int MultipleCompanyEmpWage(string company, int Rate_Per_Hour, int MAX_Working_Hrs_Per_Month, int MAX_Working_Day_Per_Month)
        {
            //Variable Declaration
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_Working_Hrs_Per_Month && totalWorkingDays <= MAX_Working_Day_Per_Month)
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
            int totalEmpWage = totalEmpHrs * Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
