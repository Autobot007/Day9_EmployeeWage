namespace Day9_EmployeeWage
{
    public class Program
    {
        public static  void Main(string[] args)
        {


            Console.WriteLine("*+*+*+*+*+*+*+*+*+Welcome to Employee Wage Computation Problem*+*+*+*+*+*+*+*+*+");
            Console.WriteLine("================================================================================\n");

            int fullDayHour = 8;
            int wagePerHour = 20;


            EmployeeWage Employee = new();




            if (Employee.IsPresent())
            {
                Console.WriteLine("Employee is Present");
                int wage = Employee.DailyWage(fullDayHour,wagePerHour);
                Console.WriteLine("Employees todays Wage is :" + wage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
                




        }
    }
}