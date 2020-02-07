using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            icici ic = new icici("vij", "vij", "jhon");
            Sbi sb = new Sbi("fgg", "fdg", "fdg");
            ic.displaydetails();
            ic.getIntrest();
            ic.goldintrest();
            ic.display();

            sb.displaydetails();
            sb.getIntrest();
            sb.goldintrest();
        }
    }
}
