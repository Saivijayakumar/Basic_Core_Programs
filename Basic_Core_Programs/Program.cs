using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    /// <summary>
    /// Each and every program is in different class 
    /// According to the given menu you can Run that program
    /// </summary>
    class Program
    {
        //Basic Core Programs
        static void Main(string[] args)
        {
            //MENU
            Console.WriteLine("Choose a option from the given List");
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("2. Finding Leap Year");
            Console.WriteLine("3. Power Of Two Program");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Finding Quotient And Remainder");
            Console.WriteLine("6. Swaping Two Numbers");
            Console.WriteLine("7. Finding Even Or Odd");
            Console.WriteLine("8. Finding given charecter is vowel or Consonant");
            Console.WriteLine("9. Finding Largest number among three numbers");
            Console.WriteLine("10. Finding Prime Factor Program");
            Console.WriteLine("\n-------------------------------------------");
            switch (Console.ReadLine())
            {
                case "1":
                    Flip_Coin.FirstProgram();
                    break;
                case "2":
                    LeapYear.SecondProgram();
                    break;
                case "3":
                    PowerOfTwo.ThirdProgram();
                    break;
                case "4":
                    HarmonicProgram.FourthProgram();
                    break;
                case "5":
                    QandR.fifth();
                    break;
                case "6":
                    swaping.sixthProgram();
                    break;
                case "7":
                    EvenOrOdd.seventh();
                    break;
                case "8":
                    VowelOrConsonant.EighthProgram();
                    break;
                case "9":
                    LargeAmongThree.NinthProgram();
                    break;
                case "10":
                    PrimeFactor.TenthProgram();
                    break;
                default:
                    Console.WriteLine("Please enter valid option");
                    break;
            }
            Console.Read();
        }
    }
}
