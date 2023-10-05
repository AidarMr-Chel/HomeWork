using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nullCount = 0, nullMax = 0;
            long numDec = long.Parse(Console.ReadLine());
            string numBin = Convert.ToString(numDec, 2);
            for (int i = 0; i < numBin.Length; i++) 
            {
                if (numBin[i] == '0')
                    nullCount++;
                else
                {
                    nullMax = Math.Max(nullCount, nullMax);
                    nullCount = 0;
                }
            }
            nullMax = Math.Max(nullCount, nullMax);
            Console.Write("Двоичная запись:");
            Console.WriteLine(numBin);
            Console.WriteLine($"Макс ряд нулей:{nullMax}");
        }
    }
}
