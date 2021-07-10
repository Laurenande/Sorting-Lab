using System;

namespace SorEkz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = new int[]{ 1, 2, 3, 4, 5 };
            int t;
            // cдвигаем влево (для право просто вычитаем еденицу, а цикл от 1 до 5)
            for (int i = 0; i < 4; i++)
            {
                t = p[i];
                p[i] = p[i + 1];
                p[i + 1] = t;
            }
            for (int i = 0; i < 5; i++)
                Console.Write(p[i] +' ');
        }
    }
}
