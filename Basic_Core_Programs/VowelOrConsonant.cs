using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class VowelOrConsonant
    {
        public static void EighthProgram()
        {
            char ch;
            Console.WriteLine("Enter any character: ");
            //Taking a charecter value from user
            ch = Convert.ToChar(Console.ReadLine());

            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }
            else
            {
                Console.WriteLine("Please Enter a valid charecter");
            }
        }
    }
}
