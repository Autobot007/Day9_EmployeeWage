namespace Day9_EmployeeWage
{
    public class Program
    {
        public static  void Main(string[] args)
        {


            Console.WriteLine("*+*+*+*+*+*+*+*+*+Welcome to Employee Wage Computation Problem*+*+*+*+*+*+*+*+*+");
            Console.WriteLine("================================================================================\n");

            int fullDayHour = 8;
            int partTimeHour = 4;
            int wagePerHour = 20;
            int workingHour = 0;
            int day = 0;


            EmployeeWage Employee = new();
            for (int i = 1; i <= 20; i++)
            {
                switch (Employee.IsPresent())
                {
                    case 0:
                        Console.WriteLine(day+"  Employee is Absent\n");
                       day++;i--;
                        break;
                    case 1:
                        Console.WriteLine(day+"  Employee is Present for Part time");
                        Console.WriteLine("Employees todays wage is : " + Employee.DailyWage(partTimeHour, wagePerHour)+"\n");
                        workingHour += 4; day++;
                        break;
                    case 2:
                        Console.WriteLine(day+"  Employee is Present");
                        Console.WriteLine("Employees todays wage is : " + Employee.DailyWage(fullDayHour, wagePerHour)+"\n");
                        workingHour += 8; day++;
                        break;
                }

            }

            Console.WriteLine("Monthly Wage is :" +workingHour*wagePerHour);
                




        }
    }
}