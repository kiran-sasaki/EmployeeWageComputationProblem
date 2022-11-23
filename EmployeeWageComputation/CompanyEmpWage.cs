using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        public string company;
        public int ratePerHrs;
        public int numberOfWorkingDay;
        public int totalWorkingHrs;
        public int totalWage;

        public CompanyEmpWage(string company, int ratePerHrs, int numberOfWorkingDay, int totalWorkingHrs)
        {
            this.company = company;
            this.ratePerHrs = ratePerHrs;
            this.numberOfWorkingDay = numberOfWorkingDay;
            this.totalWorkingHrs = totalWorkingHrs;
        }

        public void setTotalEmpWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        public string toString()
        {
            return "Total emp wage for company : " + this.company + " is: " + this.totalWage;
        }
    }
}
