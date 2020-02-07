using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicpolymorphism
{
  public abstract class A
    {
        public abstract void display();
        
            
    }
    class B:A
    {
        public override void display() 
        {
            Console.WriteLine("this is Bclass");
        }

    }
    class C:A
    {
                public override void display()
                {
                   
            Console.WriteLine("this is Cclass");
        }

    }
}
