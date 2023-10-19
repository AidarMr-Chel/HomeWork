using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину мвссива");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int min = int.MaxValue, minInd = 0;
            int max = int.MinValue, maxInd = 0;
            int sum = 0;
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < min)
                {
                    minInd = i;
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    maxInd = i;
                    max = arr[i];
                }

            }
            if (minInd < maxInd)
                for (int i = minInd; i <= maxInd; i++)
                    sum += arr[i];
            else
                for (int i = maxInd; i <= minInd; ++i)
                    sum += arr[i];
            Console.WriteLine(sum);
        }
    }
}
