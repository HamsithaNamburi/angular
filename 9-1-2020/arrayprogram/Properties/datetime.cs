using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprogram.Properties
{
    class datetime
    {
        static void Main()
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.AddDays(20));
            dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            dt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);
            Console.WriteLine(dt);
            string s = Console.ReadLine();
            if (DateTime.TryParse(s, out dt))
            {
                Console.WriteLine(dt);
            }
            else
                Console.WriteLine("not a valid date");
            Console.WriteLine(dt);
            Console.ReadLine();
        }
    }
}
