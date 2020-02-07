using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banktransactions
{
    class account
    {
        static string Bname = "sbi";
        long accno;
        string cusname;
        string acctype;
        string trancstype;
        int amount = 50000;
    // int newamount;
        int balance;


        public void credit()
        {
            Console.WriteLine("enter the ammount to be credited");
            int amount1 = int.Parse(Console.ReadLine());
            balance = amount + amount1;
        }
        public void debit()
        {
            Console.WriteLine("enter the ammount to be deited");
            int amount1 = int.Parse(Console.ReadLine());
             balance = amount - amount1;
        }
    static account()//static constructor
        {
            Bname = "sbi";
        }
        public account()
        {

        }
        public account(long accno, string cusname, string acctype)
        {
            Bname = "sbi";
            Console.WriteLine("welcome to the bank");
            Console.WriteLine(accno);
            Console.WriteLine(cusname);
            Console.WriteLine(acctype);

        }
        public void display()
        {
            Console.WriteLine("bank name" + Bname);

            Console.WriteLine("the new amount=" + balance);
           
        }
     
    }
}
