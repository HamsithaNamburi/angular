using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            List<employe> elist = new List<employe>();
            while (i!=0)
            {
                Console.WriteLine("******menu****");
                Console.WriteLine("1.Insert Employe Details");
                Console.WriteLine("2.Display all employee details");
                Console.WriteLine("3.Update employee details");
                Console.WriteLine("4.Delete specific employees");
                Console.WriteLine("5.exit");
                int n = int.Parse(Console.ReadLine());
               

                // int emp_id;

                if (n == 1)
                {

                    //for (int i = 0; i <2; i++)
                    // {
                    Console.WriteLine("enter employee id");
                    string emp_id = Console.ReadLine();
                    Console.WriteLine("enter employee name");
                    string emp_name = Console.ReadLine();
                    Console.WriteLine("enter employee desig");
                    string emp_des = Console.ReadLine();
                    elist.Add(new employe(emp_id, emp_name, emp_des));

                    // }
                }
                else if (n == 2)
                {


                    foreach (var s in elist)
                    {
                        Console.WriteLine(s.ToString());
                    }
                }
                else
                    if (n == 3)
                {
                    // List<employe> elist2 = new List<employe>();

                    Console.WriteLine("enter employee id");
                    string emp_id = Console.ReadLine();
                    foreach (employe s in elist)
                    {
                        if (s.Empid == emp_id)
                        {
                            Console.WriteLine("enter designation and name");
                        }
                            Console.WriteLine("enter employee name");
                      string Name = Console.ReadLine();
                            s.Name = Name;
                            Console.WriteLine("enter employee desig");
                        string Emp_desig = Console.ReadLine();
                            s.Emp_desig = Emp_desig;
                            Console.WriteLine(s.Name + " " + s.Emp_desig);
                        
                    }
                }
                else
                    if (n == 4)
                {
                    Console.WriteLine("enter employee id");
                    string emp_id = Console.ReadLine();
                    employe e = elist.Find(a => a.Empid == emp_id);
                }
                else
                    if (n == 5)
                     i =int.Parse(Console.ReadLine());
                ///  elist.Exists()
            }

        }

    }
}