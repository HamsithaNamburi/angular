using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{ 
    public class EmployeeRepository:IEmployeeRepository
    {
        private List<MyEmployee> Elist;
        public EmployeeRepository()
        {
            Elist = new List<MyEmployee>() { new MyEmployee(1, "hamsi", "hamsithanamburi@gmail.com",Dept.It), new MyEmployee(2, "jhon", "jhon@esftgrd", Dept.Insurance), new MyEmployee(3, "fdgfh", "dgfdgf@gmail.com", Dept.Accounts) };
            
        }
        public MyEmployee GetEmployee(int id )
        {
            MyEmployee e = Elist.FirstOrDefault(e =>e.id ==id);
            
            return e;         
        }
       public List<MyEmployee> display()
        {
            return Elist;
        }
        public bool Addemployee(MyEmployee employee)
        {
            employee.id = Elist.Max(e => e.id) + 1;
            Elist.Add(employee);
            return true;
        }
    }
}
