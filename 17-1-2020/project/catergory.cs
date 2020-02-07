using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    abstract class category
    {
        string category_id;
        string category_name { get; set; }
        string brief_details { get; set; }
        public string Category_id { get => category_id; set => category_id = value; }

        public category(string category_id, string category_name, string brief_details)
        {
            this.category_id = category_id;
            this.category_name = category_name;
            this.brief_details = brief_details;

        }
        public override string ToString()
        {
            return this.category_id + "\n " + this.category_name + "\n " + this.brief_details ;
        }



    }
}
