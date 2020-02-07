using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class employe
    {
        string name;
        string empid;
        string emp_desig;

        public string Name { get => name; set => name = value; }
        public string Empid { get => empid; set => empid = value; }
        public string Emp_desig { get => emp_desig; set => emp_desig = value; }

        public employe()
        {

        }
        public employe(string name,string empid,string emp_desig)
        {
            this.Name = name;
            this.Empid = empid;
            this.Emp_desig = emp_desig;
        }
      public override string ToString()
     {
         return this.Name + "\n" + this.Empid + "\n" + this.Emp_desig;
      }
        public override bool Equals(object obj)
        {
            employe temp = (employe)obj;
            if (this.Empid == temp.Empid && this.Name == temp.Name)  
            return true;
            else
                return false;
        }
    }
}
