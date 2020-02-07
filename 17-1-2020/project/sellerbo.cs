using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class sellerbo
    {
        static List<seller> slist = new List<seller>();
        public void signup(string s_id, string username, string email, string password, string companyname, string GSTIN, string briefaboutcompany,
            string postal_address, string website, string number, string current_date)
        {


            //   List<business_object> ob1 = new List<business_object>();
            // List<business_object> b1 = new List<business_object>();
            slist.Add(new seller( s_id,  username,  email,  password, companyname,  GSTIN,  briefaboutcompany,
            postal_address,  website,  number,  current_date));

        }
        public bool login(string username, string password1)
        {
            seller b = slist.Find(e => e.Password == password1 && e.Username == username);
            //buyer b1= blist.Find(e => e.username == username);

            if (b != null)
            {
             //   Console.WriteLine("hii");
                return true;
            }
            else
                return false;


           
        }
       
    }
}

