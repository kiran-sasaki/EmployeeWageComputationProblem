namespace EmployeeWageComputation
{
    class Employee
    {
        public static void Main(string[] args)
        {
            //Main
            //Console.WriteLine("Welcome to EmployeeWage Computation");
            EmpWageForMultipleCompany ferrari = new EmpWageForMultipleCompany("ferrari", 20, 2, 10);
            EmpWageForMultipleCompany lamborighini = new EmpWageForMultipleCompany("Lamborghini", 30, 5, 20);
            ferrari.calculateEmployeeWage();
            lamborighini.calculateEmployeeWage();
            Console.WriteLine(ferrari.ToString()); ;
        }
    }
}
