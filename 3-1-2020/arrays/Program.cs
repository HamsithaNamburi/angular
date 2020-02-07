using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
         /* int[] a = new int[4];
             a[0]=60;
            a[1] = 32;
            a[2] = 34;
            a[3] = 23;
            for(int i = 0; i <4;i++)
            {
                Console.WriteLine(a[i]);

            }
            */
            int[] b = new int[5] { 10, 20, 30, 40, 45 };
          //int sum = 0;
            foreach(int i in b)
            {
                // sum = sum + i;
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            double[] d = new double[3] { 12.2, 23.4, 34.5 };
            char[] ch = { 'a', 'c', 'd' };
            object[] o = new object[4];
        }
    }
}
