using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {
        public static void menu(int i)
        {

            
            switch (i)
            {
                case 1:
                    odd();
                    break;
                case 2:
                    natural();
                    break;
                case 3:
                    multiplication();
                    break;
                case 4:
                    exit();
                    break;
            }




        }
        public static string odd()
        {
       int j = int.Parse(Console.ReadLine());
            if (j % 2 == 0)
            {
                return "even";
            }
            else
                return "odd";
            }
        public static void natural()
        {
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= k; i++)
            {
                Console.WriteLine("naturalno" + i);
            }
        }
        public static void multiplication()
        {
            int s = int.Parse(Console.ReadLine());
            for (int i = 1; i < s; i++)
            {
                Console.WriteLine("multiplication table", +s * i);
            }
        }
    public static void exit()
        {
            Console.ReadKey();
        }

       


        static void Main(string[] args)
        {
            Console.WriteLine("1.evenorodd");
            Console.WriteLine("2.natural");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.exit");

            int i = int.Parse(Console.ReadLine());

            menu(i);





        }
    }
}
