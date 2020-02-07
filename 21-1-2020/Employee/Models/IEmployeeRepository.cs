using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
  public  interface IEmployeeRepository
    {
        MyEmployee GetEmployee(int id);
        List<MyEmployee> display();
        bool Addemployee(MyEmployee employee);
    }
}
