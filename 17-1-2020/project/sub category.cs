using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
     class sub_category:category
    {
      public  string subcategory_id;
        string subcategory_name;
        string brief_details;
        int GST;
        
        //string brief_details;
        public sub_category(string subcategory_id, string subcategory_name, string brief_details, int GST, string category_id, string category_name) :
            base( category_id, category_name,brief_details)
        {
            this.subcategory_id = subcategory_id;
            this.subcategory_name = subcategory_name;
            this.Brief_details = brief_details;
            this.GST1 = GST;
        }
        public override string ToString()
        {
            return this.Subcategory_id + "\n " + this.Subcategory_name + "\n " + this.brief_details + "\n" + this.GST;
        }

        public string Subcategory_id { get => subcategory_id; set => subcategory_id = value; }
        public string Subcategory_name { get => subcategory_name; set => subcategory_name = value; }
        public string Brief_details { get => brief_details; set => brief_details = value; }
        public int GST1 { get => GST; set => GST = value; }
    }
   
}
