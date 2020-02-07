using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridingdemo
{
    public abstract class student
    {
        int stuid;
        string stuname;
        double examfee;
        public abstract void displaydetails();
        public double payfee()
        {
            return examfee;
        }
        public student(int stuid, string stuname, double examfee)
        {
            Console.WriteLine(stuid);
            Console.WriteLine(stuname);
            Console.WriteLine(examfee);
        }
    }
    class dayscholor : student
    {
        double transportfee;
        public override void displaydetails()
        {
            Console.WriteLine("student dayscholor details");
        }

        public double payfee(double examfee)
        {
            return transportfee + examfee;

        }
        public dayscholor(int stuid, string stuname, double examfee, double transportfee) : base(stuid, stuname, examfee)
        {
            Console.WriteLine(stuid);
            Console.WriteLine(stuname);
            Console.WriteLine(examfee);
            Console.WriteLine(transportfee);
        }

    }
    class hostler : student
    {
        double hostlefee;
        public override void displaydetails()
        {
            Console.WriteLine("displaying student details");
        }
        public double payfee(double examfee)
        {
            return hostlefee + examfee;

        }
        public hostler(int stuid, string stuname, double examfee, double hostlefee) : base(stuid, stuname, examfee)
        {

            Console.WriteLine(stuid);
            Console.WriteLine(stuname);
            Console.WriteLine(examfee);
            Console.WriteLine(hostlefee);

        }
    }
}
