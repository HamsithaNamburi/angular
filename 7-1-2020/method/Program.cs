using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator cal = new calculator();
            int x = int.Parse(Console.ReadLine());
            int y= int.Parse(Console.ReadLine());

            int result = cal.Add1(x, y);
            cal.substract(x, y, out int sub);
            Console.WriteLine(sub);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            cal.Add(x,y);
            cal.swap(ref x,ref y);
            Console.WriteLine(x + " " + y);

        }
    }
}
