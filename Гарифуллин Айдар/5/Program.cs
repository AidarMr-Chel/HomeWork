using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Диагональ_доски
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            Initialization( ref x1, ref y1, ref x2, ref y2);
            Console.WriteLine(Comparison(x1, y1, x2, y2));
        }
        public static string Comparison(double x1, double y1, double x2, double y2)
        {
            if (x1 / y1 == x2 / y2)
                return "SAME";
            if ((x1 + 1) / y1 == x2 / y2 || (x1 - 1) / y1 == x2 / y2)
                return "NEIGHBOUR";
            if (x1 / y1 == (x2 + 1) / y2 || x1 / y1 == (x2 - 1) / y2)
                return "NEIGHBOUR";
            return "NO INTERSECTIONS";
        }
        public static void Initialization(ref double x1, ref double y1, ref double x2, ref double y2)
        {
            Console.Write("Введите кооринаты первой клетки\nБуква по X:");
            x1 = Convert.ToInt32(Convert.ToChar(Console.ReadLine()))-96;
            Console.Write("Цифра по Y:");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите кооринаты второй клетки\nБуква по X:");
            x2 = Convert.ToInt32(Convert.ToChar(Console.ReadLine()))-96;
            Console.Write("Цифра по Y:");
            y2 = int.Parse(Console.ReadLine());
        }
    }
}
