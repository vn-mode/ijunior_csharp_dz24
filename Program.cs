using System;

namespace vn_mode_csharp_dz24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[30];
            int minNumberForRandom = 0;
            int maxNumberForRandom = 6;
            int tempNumber = 0, counterMaxNumber = 0;
            Random randomNumber = new Random();

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = randomNumber.Next(minNumberForRandom, maxNumberForRandom);
            }
            tempNumber = arrayNumbers[0];
            Console.Write("Исходный массив чисел: ");

            foreach (int number in arrayNumbers)
            {
                Console.Write(number + " ");
            }
            foreach (int number in arrayNumbers)
            {
                if(tempNumber < number)
                {
                    tempNumber = number;
                }
            }
            foreach (int number in arrayNumbers)
            {
                if (tempNumber == number)
                {
                    counterMaxNumber++;
                }
            }
            
            Console.WriteLine($"\nЧисло {tempNumber} самое большое в массиве и повторяется {counterMaxNumber} раз/раза.");
        }
    }
}
