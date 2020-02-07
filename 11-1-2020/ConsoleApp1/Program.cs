using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class calclator
    {
        public void Add(params int[] x)
        {
            int res = 0;
            foreach (int i in x)
                res += 1;
            res = x.Sum(e => e);
            Console.WriteLine(res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calclator c = new calclator();
            c.Add(10, 20, 56, 58, 32, 78);
            Console.WriteLine("hello world");
        }
    }
}
