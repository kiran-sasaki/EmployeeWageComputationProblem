using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IComputeWage
    {
        public void addCompanyEmpWage(string company, int ratePerHrs, int numberOfWorkingDay, int totalWorkingHrs);
        public void computeWage();
        public int calculateEmployeeWage(CompanyEmpWage companyEmpWage);
    }
}
