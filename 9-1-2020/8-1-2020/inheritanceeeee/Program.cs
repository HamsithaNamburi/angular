using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceeeee
{
    class Program
    {
        static void Main(string[] args)
        {
            parent pobj = new parent();
            Child c = new Child();
            GrandChild gc = new GrandChild();
            pobj.getValues(23,"ha");
            pobj.display();
            c.getValues(45,"yu");
            c.display();
            c.calculator(7);
            gc.getValues(45, "chu");
            gc.display();
            gc.calculator(9);
             gc.multiply(3);
            demoprotected.Exchild hfd = new demoprotected.Exchild();
            hfd.getValues(4,"fgh");
            hfd.display();
            hfd.exdisplay();


        }
    }
}
