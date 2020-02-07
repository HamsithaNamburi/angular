using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism3
{
    class shape
    {
        int length;
        int width;
        int breadth;
        string shapes;
        public void draw()
        {
            Console.WriteLine("A shape can be draw");

        }
        public void draw(int i) {
            this.length = i;
        
            Console.WriteLine("A shape can be draw");

        }
        public void draw(int i,int j)

        {
            this.length = i;
            this.breadth = j;
            Console.WriteLine("A square draw");

        }
        public void draw(int i,int j,int k)
        {
            this.length = i;
            this.breadth = j;
            this.width = k;
            Console.WriteLine("A triangle draw");

        }
        public void draw(int i,int j,int k,string s)
        {
          this.length = i;
          this.breadth = j;
          this.width = k;
          this.shapes= s;

            Console.WriteLine(s + "A cube is draw ");

        }
    }
}
