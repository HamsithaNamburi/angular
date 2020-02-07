using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<category> clist = new List<category>();
            business_object ob2 = new business_object();
            itembo ib = new itembo();
            sellerbo sbo = new sellerbo();
            while (true) { 
            Console.WriteLine("*********WElCOME TO EMART********");
            Console.WriteLine("1.Buyer");
            Console.WriteLine("2.seller");
            Console.WriteLine("3.exit");
           
               string f_name;
               string l_name;
               string user_name;
                string username;
               string password;
               string email;
               string phn_no;
                bool status;
               // bool ss;

            int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    //Buyer*********************
                    case 1:
                        Console.WriteLine("1.Login");
                        Console.WriteLine("2.Registeration");
                        int n1 = int.Parse(Console.ReadLine());
                        if (n1 == 1)
                        {
                            Console.WriteLine("enter user name");
                            username = Console.ReadLine();
                            Console.WriteLine("enter password");
                            password = Console.ReadLine();
                            status = ob2.login(username, password);
                            if (status == true)
                            {
                                Console.WriteLine("1.Electronic 2.grocerey 3.Homeappliances 4.kitchen 5.fashion ");
                                Console.WriteLine("enter category id");
                                string category = Console.ReadLine();
                                Console.WriteLine("enter subcategory id");
                                string subcategory_id = Console.ReadLine();
                                List<item> items=ib.category(category, subcategory_id);

                                if (items.Count!=0)
                                {
                                    foreach(var s in items)
                                    {
                                        Console.WriteLine(s.ToString());
                                    }
                                }
                                
                                else
                                    Console.WriteLine("invalid credentials");
                                Console.WriteLine("search by price");
                                ib.searchprice();

                            }
                            else
                                Console.WriteLine("invalid credentials");
                        }

                        else if (n1 == 2)
                        {
                            //*********************seller********************
                            Console.WriteLine("enter firstname");
                            f_name = Console.ReadLine();
                            Console.WriteLine("enter l_name");
                            l_name = Console.ReadLine();
                            Console.WriteLine("enter username");
                            user_name = Console.ReadLine();
                            Console.WriteLine("enter password");
                            password = Console.ReadLine();
                            if(password=="")
                            Console.WriteLine("enter email");
                            email = Console.ReadLine();
                            Console.WriteLine("enter phone number");
                            phn_no = Console.ReadLine();

                            ob2.signup(f_name, l_name, user_name, password, email, phn_no);
                        } 
                    break;

                case 2:
                    Console.WriteLine("1.Login");
                    Console.WriteLine("2.Registeration");
                    int n2 = int.Parse(Console.ReadLine());
                    if (n2 == 1)
                    {
                            Console.WriteLine("enter user name");
                            string username1 = Console.ReadLine();
                            Console.WriteLine("enter password");
                            string password1 = Console.ReadLine();
                            status = sbo.login(username1, password1);
                            //Console.WriteLine("view  myprofile");
                            //Console.WriteLine("display categories");
                            //Console.WriteLine("Add Items");
                            if (status == true)
                        {
                                Console.WriteLine("CATEGORY");
                                Console.WriteLine("1.ELECTRONICS 2.GROCERY 3.HOME APPLIANCES");
                                Console.WriteLine("ENTER CATEGORY NAME");
                                string  q = Console.ReadLine();
                                string subc;

                                if (q == "electronics")
                                {
                                    Console.WriteLine("electronics subcategory");
                                    Console.WriteLine("1.mobiles 2.telivisions 3.washingmachines 4.fridges");
                                     subc = Console.ReadLine();


                                }
                                else
                                    if (q == "grocery")
                                {
                                    Console.WriteLine("enter grocery items");
                                    Console.WriteLine("1.pulses 2.rice ");
                                     subc = Console.ReadLine();

                                }
                                else
                                    if (q == "home appliances")
                                {
                                    Console.WriteLine("enter home appliances ");
                                    Console.WriteLine("1.soafs 2.tables ");
                                     subc = Console.ReadLine();
                                }

                               Console.WriteLine("entered category id");
                                string category_id = Console.ReadLine();
                                //Console.WriteLine(category_id);
                                Console.WriteLine("enter category name "); 
                                string category_name = Console.ReadLine();
                                Console.WriteLine("enter subcatecory name");
                                string subcategory_name = Console.ReadLine();
                                Console.WriteLine("enter subcategory id ");
                                string subcategory_id = Console.ReadLine();
                                Console.WriteLine("enter brief details ");
                                string brief_details = Console.ReadLine();
                                Console.WriteLine("enter gst ");
                                int GST = int.Parse(Console.ReadLine());
                               
                                Console.WriteLine("enter item id");
                                int id = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter the price");
                                int price = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter item name");
                                string item_name = Console.ReadLine();
                                Console.WriteLine("enter description");
                                string description = Console.ReadLine();
                                Console.WriteLine("enter stock number ");
                                int stock_number = int.Parse(Console.ReadLine());
                                Console.WriteLine("enter remarks");
                                string remarke = Console.ReadLine(); 
                                sub_category sc = new sub_category(subcategory_name, subcategory_id, brief_details, GST, category_id, category_name);
                                ib.items(id, price, item_name, description, stock_number, remarke, subcategory_name,
                                    subcategory_id, brief_details, GST, category_id, category_name);
                                      ib.display();
                        }
                        else
                            Console.WriteLine("invalid credentials");

                    }
                    else if (n2 == 2)
                    {
                        Console.WriteLine("enter Id");
                        string id = Console.ReadLine();
                        Console.WriteLine("enter username");
                        username = Console.ReadLine();
                        Console.WriteLine("enter password");
                        password = Console.ReadLine();
                        Console.WriteLine("enter company name");
                        string companyname = Console.ReadLine();
                        Console.WriteLine("enter GSTIN");
                        string GSTIN = Console.ReadLine();
                        Console.WriteLine("enter brief about company");
                        string briefaboutcompany = Console.ReadLine();
                        Console.WriteLine("enter postal address");
                        string postaladdress = Console.ReadLine();
                        Console.WriteLine("enter website");
                        string website = Console.ReadLine();
                        Console.WriteLine("enter email ID");
                        email = Console.ReadLine();
                        Console.WriteLine("enter contactno");
                        string number = Console.ReadLine();
                            Console.WriteLine("enter current date");
                            string current_date = Console.ReadLine();

                            sbo.signup(id, username, email, password, companyname, GSTIN, briefaboutcompany,
            postaladdress, website, number, current_date);
                           
                        }else
                        Console.WriteLine("invalid option");
                    break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    
                 }
            
            }
          

        }

    }
            
        
}
