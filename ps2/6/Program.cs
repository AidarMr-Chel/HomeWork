using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps2
{
    internal class Program
    {
        static double k = 1, eps, x;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Х, |Х|<=1:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Eps:");
            eps = double.Parse(Console.ReadLine());
            double  arctg = x, x0 = x;
            Console.WriteLine($"arctg:{sum(arctg, x0)}");
            Console.WriteLine($"Шаг:{k}");
        }
        public static double sum(double arctg, double x0)
        {
            while (Math.Abs(x0) > eps)
            {
                x0 = Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / (2 * k + 1);
                arctg += x0;
                k++;
            }
            return arctg;
        }
    }
}
