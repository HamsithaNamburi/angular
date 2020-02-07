using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class item
    {
       public int id { get; set; }
       public  int price { get; set; }
    public string item_name { get; set; }
      public   string description { get; set; }
      public   int stock_number { get; set; }
       public  string remarks { get; set; }

        string brief_details;
     public    sub_category subcategory { get; set; }
        public item(int id,int price,string item_name,string description,int stock_number,string remarke,sub_category sb)
        {
            this.id = id;
            this.price = price;
            this.item_name = item_name;
            this.description = description;
            this.stock_number = stock_number;
            this.remarks = remarke;
            this.subcategory = sb;
        }

        public string Brief_details { get => brief_details; set => brief_details = value; }

        public override string ToString()
        {
            return this.id + "\n" + this.item_name + "\n " + this.price + "\n " + this.stock_number + "\n " + this.description + " \n" +this.subcategory;
        }

    }
}
