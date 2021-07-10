using System;

namespace Sor_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n, k, t;
            int[] a = new int[100];
            bool f;
            Console.WriteLine("Введите длину массива:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Arr[" + i + "]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if(a[i] > a[j])
                    {
                    t = a[i];
                    a[i] = a[j];
                    a[j] = t;
                    }
                }
            }
            
        }
    }
}
