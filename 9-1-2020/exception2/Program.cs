using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception2
{
public class salaryException : Exception
    {
        public salaryException(string s):base(s)
        {

        }
    }
    public class Employee
    {
        string name;
        string empid;
        private int salary;
        public Employee(string name,string id,int salary)
        {
            this.name = name;
            this.empid = empid;
            this.Salary = salary;
        }

        public int Salary { get => salary; set => salary = value; }

        class Program
    {
        static void Main(string[] args)
            { 
                string name = Console.ReadLine();
                string empid = Console.ReadLine();
                int m = int.Parse(Console.ReadLine());


                Employee emp = new Employee(name, empid, m);
    
            try
            {
                if (emp.salary == 0) throw new salaryException("salary can not be zero");
            }
            catch(salaryException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
            }
        }
    }
}
