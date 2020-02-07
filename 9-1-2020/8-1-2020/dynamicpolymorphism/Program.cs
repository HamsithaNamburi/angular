using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicpolymorphism
{
    class Program
    {
        static void Main(string[] args)

        {

            /* A obj = new A();
               obj.display();
               B obj2 = new B();
               obj2.display();
               C obj3 = new C();
               obj3.display();*/

          A obj;
             obj = new B();                                                                                           
            obj.display();
          obj = new C();
            obj.display();


        }
    }
}
