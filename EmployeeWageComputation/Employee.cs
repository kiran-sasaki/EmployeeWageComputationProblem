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
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck == FullTime)
            {
                Console.WriteLine("empolyee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
            Console.ReadKey();
        }
    }
}
