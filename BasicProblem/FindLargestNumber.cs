using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class FindLargestNumber
    {
   
        public void LargestNumber()
        {
           
            Console.WriteLine("Enter The 1st Number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The 2nd Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The 3rd Number");
            int Num3 = Convert.ToInt32(Console.ReadLine());
            if ((Num1 > Num2) && (Num1 > Num3))

            { 
                Console.WriteLine("1st Number Is Largest");
            }
            else if ((Num2 > Num1) && (Num2 > Num3))
            {
                Console.WriteLine("2nd Number Is Largest");
            }
            else if((Num3 > Num1) && (Num3 > Num2))
            {
                Console.WriteLine("3rd Number Is Largest");
            }
                  
                
        }
    }
}
