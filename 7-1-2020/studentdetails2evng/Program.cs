using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdetails2evng
{
    class Program
    {
        static void Main(string[] args)
        {
            student.clgnmae();
            student std2 = new student();
            int rollno = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int classes = int.Parse(Console.ReadLine());
            int sem = int.Parse(Console.ReadLine());
            string branch = Console.ReadLine();
            student std = new student(rollno, name, classes, sem, branch);
            
            std2.displayresult();
            std2.display();
        }
    }
}
