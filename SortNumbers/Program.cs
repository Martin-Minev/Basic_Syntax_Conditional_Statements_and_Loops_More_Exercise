using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber);  //123
                Console.WriteLine(secondNumber);
                Console.WriteLine(thirdNumber);

            }

            else if (firstNumber >= secondNumber && thirdNumber >= secondNumber && thirdNumber >= firstNumber)
            {
                Console.WriteLine(thirdNumber);  // 312
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }

            else if (secondNumber >= firstNumber && firstNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber);// 213
                Console.WriteLine(firstNumber);
                Console.WriteLine(thirdNumber);
            }

            else if (secondNumber >= firstNumber && thirdNumber >= firstNumber && thirdNumber >= secondNumber)
            {
                Console.WriteLine(thirdNumber); // 321
                Console.WriteLine(secondNumber);
                Console.WriteLine(firstNumber);
            }

            else if (secondNumber >= thirdNumber && secondNumber >= firstNumber && thirdNumber >= firstNumber)
            {
                Console.WriteLine(secondNumber);  // 231
                Console.WriteLine(thirdNumber);
                Console.WriteLine(firstNumber);
            }

            else if (firstNumber >= thirdNumber && thirdNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);  // 132
                Console.WriteLine(thirdNumber);
                Console.WriteLine(secondNumber);
            }
        }
    }
}
