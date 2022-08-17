using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_EmployeeWage
{
    public class EmployeeWage
    {
        public int IsPresent()
        {
            Random random = new Random();
            return random.Next(0,3);
        }

        public int DailyWage(int hour,int wage)
        {
            int dailyWage = hour * wage;
            return dailyWage;
        }

        public void WageOfEmployee(string companyName,int maxWorkingHour, int maxWorkingDay, int wagePerHour)
        {
            int fullDayHour = 8;
            int partTimeHour = 4;
            int workingHour = 0;
            int workingDay = 0;

            EmployeeWage Employee = new();
            Console.WriteLine("\n\n\nCompany Name is :{0}\n\n\n",companyName);


            while (workingHour <= maxWorkingHour || workingDay <= maxWorkingDay)
            {
                switch (Employee.IsPresent())
                {
                    case 0:
                        Console.WriteLine("  Employee is Absent\n");
                        break;
                    case 1:
                        Console.WriteLine("  Employee is Present for Part time");
                        Console.WriteLine("Employees todays wage is : " + Employee.DailyWage(partTimeHour, wagePerHour) + "\n");
                        workingHour += 4; workingDay++;
                        break;
                    case 2:
                        Console.WriteLine("  Employee is Present");
                        Console.WriteLine("Employees todays wage is : " + Employee.DailyWage(fullDayHour, wagePerHour) + "\n");
                        workingHour += 8; workingDay++;
                        break;
                }

            }

            Console.WriteLine("Monthly Wage is :" + workingHour * wagePerHour);
        }


    }
    



    
}
