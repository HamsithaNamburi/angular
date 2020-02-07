using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. player details");
            Console.WriteLine("2.run details");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                delivery d = new delivery();
                Console.WriteLine("enter batsman name");
                string s = Console.ReadLine();
                Console.WriteLine("enter bowler name");
                string k = Console.ReadLine();
                d.display_delivery(s, k);
            }
            else
                if (n == 2)
            {
                delivery d = new delivery();
                Console.Write("enter the score");
                int h = int.Parse(Console.ReadLine());
                Console.Write("enter the run scored");
                int j = int.Parse(Console.ReadLine());

                d.display_delivery(j);
            }
            else
                Console.WriteLine("enter correct input");g
        }
    }
}
