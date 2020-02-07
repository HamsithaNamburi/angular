using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seller2.Model
{
    public class myseller
    {
        public int s_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string companyname { get; set; }
        public string GSTIN { get; set; }
        public string Address { get; set; }
        public string website { get; set; }

        public string Email { get; set; }
        public string c_no { get; set; }
        public myseller(int s_id,string username,string password,string GSTIN,string Address,string website,
            string emial,string c_no)
        {
            this.s_id = s_id;
            this.username = username;
            this.password = password;
            this.GSTIN = GSTIN;
            this.Address = Address;
            this.website = website;
            this.Email = emial;
            this.c_no = c_no;
        }
    }
}
