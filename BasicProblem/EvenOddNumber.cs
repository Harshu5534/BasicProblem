using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class EvenOddNumber
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter The Number: ");
            int Num=Convert.ToInt32(Console.ReadLine());
            if((Num % 2)==0)
            {
                Console.WriteLine("It is an Even Number.");
            }
            else
            {
                Console.WriteLine("It is an Odd Number.");
            }

        }
    }
}
