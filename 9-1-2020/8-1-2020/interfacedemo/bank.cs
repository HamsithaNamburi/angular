using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedemo
{
    interface Iloan
    {
        void getIntrest();

    }
    interface Gloan : Iloan
    {
        void goldintrest();
    }
    interface Idmat
    {
        void display();
    }
 public abstract class Bank
    {
        protected string bname;
        protected string location;
 public Bank(string bname,string location)
        {
            this.bname = bname;
            this.location = location;
        }
    }
    public class Sbi:Bank,Iloan
    {
        string bmanager;
        public Sbi (string bname,string loc,string bmang) : base(bname, loc) {
            this.bmanager = bmang;
        }
        public void goldintrest()
        {
            Console.WriteLine("the gold loan intrest is 7%");
        }
        public void getIntrest()
        {
            Console.WriteLine("the intrest is 5%");
        }
        public void displaydetails()
        {
            Console.WriteLine(this.bname + this.location + this.bmanager);
        }
    }
    public class icici:Bank,Gloan,Idmat//one class with different interfaces
    {
        string bmanager;
        public icici(string bname, string loc, string bmang) : base(bname, loc)
        {
            this.bmanager = bmang;

        }
        public void display()
        {
            Console.WriteLine("icici created dmate account");
        }
        public void goldintrest()
        {
            Console.WriteLine("the gold loan intrest is 7%");
        }
        public void getIntrest()
        {
            Console.WriteLine("the intrest is 5%");
        }
        public void displaydetails()
        {
            Console.WriteLine(this.bname + this.location + this.bmanager);
        }
    }

}
