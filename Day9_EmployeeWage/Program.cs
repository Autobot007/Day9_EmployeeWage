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
            int workingDay = 0;


            EmployeeWage Employee = new();
            while (workingHour<=100 || workingDay<=20)
            {
                switch (Employee.IsPresent())
                {
                    case 0:
                        Console.WriteLine("  Employee is Absent\n");
                        break;
                    case 1:
                        Console.WriteLine("  Employee is Present for Part time");
                        Console.WriteLine("Employees todays wage is : " + Employee.DailyWage(partTimeHour, wagePerHour)+"\n");
                        workingHour += 4; workingDay++;
                        break;
                    case 2:
                        Console.WriteLine("  Employee is Present");
                        Console.WriteLine("Employees todays wage is : " + Employee.DailyWage(fullDayHour, wagePerHour)+"\n");
                        workingHour += 8; workingDay++;
                        break;
                }

            }

            Console.WriteLine("Monthly Wage is :" +workingHour*wagePerHour);
                




        }
    }
}