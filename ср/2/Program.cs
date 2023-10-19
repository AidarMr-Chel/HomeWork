using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 2, 3, 1, 2};
            int count = 0, ans = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] < arr[i])
                {
                    count++;
                }
                else
                {
                    count++;
                    if (count > ans)
                        ans = count;
                    count = 0;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
