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
        public string username;
        string email;
        string current_date;
        public   string password;
        public   string number;
        
        public buyer(string b_id,string username, string email, string current_date,string password, string number)
        {
            this.B_id = b_id;
            this.username = username;
            this.email = email;
            this.number = number;
            this.current_date = current_date;
            this.password = password;
            Console.WriteLine(this.B_id + " " + this.username + " " + this.email + " " + this.number + " " + this.current_date,this.password);
             
        }

        public string B_id { get => b_id; set => b_id = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Current_date { get => current_date; set => current_date = value; }
       
        public string Number1 { get => number; set => number = value; }
    }
}
