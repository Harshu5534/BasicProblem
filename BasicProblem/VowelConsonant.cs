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
            char ch1 =char.ToLower(ch);
            if (ch1 == 'a' || ch1 == 'e' || ch1 == 'i' || ch1 == 'o' || ch1 == 'u')
            {
                Console.WriteLine(ch+ " "+" Alphabets Is Vowels.");
            }
            else 
            {
                Console.WriteLine(ch+" "+" Alphabet IS Consonent.");            
            }

            
        }
    }
}
