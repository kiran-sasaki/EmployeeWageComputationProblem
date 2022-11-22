namespace EmployeeWageComputation
{
    class Employee
    {
        public static void Main(string[] args)
        {
            //Main
            //Console.WriteLine("Welcome to EmployeeWage Computation");
            EmpWageForMultipleCompany empWageBuilder = new EmpWageForMultipleCompany();
            empWageBuilder.addCompanyEmpWage("Mercedes", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Hass", 10, 4, 20);
            empWageBuilder.computeWage();
        }
    }
}
