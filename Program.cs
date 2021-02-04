using System;

namespace MultiplyEvenByOddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int thisNumber = Math.Abs(inputNumber);
            int thisNumberOriginal = thisNumber;
            int totalSumEven = 0;
            int totalSumOdd = 0;

            while (thisNumber > 0) 
            {

                int currentDigit = thisNumber % 10; //We take only one digit of the number

                if (currentDigit % 2 == 0)
                {
                    // sumEvenDigit += currentDigit;
                    totalSumEven += GetSumEven(currentDigit);
                }
                else  //if (currentDigit % 2 != 0)
                {
                    totalSumOdd += GetSumOdd(currentDigit);
                   // sumOddDigit += currentDigit;
                }

                thisNumber = thisNumber / 10; //We take the rest of the number
            }

            // int result = sumEvenDigit * sumOddDigit;
            Console.WriteLine(GetMultipleOfEvenAndOdds(totalSumEven, totalSumOdd));

        }

        static int GetMultipleOfEvenAndOdds(int sumEvenNumb , int sumOddNumb)
        {
            int result = sumEvenNumb * sumOddNumb;
            
            return result;
        }

        static int GetSumEven(int number) 
        {
            int sumEvenDigit = 0;
            sumEvenDigit += number; // currNumber
            return sumEvenDigit;
        }
        static int GetSumOdd(int number)
        {
            int sumOddDigit = 0;
            sumOddDigit += number;
            return sumOddDigit;
        }
    }
}
