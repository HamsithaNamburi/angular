using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());

                }
                int k = a.Length;
             //   int j = k / 2;
                if (k == 1)
                {
                    Console.WriteLine(a[0]);
                }
                else
                    foreach (int s in a) { 
                        int j = k / 2;

               
                    if (a[0] > a[j])

                            Console.WriteLine("first element is large is large");

                        else
                              if (a[j] > a[k-1])

                            Console.WriteLine("middle element is large is large");

                        else
                            Console.WriteLine("last  element is large is large");
                    }
            }
            // Console.WriteLine("enter odd number");
        }
    }
}
