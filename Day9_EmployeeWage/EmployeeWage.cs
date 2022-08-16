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
    }
}
