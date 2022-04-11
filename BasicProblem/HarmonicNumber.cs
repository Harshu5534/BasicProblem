using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            double Answer = 0.0,i;
            Console.WriteLine("Enter The Number: ");
            int Num =Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= Num; i++)
            {
                Console.WriteLine("1/{0}+", i);
                Answer = (double)1 / i;
            }
            Console.WriteLine("Nth Harmonic Number IS: " + Answer);
                  
        }
    }
}
