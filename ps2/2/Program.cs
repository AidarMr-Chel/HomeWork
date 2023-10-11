using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите eps:");
            double  eps = double.Parse(Console.ReadLine());
            Console.WriteLine(vallisMetod(eps));
        }
        public static double vallisMetod(double eps)
        {
            double pi = 1, k = 1, pi0 = 2;
            while (Math.Abs(pi-pi0) > eps/100000)
            {
                pi0 = pi;
                pi *= 4 * k * k / (4 * k * k - 1);
                k++;
            }
            return pi*2;
        }
    }
}
