namespace Day9_EmployeeWage
{
    public class Program
    {
        EmployeeWage wageobj = new();
        public static  void Main(string[] args)
        {
            Console.WriteLine("*+*+*+*+*+*+*+*+*+Welcome to Employee Wage Computation Problem*+*+*+*+*+*+*+*+*+");
            Console.WriteLine("================================================================================\n");
            Program program = new Program();

            program.Wage();
        }

        public void Wage()
        {
            Console.WriteLine("Enter Company name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter Maximum working hour in company");
            int maxWorkingHour = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Maximum working day in company");
            int maxWorkingDay = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter wage per hour as per company");
            int wagePerHour = Convert.ToInt16(Console.ReadLine());

            wageobj.WageOfEmployee(companyName,maxWorkingHour, maxWorkingDay, wagePerHour); 
        }
        
        
        
        
    }
}