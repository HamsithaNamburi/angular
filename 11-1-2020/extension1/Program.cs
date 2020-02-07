using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension1
{
 static   class StringHelper
    {
        public static string FirstCaseChange(this string name)
        {
            char[] input = name.ToCharArray();
            input[0] = Char.IsUpper(input[0]) ? Char.ToLower(input[0]) : Char.ToUpper(input[0]);
            return new string(input);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "welcome";
            Console.WriteLine(name.FirstCaseChange());
             var anonymousType = new { property1 = "Ajay",property2 = 12, property3 = true};
            Console.WriteLine(anonymousType.GetType());

        }
    }
}
