using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceeeee
{
    class vehical
    {
    protected    string color;
        public vehical()
        {
            this.color = "white";
            Console.WriteLine("constructor from vechical");
        }
       
        public void start()
        {
            Console.WriteLine("vehical started");

        }
        public void stop()
        {
            Console.WriteLine("vehical stopped");

        }
    }
        class car:vehical
        {
            int speed;
            string type;
        public car()
        {
            this.speed = 100;
            this.type = "BMw";
            Console.WriteLine("constructor from car");
        }
            public void drive()
            {
                Console.WriteLine(this.color+this.type+"car is driving witha speed"+this.speed);
            }
        }
    class bus:vehical{
        int seating;
        int speed;
        public bus()
        {
            this.seating = 45;
            this.speed = 56;
            Console.WriteLine("constructor from bus");
        }
        public void run()
        {
            Console.WriteLine(this.color+this.seating+" seating bus is running with a speed of"+this.speed);
        }

    }
}
