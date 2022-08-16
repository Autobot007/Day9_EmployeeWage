namespace Day9_EmployeeWage
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            Console.WriteLine("*+*+*+*+*+*+*+*+*+Welcome to Employee Wage Computation Problem*+*+*+*+*+*+*+*+*+");
            Console.WriteLine("================================================================================");

            EmployeeWage Employee = new();


            if (Employee.IsPresent())
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");




        }
    }
}