namespace EmployeeWageComputation
{
    class Employee
    {
        public static void Main(string[] args)
        {
            //Main
            //Console.WriteLine("Welcome to EmployeeWage Computation");
            //Calling Class By ClassName And MethodName 
            //EmployeeWage.CalculateWage();
            EmpWageForMultipleCompany.MultipleCompanyEmpWage("Ferrari", 10, 100, 20);
            EmpWageForMultipleCompany.MultipleCompanyEmpWage("Mclaren", 20, 100, 30);
            Console.ReadKey();
        }
    }
}
