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
            Console.WriteLine("Введите числа через пробел");
            string numbers = Console.ReadLine();
            string[] numArray = new string[numbers.Split(' ').Length];
            numArray = numbers.Split(' ');      
            Console.WriteLine(Comparison(numbers.Split(' ').Length, numArray));

        }
        public static string Comparison(int n, string[] array)
        {
            for (int i = 0; i < n - 1; i++)
                if (int.Parse(array[i]) <= int.Parse(array[i + 1]))
                    return "Не является";
            return "Является";
        }
    }
}
