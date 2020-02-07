using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class itembo
    {
        
       static List<item> ilist = new List<item>();
        static List<sub_category> clist = new List<sub_category>();
      // itembo ob = new itembo();

      public void items(int id, int price, string item_name, string description, int stock_number, string remarke, string subcategory_id, string subcategory_name, string brief_details, int GST, string category_id, string category_name)
        {
            sub_category sb1 = new sub_category(subcategory_name, subcategory_id, brief_details, GST, category_id, category_name);

            ilist.Add(new item(id, price, item_name, description, stock_number, remarke, sb1));

        }

        public void display()
        {
            foreach (var c in clist)
            {
                Console.WriteLine(c.ToString());
            }


            foreach (var s in ilist)
            {

                Console.WriteLine(s.ToString());
            }
            //foreach (var c in clist)
            //{
            //    Console.WriteLine(c.ToString());
            //}

        }


        public List<item> category(string categoryid, string subcategory)
        {
           List<item> c = ilist.Where(e => e.subcategory.Category_id == categoryid && e.subcategory.Subcategory_id == subcategory).ToList();

            if (c != null)
            {
                //Console.WriteLine("hii");
               
                return c;
                
            }
            else
                return c;

            
        }
        //search by price range
        public void searchprice()
        {

            Console.WriteLine("enter the minimum price");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the maximum price");
            int max = int.Parse(Console.ReadLine());
            List<item> p = ilist.FindAll(e => e.price > min && e.price < max);
            foreach (item s in p)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
    
}
