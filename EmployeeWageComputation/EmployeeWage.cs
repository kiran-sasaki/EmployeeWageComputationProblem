using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    //UC7 Created A class With Name EmployeeWage
    public static class EmployeeWage
    {
        //Created Method with Name CalculateWage
        public static void CalculateWage()
        {
            //Constant Values
            const int fullTime = 1;
            const int partTime = 2;
            const int Rate_Per_Hour = 20;
            const int MAX_Working_Day_Per_Month = 20;
            const int MAX_Working_Hrs_Per_Month = 100;
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_Working_Hrs_Per_Month && totalWorkingDays <= MAX_Working_Day_Per_Month)
            {
                //UC3
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                Console.WriteLine("Days " + totalWorkingDays + "EmpHrs: " + empHrs);
            }
            //Formula For Getting Total Employee Wage
            totalEmpWage = totalEmpHrs * Rate_Per_Hour;
            Console.WriteLine("Total Employee Wage is " + totalEmpWage);
        }
    }
}
