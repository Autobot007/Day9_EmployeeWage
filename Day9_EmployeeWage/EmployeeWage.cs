using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_EmployeeWage
{
    public class EmployeeWage
    {
        public bool IsPresent()
        {
            Random random = new Random();
            if(random.Next(0,2) == 1)
                return true;
            return false;
        }

        public int DailyWage(int hour,int wage)
        {
            int dailyWage = hour * wage;
            return dailyWage;
        }
    }
}
