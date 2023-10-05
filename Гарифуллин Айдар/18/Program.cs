using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int i = 2;
            int count = 0;
            int n = 1;
            while (count < k) 
            {
                if (IsPrime(i))
                {
                    count++;
                    n = i;
                }
                i++;
            }
            Console.WriteLine($"{k}-ое простое число: {n}");
        }
        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
