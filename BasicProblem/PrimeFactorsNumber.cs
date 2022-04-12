using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class PrimeFactorsNumber
    {
        public int Factors(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return num;
            }
            return 0;
        }
        public void PrimeFactors()  //45 -> 3,5,9,15,45
        {
            int i = 0;
            Console.WriteLine("Enter The Number To Check Prime Factors: ");
            int Num=Convert.ToInt32(Console.ReadLine());
            for ( i = 2; i <= (Num / 2) + 1; i++)
            {
                if (Num % i == 0)
                {
                    if (this.Factors(i) != 0)
                    {
                        Console.WriteLine(i);
                    }
                    //if (i % 2 != 0)
                    //{
                   //     Console.WriteLine(i);
                    //}

                }
            }
        }
    }
}