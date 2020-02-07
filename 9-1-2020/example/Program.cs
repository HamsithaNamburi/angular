using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    public class salaryException : Exception
    {
        public salaryException(string s):base(s)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter passenger name");
            string s = Console.ReadLine();
            Console.WriteLine("enter passenger age");
    int age = int.Parse(Console.ReadLine());
            Console.WriteLine("no of tickets to book");
            int a = int.Parse(Console.ReadLine());






            Passengers p = new Passengers(s, age);
            p.ticketbooking(a);

        }
    }
    class Passengers
    {
        string name;
        int age;
        public Passengers(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void ticketbooking(int no_of_tickets)
        {
            //int no = int.Parse(Console.ReadLine());
            try
            {
                if (no_of_tickets > 2) throw new salaryException("more than two are not booked");
                else
                    Console.WriteLine("tickets are booked");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
        }
    }
}
