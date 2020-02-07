using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativestmts
{
    class Program
    {
        public static void greet(string name)
        {
            int flag = 1;
            while (flag < 10)
            {
                Console.WriteLine("hello" + name);
                flag++;
            }
        }
        public static void natural(int i)
        {
            int flag = 1;
            while (flag <= i)
            {
                Console.Write(flag + "\t");
                flag++;

            }
        }
        public static void whole(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag + "\t");
                flag++;

            } while (flag <= i);
        }
        public static int factr(int k)
        {
            int fact = 1, i = 1;
            /*  for(int i = 1; i < k; i++) 
             {
                 fact = fact * i;
             }
             return fact;*/

            /*for (; i <= k; i++)
              {
                  fact = fact * i;
                  i++;
              }
                  return fact; */

            for (; ; ) 
            {

                if (i <= k)
                {
                    fact = fact * i;
                    i++;

                }
                else
                    break;

            }
            return fact;

        }
        public static void even(int no)
        {
            for(int j = 0; j < no; j++)
            {
                if (j % 2 == 1)
                    continue;//terminate current iteration
                Console.Write(j + "\t");

            }
        }
        public static string vowel(char ch)
        {
            string result = null;
            switch (ch)
            {
                case 'a':
                    result = "vowel";
                    break;
                case 'e':
                    result = "vowel";
                    break;
                        case 'i':
                    result = "vowel";
                    break;
                case 'o':
                    result = "vowel";
                    break;
                case 'u':
                    result = "vowel";
                    break;
                default:
                    result = "invalid input";
                    break;

            }
            return result;
        }
    


      

        static void Main(string[] args)
        {
            //  greet("Hamsitha");
            //natural(100);
            //whole(100);
            Console.WriteLine(factr(9));
            even(70);
            Console.WriteLine("\n" + vowel('d'));
        }
    }
}
