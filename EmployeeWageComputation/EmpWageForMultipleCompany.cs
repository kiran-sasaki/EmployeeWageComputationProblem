using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageForMultipleCompany : IComputeWage
    {
        public const int fullTime = 2;
        public const int partTime = 1;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        List<CompanyEmpWage> companyEmpWageList = new List<CompanyEmpWage>();
        public EmpWageForMultipleCompany()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int ratePerHrs, int numberOfWorkingDay, int totalWorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, ratePerHrs, numberOfWorkingDay, totalWorkingHrs);
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, ratePerHrs, numberOfWorkingDay, totalWorkingHrs);
            numOfCompany++;
            companyEmpWageList.Add(companyEmpWage);
            foreach(CompanyEmpWage companyEmp in companyEmpWageList)
            {
                Console.WriteLine(companyEmp.company);
            }
        }
        public void computeWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.calculateEmployeeWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        public int calculateEmployeeWage(CompanyEmpWage companyEmpWage)
        {
            //variable
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;
            int workingHours;
            while (totalEmpHrs != companyEmpWage.totalWorkingHrs && totalWorkingDay != companyEmpWage.numberOfWorkingDay)
            {
                totalWorkingDay++;
                Random obj = new Random();
                int empCheck = obj.Next(3);
                switch (empCheck)
                {
                    case fullTime:
                        workingHours = 8;
                        break;
                    case partTime:
                        workingHours = 4;
                        break;
                    default:
                        workingHours = 0;
                        break;
                }
                //Formula For Daily Employee Wage
                totalEmpHrs += workingHours;
                Console.WriteLine("day " + totalWorkingDay + " Hrs is " + workingHours);
            }
            return totalEmpHrs * companyEmpWage.ratePerHrs;
        }

    }
}
