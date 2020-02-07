using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectiongeniric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add('a');
            list.Add(34);
            foreach(int val in list)
            {
                Console.WriteLine(val);
               
            }
        }
    }
}
