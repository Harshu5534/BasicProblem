using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class VowelConsonant
    {

        public void CheckVowelOrConsonant()
        {
            Console.WriteLine("Enter Any Alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(" Alphabets Are Vowels.");
            }
            else if ((ch >= 'a'&& ch <='z') || (ch >= 'A'&& ch <='Z'))
            {
                Console.WriteLine(" Alphabet Are Consonent.");            
            }

            
        }
    }
}
