using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class seller
    {
        string s_id;
        string username;
        string email;
        string password;
        string companyname;
        string GSTIN;
        string briefaboutcompany;
        string postal_address;
        string website;
        string number;
        string current_date;
        public seller(string s_id,string username,  string email,string password,string companyname,string GSTIN,string briefaboutcompany,
            string postal_address,string website,string number,string current_date)
        {
            this.S_id = s_id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.companyname = companyname;
            this.GSTIN = GSTIN;
            this.briefaboutcompany = briefaboutcompany;
            this.postal_address = postal_address;
            this.website = website;
            this.number = number;
            this.current_date = current_date;



        }

        public string S_id { get => s_id; set => s_id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
