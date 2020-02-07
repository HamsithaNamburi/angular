using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banktransactions
{
    class Program
    {
        static void Main(string[] args)

        {


            account acc = new account();
            long account = long.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string transtype = Console.ReadLine();

            account acc1 = new account(account, name, transtype);
 
            Console.WriteLine("enter transaction type");
            char s = char.Parse(Console.ReadLine());
            if (s == 'd')
            {
                acc.credit();
            }
            else
                if (s == 'w')
                acc.debit();
            else
                Console.WriteLine("enter the correct input");
           

            acc.display();
        }
    }
}
