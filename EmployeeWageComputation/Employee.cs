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
            const int MAX_Working_Day_Per_Month = 20;
            const int MAX_Working_Hrs_Per_Month = 100;
            int EmpHrs=0;
            int TotalEmpWage = 0;
            int TotalEmpHrs = 0;
            int TotalWorkingDays = 0;
            while (TotalEmpHrs <= MAX_Working_Hrs_Per_Month && TotalWorkingDays <= MAX_Working_Day_Per_Month)
            {
                //UC3
                TotalWorkingDays++;
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
                TotalEmpHrs += EmpHrs;
                Console.WriteLine("Days " + TotalWorkingDays + "EmpHrs: " + EmpHrs);
            }
            TotalEmpWage = TotalEmpHrs * Rate_Per_Hour;
            Console.WriteLine("Total Employee Wage is "+TotalEmpWage);
            Console.ReadKey();
        }
    }
}
