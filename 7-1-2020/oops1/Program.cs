using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike enfiled = new Bike();
            enfiled.startengine();
            enfiled.fillgas(int.Parse(Console.ReadLine()));
            enfiled.driver(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));  

        }
    }
}
