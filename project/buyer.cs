using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class buyer
    {
        string b_id;
        string username;
        string email;
        int number;
        string current_date;
        string password;
        public buyer(string b_id,string username, string email, int number,string current_date,string password)
        {
            this.b_id = b_id;
            this.username = username;
            this.email = email;
            this.number = number;
            this.current_date = current_date;
            this.password = password;
            Console.WriteLine(this.b_id + " " + this.username + " " + this.email + " " + this.number + " " + this.current_date,this.password);
             
        }
    }
}
