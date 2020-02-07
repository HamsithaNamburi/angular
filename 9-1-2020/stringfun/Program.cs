using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringfun
{
    class Program
    {
        static void Main(string[] args)
        {
          //string str = "welcome";
        //  Console.WriteLine(str.Length + "\n " + str.ToLower() + "\n " + str.ToUpper() + " \n" + str.Substring(5) + "\n "
          //    + str.Replace('l', 'e') + "\n " + str.Insert(5, "hello") + "\n " + str.TrimEnd('m') + "\n " + str.Clone() + "\n " + str.Contains('s') + " " +
          //    str.CompareTo("come") + "\n " + string.Compare("hello", "Hello") + "\n" + str.TrimStart('w') + "\n" + str.Remove(3));
          //string data = Console.ReadLine();
          //string[] datnum = data.Split(' ');
            // int num2 = Array.ConvertAll(datnum, Convert.ToInt32);
            //foreach(string val in data)
            //   {
            //       Console.WriteLine(val);

            //    }
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dddd/MMMM/yyyy") + " " + dt.ToString("dddd,MMMM,yyyy"));
            int[] ix = new int[] { 1, 2, 3, 4, };
            employe[] earray = new employe[3] //static allocation
                {
                new employe("hamsi","100",75685),new employe("ami","100",75685),new employe("hak","100",75685) };
            foreach(employe e in earray)
            {
                Console.WriteLine();
            }
            List<employe> elist = new List<employe>(); //dynamic allocation
            elist.Add(new employe("hamsi", "100", 75685));
            elist.Add(new employe("ami", "100", 75685));
elist.Add(new employe("hamk", "100", 75685));
            foreach(employe e in elist)
            {
                Console.WriteLine(e.ToString());
            }
            employe e1 = new employe("ram", "sdfs", 523);
            employe e2 =new employe("ram", "sdfs", 523);
            if (e1.Equals(e2))
            {
                Console.WriteLine("both are same");
            } 
            else
                Console.WriteLine("differ");
}
    }
}
