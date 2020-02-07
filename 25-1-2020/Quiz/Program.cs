using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("play the quiz");
            Console.WriteLine("Dont Wnt to play the Quiz");
           string  ch = Console.ReadLine();
            if (ch == "yes")
            {
                Console.WriteLine("1. Three Multiple Choice");
              Console.WriteLine("2.True/False");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {

                }
                else
                    if (n == 2)
                {

                }
                else
                    Console.WriteLine("Invalid Option");

            } else
                Environment.Exit(0);
        }
    }
}
