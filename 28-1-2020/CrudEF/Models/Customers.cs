using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEF.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Amount { get; set; }
        public Customers()
        {

        }
        public Customers(int id, string name, string email, int amount)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Amount = amount;
        }
    }
}
