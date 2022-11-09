namespace EmployeeWageComputation
{
    class Employee
    {
        public static void Main(string[] args)
        {
            //Main
            Console.WriteLine("Welcome to EmployeeWage Computation");
            //UC1
            int FullTime = 1;
            int EmpHrs;
            int Rate_Per_Hour = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == FullTime)
            {
                Console.WriteLine("empolyee is FullTime");
                EmpHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                EmpHrs = 0;
            }
            int TotalEmpWage = EmpHrs * Rate_Per_Hour;
            Console.WriteLine("Employee Wage is "+TotalEmpWage);
            Console.ReadKey();
        }
    }
}
