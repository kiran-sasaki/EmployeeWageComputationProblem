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
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companytoEmpWageMap;
        public EmpWageForMultipleCompany()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companytoEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int ratePerHrs, int numberOfWorkingDay, int totalWorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, ratePerHrs, numberOfWorkingDay, totalWorkingHrs);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companytoEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
            }
        }
        public int computeWage(CompanyEmpWage companyEmpWage)
        {
            //variable
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;
            int workingHours;
            int empwage;
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
                //UC13
                //Formula For Daily Employee Wage
                empwage = workingHours * companyEmpWage.ratePerHrs;
                Console.WriteLine("empwage "+empwage+" Working hours "+workingHours);
                totalEmpHrs += workingHours;
                Console.WriteLine("day " + totalWorkingDay + " Hrs is " + workingHours);
            }
            return totalEmpHrs * companyEmpWage.ratePerHrs;
        }
        public int GetTotalWage(string company)
        {
            return this.companytoEmpWageMap[company].totalWage;
        }

    }
}
