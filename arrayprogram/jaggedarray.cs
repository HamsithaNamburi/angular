using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprogram
{
    class jaggedarray
    {
        static void Main()
        {
            int[][] j1 = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter size");
                int size = int.Parse(Console.ReadLine());
                j1[i] = new int[size];
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < j1[row].Length; col++)
                {
                    j1[row][col] = int.Parse(Console.ReadLine());
                }


            }
            for (int row = 0; row < 2; row++) 
            {
                for (int col = 0; col < j1[row].Length; col++)
                {
                    Console.WriteLine(" " + j1[row][col]);
                }
                Console.WriteLine();
            }
          //  int n;

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < j1[row].Length; col++)
                {
                    if (j1[row][col] == j1[row+1][col+1])
                    {
                        int n = j1[row][col] + j1[row][col];
                        Console.WriteLine(n);

                    }
                    else
                        Console.WriteLine("no comman element");
                }
            }
        }
    }
}
