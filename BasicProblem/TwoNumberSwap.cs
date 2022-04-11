using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class TwoNumberSwap
    {
        public void NumberSwap()
        {
            int Result;
            Console.WriteLine("Enter The 1st Number ");
            int Num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number ");
            int Num2=Convert.ToInt32(Console.ReadLine());
            Num1 = Num1 * Num2;
            Num2 = Num1 / Num2;
            Result = Num1 / Num2;
            Console.WriteLine("After Swaping Of Two Number: "+Result+" "+Num2);
        }
    }
}
