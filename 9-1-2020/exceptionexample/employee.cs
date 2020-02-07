using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionexample
{
    class employee
    {
        string name;
        string empid;
        int salary;
        public employe()
        {

        }
        public employe(string name, string empid, int salary)
        {
            this.name = name;
            this.empid = empid;
            this.salary = salary;
        }
        public override string ToString()
        {
            return this.name + "\n" + this.empid + "\n" + this.salary;
        }
        public override bool Equals(object obj)
        {
            employeetemp = (employe)obj;
            if (this.empid == temp.empid && this.name == temp.name)
                return true;
            else
                return false;
        }
    }

   
