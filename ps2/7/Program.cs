using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100000, a = 1, b = 2;
            Console.WriteLine($"Левый прямоугольник:{LeftRectangle(a, b, n)}");
            Console.WriteLine($"Правый прямоугольник:{RightRectangle(a, b, n)}");
            Console.WriteLine($"Трапеция:{methodTrapezoid(a, b, n)}");
            Console.WriteLine($"Симпсон:{methodSimpson(a, b, n)}");
            Console.WriteLine($"Монте Карло:{methodMonteCarlo(a,b,n)}");
        }
        public static double F(double x)
        { 
            return Math.Cos(2*x)/Math.Sin(x)*(-1); 
        }
        public static double LeftRectangle(double a, double b, int n)
        {
            var h = (b - a) / n;
            double sum = 0;
            for (var i = 0; i <= n - 1; i++)
            {
                var x = a + i * h;
                sum += F(x);
            }
            return h * sum;
        }
        public static double RightRectangle(double a, double b, int n)
        {
            var h = (b - a) / n;
            double sum = 0;
            for (var i = 1; i <= n; i++)
            {
                var x = a + i * h;
                sum += F(x);
            }
            return h * sum;
        }
        public static double methodSimpson(double a, double b, int n)
        {
            var h = (b - a) / n;
            double sum1 = 0, sum2 =0;
            for (var k = 1;k <= n;k++)
            {
                var x1 = a + k * h;
                if(k <= n - 1)
                {
                    sum1 += F(x1);
                }
                var xk2 = a + (k - 1) * h;
                sum2 += F((x1 + xk2) / 2);
            }
            return h / 3.0 * (1.0 / 2.0 * F(a) + sum1 + 2 * sum2 + 1.0 / 2.0 * F(b));
        }
        public static double methodTrapezoid(double a, double b, int n)
        {
            var h = (b - a) / n;
            double sum = 0;
            for (var i = 1; i < n; i++) 
                sum += F(a + i * h)*((a + (i+1) * h)-(a + (i-1) * h));
            return 1/2.0*(F(a)*h+sum+F(b)*(b-(a + (n-1)* h)));
        }
        public static double methodMonteCarlo(double a, double b, int n)
        {
            Random r = new Random();
            double sum = 0;
            for (var i = 1; i <= n; i++)
            {
                sum += F(r.Next((int)a*10, (int)b*10)/10.0);
            }
            return sum*(b-a)/n;
        }
    }
}
