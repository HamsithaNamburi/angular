using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    interface Istudent
    {



        string Name { get; set; }
        int Stu_id { get; set; }



        void showdetails();

    }
    class resident : Istudent
    {
        string Name; int Stu_id;
        int Istudent.Stu_id
        {
            get { return Stu_id; }
            set { Stu_id = value; }
        }
        string Istudent.Name { get; set; }

        public resident()
            {
            this.Stu_id = Stu_id;
            this.Name = Name;
            }
        public void showdetails()
        {
            Console.WriteLine(this.Name + "\n" + this.Stu_id);
        }

    }
    class dayscholor : Istudent
    {
        string Name; int Stu_id;
        int Istudent.Stu_id { get; set; }
        string Istudent.Name { get; set; }

        public dayscholor()
        {
            this.Stu_id = Stu_id;
            this.Name = Name;
        }
        public virtual void showdetails()
        {

  
    
            Console.WriteLine(this.Name + "\n" + this.Stu_id);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.resident");
            Console.WriteLine("2.dayscholor");
                int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                resident r = new resident();
                r.showdetails();
            }
            else
                if (n == 2)
            {
                dayscholar ds = new dayscholar();
                ds.
              
            }

        }
    }
}
