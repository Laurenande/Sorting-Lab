using System;

namespace Sor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int N;
            Console.Write("Введите длинну массива:");
            N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Arr[" + i + "]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (arr[j] % 10 > arr[j + 1] % 10)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine( arr[i] + ' ');
            }


        }
    }
}
