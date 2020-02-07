using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    interface login
    {
         void login();
    }
    class business_object

    { static List<buyer> blist = new List<buyer>();
    //{
    //    string f_name;
    //    string l_name;
    //    string user_name;
    //    string password;
    //    string email;
    //    string phn_no;
        //public business_object()
        //{
        //    Console.WriteLine("login");
        //}
        //public business_object(string f_name,string l_name, string user_name, string password, string email, string phn_no)
        //{
        //    this.f_name = f_name;
        //    this.l_name = l_name;
        //    this.user_name = user_name;
        //    this.password = password;
        //    this.email = email;
        //    this.phn_no = phn_no;

        //}
        public void signup(string f_name,string  l_name,string  user_name,string password, string email,string  phn_no)
        {


            //   List<business_object> ob1 = new List<business_object>();
           // List<business_object> b1 = new List<business_object>();
            blist.Add(new buyer(f_name, l_name, user_name, password, email, phn_no));

        }
        public bool login(string username,string password1)
       {
            buyer b = blist.Find(e =>e.password==password1 && e.username == username);
            
            if (b != null)
            {
               // Console.WriteLine("hii");
                return true;
            }
            else
                return false;


          
        }
    }
}
