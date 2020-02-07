using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    public abstract class Student
    {
        string name;
        string stu_id;
        int grade;
        public abstract Boolean Ispassed(int grade);
        public Student(string name, string stu_id, int grade)
        {
            this.name = name;
            this.stu_id = stu_id;
            this.grade = grade;
        }
    }
        class ug : Student
        {

        public override bool Ispassed(int grade)
        {
            if (grade == 70)
            {
                return true;
             // Console.WriteLine(true);
            }
            else
                return false;
          //Console.WriteLine(true);
        }
        public ug(string name, string stu_id, int grade) : base(name, stu_id, grade)
        {

            Console.WriteLine(name + "\n" + stu_id + "\n" + grade);
        }
    }
    class g : Student
    {

        public override bool Ispassed(int grade)
        {
            if (grade == 80)
            {
                return true;
            }
            else
                return false;
        }
        public g(string name, string stu_id, int grade) : base(name, stu_id, grade)
        {

            Console.WriteLine(name + "\n" + stu_id + "\n" + grade);
        }
    }

}
