namespace EmployeeWageComputation
{
    class Employee
    {
        public static void Main(string[] args)
        {
            //Main
            Console.WriteLine("Welcome to EmployeeWage Computation");
            //UC1
            const int FullTime = 1;
            //UC2
            const int PartTime =2;
            int Rate_Per_Hour = 20;
            int EmpHrs;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            //UC3
            switch (empCheck)
            {
                case FullTime:
                    EmpHrs = 8;
                    break;
                case PartTime:
                    EmpHrs = 4;
                    break;
                default:
                    EmpHrs = 0;
                    break;
            }
            int TotalEmpWage = EmpHrs * Rate_Per_Hour;
            Console.WriteLine("Employee Wage is "+TotalEmpWage);
            Console.ReadKey();
        }
    }
}
