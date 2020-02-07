using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance3
{
  abstract  class player
    {
        protected string str_name;
        protected string str_teamname;
        protected int no_of_matches;

        public player(string str_name,string str_teamname,int no_of_matches)
        {
          //  str_name = Console.ReadLine();
            this.str_name = str_name;
            this.str_teamname = str_teamname;
            this.no_of_matches = no_of_matches;
        }
        public abstract void displayplayerstatics();
    }
    class cricketplayer : player
    {
        int totalruns;
        int totalwickets;
        public override void displayplayerstatics()
        {

        }
        public cricketplayer(int totalruns, int totalwickets,string str_name,string str_teamname,int no_of_matches) :base(str_name,str_teamname,no_of_matches)
        {
          //  Console.WriteLine("enter total runs scored");
         ///   totalruns = int.Parse(Console.ReadLine());
            this.totalruns = totalruns;
            this.totalwickets = totalwickets;
        }
    }
    class Hockeyplayer : player
    {
        int position;
        int no_of_goals;
        public override void displayplayerstatics()
        {

        }
        public Hockeyplayer(int position, int no_of_goals, string str_name, string str_teamname,
            int no_of_matches):base(str_name,str_teamname,no_of_matches)
        {
        this.position= position;
            this.no_of_goals = no_of_goals;
        }
    }
}
