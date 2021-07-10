using System;

namespace Sor_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int temp;

            //for (int i = 0; i < arr.Length; i++)
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //        if (arr[j] % 10 > arr[j + 1] % 10)
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + ' ');
            }
        }
    }
}
