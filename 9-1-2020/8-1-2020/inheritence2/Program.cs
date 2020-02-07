using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence2
{
    class Program
    {
        static void Main(string[] args)
        {
          //  vehical veh = new vehical();
            bus bs = new bus("red",60,80);
            car c = new car("black",45,"audi");
        //    veh.start();
         //   veh.stop();
            bs.start();
            bs.run();
            bs.stop();
            bs.fillfue();
          //  bus bs1 = new bus();
            c.start();
            c.drive();
            c.stop();
            c.fillfue();


        }
    }
}
