using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    class Program
    {
        public static string even(int i)
        {
            if (i % 2 == 0)
            {
               
                return "even";
            }
            else
            {
                return "odd";
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter no");

            /*int i = int.Parse(Console.ReadLine());
            string result = even(i);
            Console.WriteLine(result);
            Console.WriteLine(max(10, 38, 23));*/
         // Console.WriteLine(Result(87.5, 78.2, 56.8, 34.6));
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2= Convert.ToDouble(Console.ReadLine());
            double m3= Convert.ToDouble(Console.ReadLine());
            double m4= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Result(m1, m2, m3, m4));
            Console.ReadKey();


        }
        public static int max(int i,int j,int k)
        {
            if (i < j)
            {
                if (j < k)
                {
                    return k;
                }
                return j;
            }
            else
                return i;
        }
        public static string Result(double m1, double m2, double m3, double m4)
        {
            double avg = (m1 + m2 + m3 + m4) / 4;
            if (avg > 70)

     return "distinction" + avg + "%";


            else if (avg >= 60 && avg < 70)

                return "First Class" + avg + "%";

            else if (avg < 50 && avg > 40)

                return "second class" + avg + "%";

            else
                return "Fail";

                          
                       


        }
    }
}
