using System;

namespace Sor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  N ;
            Console.Write("Введите длинну массива:");
            N = int.Parse(Console.ReadLine());
            int count = 1;
            double[] mass = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите " + (i + 1) + " элемент:");
                mass[i] = double.Parse(Console.ReadLine());

            }

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] == mass[j])
                        break;

                    if (j == mass.Length - 1)
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
