using System;

namespace Sor_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, K, temp;
            bool isSwap = false;
            Console.WriteLine("N: ");
            N = Convert.ToInt32(Console.ReadLine());
            K = N;

            int[] Arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Arr[" + i + "]: ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < N - 1; j++)
            {
                for (int i = 1; i < K; i++)
                {
                    if (Arr[i - 1] > Arr[i])
                    {
                        isSwap = true;
                        temp = Arr[i];
                        Arr[i] = Arr[i - 1];
                        Arr[i - 1] = temp;
                        for (int t = 0; t < N; t++)
                        {
                            Console.Write(Arr[t] + " ");
                        }
                        Console.WriteLine("\n");
                    }
                }
                K--;
            }

            if (!isSwap)
            {
                Console.WriteLine('0');
            }


        }
    }
}
