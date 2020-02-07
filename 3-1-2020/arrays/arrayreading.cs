using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class arrayreading
    {
        static void Main()
        {
            int[] b = new int[6];
            for (int i = 0; i < 6; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            foreach(int k in b)
            {
                Console.WriteLine(k);
            }


        }
    }
}
