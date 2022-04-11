using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter The Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " Is Leap Year ");
            }
            else
            {
                Console.WriteLine(year + " Is Not Leap Year ");
            }

        }
    }
}
