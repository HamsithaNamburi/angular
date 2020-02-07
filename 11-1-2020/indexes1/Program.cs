using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexes1
{
    class Program
    {
        static void Main(string[] args)

        {

            car c = new car();
            c.Year = 2019;
            // string[] ar = new string[] { "bmw", "audi" };
            // c.Name = ar;
            c[0] = "audi";
            c[1] = "jagur";
            c[2] = "benze";
            c[3] = "bmw";
            c[4] = "tesla";
          c[5] = "lambo";
            c.display();




        }
    }
}
