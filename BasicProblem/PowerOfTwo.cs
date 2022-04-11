using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class PowerOfTwo
    {
        public void PowerTable()
        {
            int i=0;
            Console.WriteLine("Enter The Nummber");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= Num; i++)
            {

                Console.WriteLine("2" +" "+"^"+" "+i+" = "+Math.Pow(2, i));
            
            }
        }
    }
}
