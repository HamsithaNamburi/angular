using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class compare
    {
        static void Main()
        {
            string[] name = new string[4] { "Hamsi", "divya", "anusha", "jyothi" };
            
            int flag = 0;
          string s = Console.ReadLine();
            foreach (string w in name)
            {
                if (s==w)
                {
                    flag = 1;

                    break;
                }
             
               


            }
            if (flag == 1)
                Console.WriteLine("name exists");
            else
                Console.WriteLine("Namedont exists");

        }
    
    }
}
