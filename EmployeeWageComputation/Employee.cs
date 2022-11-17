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
            const int Rate_Per_Hour = 20;
            int EmpHrs;
            int EmpWage;
            for (int i = 0; i < Working_Day_Per_Month; i++)
            {
                //UC3
                Random random = new Random();
                int Empcheck = random.Next(0, 3);
                switch (Empcheck)
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
            }
             EmpWage = EmpHrs * Rate_Per_Hour;
                Console.WriteLine("Employee Wage is " + EmpWage);
                TotalEmpWage += EmpWage;
        }
    }
}
