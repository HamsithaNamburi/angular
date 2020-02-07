using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingdemo
{
    class delivery
    {
 public void display_delivery(string btname,string bwname)
        {
            Console.WriteLine("batsman name" + btname);
            Console.WriteLine("bowler name" + bwname);

        }
 public void display_delivery(long run)
        {
            if (run == 4)
            {
                Console.WriteLine("four");
            }
            else if (run == 6)
                Console.WriteLine("six");
            else
                Console.WriteLine("the run scored in a delivery is"+run);
        }
    }
}
