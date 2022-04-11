using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class QuotientAndRemainder
    {
        public void QuotientRemainder()
        {
            Console.WriteLine("Enter The Divident: ");
            int Divident=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Divisor: ");
            int Divisor=Convert.ToInt32(Console.ReadLine());
            int Quotient = Divident / Divisor;
            int Remainder=Divident % Divisor;
            Console.WriteLine("Quotient Is: " + Quotient);
            Console.WriteLine("Remainder Is: " +Remainder) ;
        }
        
    }
}
