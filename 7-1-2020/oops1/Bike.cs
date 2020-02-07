using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class Bike
    {
        string name;
        string color;
        public void setdetails()
        {
        }
            public void startengine()
        {
            Console.WriteLine("Bike startes at" + DateTime.Now.Hour);
        }
        public void fillgas(int gallon)
        {
            Console.WriteLine("bike filled with" + gallon + "gallon");
        }
        public int driver(int mile,int speed)

        {
            int n = (int)(mile / speed);
            Console.WriteLine("you will reach you destination" + n);
            return 0;
        }
      
        
    }
}
