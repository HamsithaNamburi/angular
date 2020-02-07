using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceeeee
{
    class parent
    {
        protected int a;
        protected string b;

        public int A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public void getValues(int x, string y)
        {
            this.A = x;
            this.B = y;
        }
        public void display()
        {
            Console.WriteLine(this.A + " " + this.B);
        }
    }
        class Child:parent //single inheritance
        {
       protected     int c;
            public void calculator(int num)
            {
                c = this.A + num;
            Console.WriteLine(c);
            }
        }
    class GrandChild:Child //multi level inheritance
    {
        int d;
        public void multiply(int num)
        {
            d = this.c * num;
            Console.WriteLine(d);
        }
    }
    
}
namespace demoprotected
{
    class Exchild : inheritanceeeee.parent
    {
        public void exdisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }
}
