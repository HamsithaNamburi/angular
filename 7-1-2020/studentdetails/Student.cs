using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdetails
{
    class Student
    {
      public  int rollno;
        string name;
        int sem;
        string branch;
        int marks;

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get; set; }//auto implemented
        public int Sem
        {
            get
            {
                return sem;
            }
        }

        public string Branch { get => branch; set => branch = value; }

        public void acceptdetails()
        {
            Rollno = int.Parse(Console.ReadLine());
          name = Console.ReadLine();
            sem = int.Parse(Console.ReadLine());
            branch = Console.ReadLine();
           this.marks = int.Parse(Console.ReadLine());//currently active object
            Console.WriteLine("student details are accepted");

        }
        public void displaystudentdetails()
        {
            Console.WriteLine(Rollno);
            Console.WriteLine(Name);
            Console.WriteLine(sem);
            Console.WriteLine(branch);
            Console.WriteLine(marks);
            Console.WriteLine("student details are displayed");
        }

    }
}
