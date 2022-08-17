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

            int fullDayHour = 8;
            int partTimeHour = 4;
            int wagePerHour = 20;

            wageobj.WageOfEmployee(fullDayHour, partTimeHour, wagePerHour); 
        }
        
        
        
        
    }
}