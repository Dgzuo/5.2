using System;
using System.Linq;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            const int n = 7;
            double[,] arr = new double[n, n];

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.NextDouble() * 100;
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0:f2}\t", arr[i, j]);
                }
                Console.WriteLine( );
            }

            double[] glav = new double[n];
            double[] poboch = new double[n];

            int index = n - 1;
            for (int i = 0; i < n; i++)
            {
                glav[i] = arr[i, i];
                poboch[i] = arr[i, index];
                index--;
            }
            double g_max = Enumerable.Max(glav),
                   p_max = Enumerable.Max(poboch);

            Console.WriteLine("Главная max = {0:f2}\nПобочная max = {1:f2}\nПроизмведение = {2:f2}\n", g_max, p_max, (g_max * p_max));

        }

    }
}
