using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism3
{
    class Program
    {
        static void Main(string[] args)
        {
            shape s = new shape();
            s.draw();
            s.draw(2, 3);
            s.draw(4, 5, 7);
            s.draw(6, 8, 2, "cube");
        }
    }
}
