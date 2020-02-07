using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdetails
{
    class student1
    {
        int rollno;
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
            set
            {
                sem = value;
            }
        }

        public int Marks { get => marks; set => marks = value; }
        public string Branch { get => branch; set => branch = value; }

        public void Aceept()
        {
            Console.WriteLine("enter the marks");
            this.marks = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the branch");
            this.branch = Console.ReadLine();


        }
        public void display()
        {
            Console.WriteLine("student details");
            Console.WriteLine(this.Name + "\n" + this.Rollno + "\n" + this.Marks + "\n" + this.Branch + this.Sem);

        }
        public student1()//default constructor
        {
        this.Name = "hamsi";
         this.Sem = 4;
          this.Rollno = 51;
           this.Branch = " ";
          this.Marks = 56786;
          
        }
        public student1(string name,int rollno,string branch,int marks,int sem)//parameterized constructor
        {
            this.Name = name;
            this.Sem = sem;
            this.Rollno = 51;
            this.Branch = branch;
            this.Marks = marks;
        }
       
    }
}
