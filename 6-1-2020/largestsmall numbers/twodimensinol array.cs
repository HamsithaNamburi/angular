using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestsmall_numbers
{
    class twodimensinol_array
    {
        static void Main()
        {
            int[,] marks = new int[5, 3];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            /*      for (int i = 0; i < 5; i++)
                  {
                      for (int j = 0; j < 3; j++)
                      {
                          Console.WriteLine(marks[i, j]+ "/t");
                      }
                  }
            foreach (int x in marks)
            {
                Console.Write(x);

            }
            int high = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (high > marks[j, i])
                    {
                        high = marks[j, i];
                    }
                }
            }
            Console.WriteLine(high);*/

            for (int col = 0; col < 3; col++)
            {
                int topscore = 0;
                for (int row = 0; row < 5; row++)
                {
                    if (row == 0)
                        topscore = marks[row, col];
                    else
                        if (marks[row, col] > topscore)
                        topscore = marks[row, col];
                }


                Console.WriteLine("highest of sub" + (col + 1) + "is" + topscore);
            }
        }
    }
}
