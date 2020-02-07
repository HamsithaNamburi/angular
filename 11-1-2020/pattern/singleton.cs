using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
 public sealed class singleton
    {
    static int count = 0;
        static singleton instance = null;
        public static singleton Getinstance
        {
            get
            {
                if (instance == null) return new singleton();
                else return instance;
            }
        }
        private singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void printdetails(string name)
        {
            Console.WriteLine("hello world"+"  "+ name);
        }
    }
}
