using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory1
{
    interface Ifactory
    {
        void manufacture(int cnt);

    }
    class Bike : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("manufacturing a bike" + cnt);
        }
    }
    class car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("manufacturing a car" + cnt);
        }
    }
    abstract class vehicalFractory
    {
        public abstract Ifactory generateVehicales(string type);
    }
    class concreteVehicleFactory : vehicalFractory
    {
        public override Ifactory generateVehicales(string type)

        {
            if (type == "Bike")
                return new Bike();
            else
                return new car();


        }
        //  Console.WriteLine

    }
}
        static void Main(string[] args)
        {
            vehicalFractory obj = new concreteVehicleFactory();
            Ifactory myvehical = obj.generateVehicales("Bike");
            myvehical.manufacture(10);
            myvehical = obj.generateVehicales("Car");
            myvehical.manufacture(30);
        }
    }
