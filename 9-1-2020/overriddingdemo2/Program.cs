using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriddingdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student id :");
            int studid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student name :");
            string studname = Console.ReadLine();
            Console.WriteLine("Enter the student exam fees :");
            double examfee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("MENU \n 1.DayScholar \n 2.Hosteller");
            DayScholar ds = new DayScholar(studid, studname, examfee);
            Hosteller hs = new Hosteller(studid, studname, examfee);
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    {
                        Console.WriteLine("Choosen option 1");
                        ds.DisplayDetails(studid, studname, examfee);
                        ds.Payfee();
                        break;
                    }
                case 2:
                    {
                        hs.DisplayDetails(studid, studname, examfee);
                        hs.Payfee();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter valid option");
                        break;
                    }
            }
        }

    }
}
        
