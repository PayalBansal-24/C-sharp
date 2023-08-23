using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double sum = 0;
            int n;
            Console.WriteLine("Enter the size of array:");
            n = Convert.ToInt32(Console.ReadLine());
            Double[] a = new Double[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter element {0}:", i + 1);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
                Console.WriteLine("Average:" + (sum/n));
                Console.ReadLine();
            }
        }
  
}
