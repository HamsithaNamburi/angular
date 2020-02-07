using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //singleton s1 = new singleton();
            //s1.printdetails("hello");
            //singleton s2 = new singleton();
            //s2.printdetails("welcome");
            singleton fromEmploye = singleton.Getinstance;
            fromEmploye.printdetails("hii");
            singleton fromStudent = singleton.Getinstance;
            fromStudent.printdetails("hii");
        
    }
    } 
}
