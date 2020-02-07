using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignmentmvc.Models;

namespace Assignmentmvc.Repositeries
{
    public class EmployeeRepository
    {
        public static List<Employee> elist = new List<Employee>(){ new Employee(){
            Eid="1", Name="mohan",Desig="PAT",Proname="abc",Password="1234"}
  };
        public EmployeeRepository()
        {

        }

        public void add(Employee item)
        {
            elist.Add(item);
        }
        public Employee validate(string Eid,string pwd)
        {
            foreach (var v in elist)
            {
                if (v.Eid == Eid && v.Password == pwd)
                {
                    return v;
                }
               
           }
          return null;
            
        }
    }
}
