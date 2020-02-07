using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            buyerBo bb0 = new buyerBo();
            ProductBo pbo = new ProductBo();
            while (true)
            {

                Console.WriteLine("Select the user: \n 1.Buyer \n 2.Seller \n 3.Admin");
            int opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                    case 1:
                        Console.WriteLine("Enter id: ");
                        int bid = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter password:");
                        string Password = Console.ReadLine();
                        bb0.checkbuyer(bid,Password);
                         Console.WriteLine("Enter  the name  :");
                        string bname = Console.ReadLine();
                        Console.WriteLine("Enter mobile number");
                        double mobile = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter mail:");
                        string Email = Console.ReadLine();
                        Console.WriteLine("Dateof Creation:");
                        DateTime CreatedDate = Convert.ToDateTime(DateTime.Now);
                        Console.WriteLine(CreatedDate);

                         bb0.InitializeBuyersList(bid,bname,Password,mobile,Email,CreatedDate);
                       // pbo.InitializeProductList();
                        Console.WriteLine("----------------Product Category--------------------");
                        Console.WriteLine("\n 1.Electronic goods \n 2.Tvs & Appliances \n 3.Home & furniture \n 4.Mens \n 5.Womens \n 6.Sports Books & more \n 7.offer Zone");
            
                        Console.WriteLine("Enter Category :");
                        int opt1 = int.Parse(Console.ReadLine());
                        switch (opt1)
                        {
                            case 1:
                                pbo.ElectronicProductList();           

                                break;


                        }

                        break;




            }
        }


        }
    }
}
