using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence2
{

     abstract   class vehical
        {
            protected string color;
            public vehical()
            {
                this.color = "white";
                Console.WriteLine("constructor from vechical");
            }
        public vehical(string clr)
        {
            this.color = clr;
            Console.WriteLine("parameter");
        }
        public abstract void fillfue();
        public virtual void start() //making the method as virtual
            {
                Console.WriteLine("vehical started");

            }
            public void stop()
            {
                Console.WriteLine("vehical stopped");

            }
        }
        class car : vehical
        {
            int speed;
            string type;
            public car()
            {
                this.speed = 100;
                this.type = "BMw";
                Console.WriteLine("constructor from car");
            }
        public override void fillfue()
        {
            Console.WriteLine("filled with desile");
        }
        public car(string clr, int speed, string type):base(clr)//invoking the constructor from parent class use base keyword
        {
            this.speed = speed;
            this.type = type;
        }
        public void drive()
            {
                Console.WriteLine(this.color + this.type + "car is driving witha speed" + this.speed);
            }
        }
        class bus : vehical
        {
            int seating;
            int speed;
            public bus()//default constructot
            {
                this.seating = 45;
                this.speed = 56;
                Console.WriteLine("constructor from bus");
            }
        public bus(string clr, int speed, int seating) : base(clr)//invoking the constructor from parent class use base keyword
        {
            this.speed = speed;
            this.seating = seating;
        }
        public override void fillfue()
        {
            Console.WriteLine("filled with petrol");
        }
       public override void start() //overridining after virtual the method
        {
           Console.WriteLine("bus is starting");
       }
        public void run()
            {
                Console.WriteLine(this.color + this.seating + " seating bus is running with a speed of" + this.speed);
            }

        }
    }
