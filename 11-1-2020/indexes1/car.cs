using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexes1
{
    class car
    {
        int year;
        string[] name = new string[6];
        public int Year { get => this.year; set => this.year = value; }
       // public string[] Name { get => name; set => name = value; }
       public string this[int x]
        {

            get
            {
                return name[x];
            }
            set
            {
                name[x] = value;
            }
        }
        public void display()
        {
            foreach (var n in name)
                Console.WriteLine(n);
        }
    }
}
