using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.cricket player");
            Console.WriteLine("2.hockey player");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                int s;
                int p;
                string g;
                string h;
                int j;

                cricketplayer cp = new cricketplayer(s=int.Parse(Console.ReadLine()),p= int.Parse(Console.ReadLine()),
                  g=  Console.ReadLine(),h= Console.ReadLine(),j= int.Parse(Console.ReadLine()));
                Console.WriteLine("palyer name" + g);
                Console.WriteLine("team name" + h);
                Console.WriteLine("no of mathces"+j);
                Console.WriteLine("no.of runs" + s);
                Console.WriteLine("no of wickets" + p);

                
            }
            else
                if (n == 2)
            {
                int s = int.Parse(Console.ReadLine());
                int p = int.Parse(Console.ReadLine());
                string g = Console.ReadLine();
   string h=Console.ReadLine();
                int j = int.Parse(Console.ReadLine());


                Hockeyplayer hp = new Hockeyplayer(s, p, g, h, j);
                Console.WriteLine("palyer name" + g);
                Console.WriteLine("team name" + h);
                Console.WriteLine("no of mathces"+ j);
                Console.WriteLine("no.of runs" + s);
                Console.WriteLine("no of wickets" + p);
            }
            else
                Console.WriteLine("enter correct input");
            
        }
    }
}
