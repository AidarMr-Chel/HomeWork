using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[m,m];
            Random random = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = random.Next(0, 5);
                }
            }
            WriteArr(arr, n,m);

            int memor, c = 0;
            if (m == m)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = c; j < m; j++)
                    {
                        memor = arr[j, i];
                        arr[j, i] = arr[i, j];
                        arr[i, j] = memor;
                    }
                    c++;
                }
                Console.WriteLine("----------");
                WriteArr(arr, n, m);
            }
            else
                Console.WriteLine("Матрица не квадратная");

        }
        public static void WriteArr(int[,] arr, int w, int h)
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
