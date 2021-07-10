using System;

namespace Sor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 6, 2, 1, 5, 3, 4 };
            int min, t;

            for (int i = 0; i < 6; i++)
                Console.Write(numbers[i] + " ");
            Console.Write('\n');

            for (int j = 0; j < 3; j++)
            {
                min = numbers[j];
                for (int i = j + 1; i < 6; i++)
                {
                    if (min > numbers[i]) 
                        min = numbers[i];
                }
                t = numbers[j];
                numbers[j] = min;
                min = t;
            }

            numbers[4] = 5;
            numbers[3] = 6;

            for (int i = 0; i < 6; i++)
                Console.Write(numbers[i] + " ");
            Console.Write('\n');
        }
    }
}
