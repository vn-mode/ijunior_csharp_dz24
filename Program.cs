using System;

namespace vn_mode_csharp_dz24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[30];
            int minNumberForRandom = 0;
            int maxNumberForRandom = 30;
            int maxRepeatNumber = minNumberForRandom -1;
            int counterMaxRepeatNumber = 1;
            int tempCounterNumber = 1;
            Random randomNumber = new Random();

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = randomNumber.Next(minNumberForRandom, maxNumberForRandom);
            }

            Console.Write("Исходный массив чисел: ");

            foreach (int item in arrayNumbers)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if ((i+1) < arrayNumbers.Length)
                {
                    if (arrayNumbers[i] == arrayNumbers[i + 1])
                    {
                        tempCounterNumber++;

                        if (tempCounterNumber > counterMaxRepeatNumber)
                        {

                            counterMaxRepeatNumber = tempCounterNumber;
                            maxRepeatNumber = arrayNumbers[i];
                        }
                    }

                    if (arrayNumbers[i] < arrayNumbers[i + 1])
                    {
                        tempCounterNumber = 1;
                    }
                }
            }

            if (maxRepeatNumber == (minNumberForRandom - 1))
            {
                Console.WriteLine("\nВ массиве нет повторяющихся чисел.");
            }
            else
            {
                Console.WriteLine($"\nЧисло {maxRepeatNumber} чаще других встречается в массиве и повторяется {counterMaxRepeatNumber} раз/раза.");
            }
            
        }
    }
}
