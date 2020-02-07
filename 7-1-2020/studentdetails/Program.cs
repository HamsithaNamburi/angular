using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdetails
{
    class Program
    {
        static void Main(string[] args)
        {
             Student details = new Student();
            details.Rollno = 45;
            details.Name = "hamsi'";
          //  Console.WriteLine(rollno);
             details.acceptdetails();
             details.displaystudentdetails();
            student1 detail = new student1();
           
            student1 detai3 = new student1("divya", 45, "eee", 456, 4);
            detai3.display();
            student1 detail2 = new student1("div", 4, "ee", 46, 7);
            detail2.display();

            detail.display();
        }
    }
}
