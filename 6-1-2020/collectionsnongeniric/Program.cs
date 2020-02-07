using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectionsnongeniric
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
            }
                al.Add(5);
            al.Add("hamsi");
            al.Add(23.4);
            al.Add('d');
            al.Add(67);
          
         foreach(var val in al)//declare the var data type
            {
                Console.WriteLine(val);
            }
                Queue qlist=new Queue();
            qlist.Enqueue(1);
            qlist.Enqueue('h');
            qlist.Enqueue(23.5);
            qlist.Dequeue();
            Console.WriteLine(qlist.Dequeue());
            foreach (var val in qlist)
            {
                Console.WriteLine(val);
            }
            // Console.ReadLine();
            Stack slist = new Stack();
            slist.Push("hello");
            slist.Push('a');
            slist.Push("hamsi");
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach(var s in slist)
            {
                Console.WriteLine(s);
            }
            Hashtable ht = new Hashtable();
           
            ht.Add(1,"hamsi");
            ht.Add(2, 'r');
            ht.Add("t2", 4);
            foreach( var val in ht.Keys)
            {
                Console.WriteLine(val);
                Console.WriteLine(ht[val]);
            }

            List<int> list = new List<int>();
            list.Add(12);
            list.Add('e');
            list.Add(45);
            foreach(var val in list)
            {
                Console.WriteLine(val);
            }

            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("sdfe");
            gqlist.Enqueue("fse");
            gqlist.Enqueue("hama");
            gqlist.Dequeue();
            Console.WriteLine(gqlist.Dequeue());
            foreach (var val in gqlist)
            {
                Console.WriteLine(val);
            }
            Stack<float> kslist = new Stack<float>();
            kslist.Push(45.78f);
            kslist.Push(67.7f); 
           // slist.Push("hamsi");
            Console.WriteLine(kslist.Pop());
            Console.WriteLine(kslist.Peek());
            foreach (var s in kslist)
            {
                Console.WriteLine(s);
            }
            HashSet<int> hslist = new HashSet<int>();
            hslist.Add(5);
            hslist.Add(56);
            hslist.Add(47);
            hslist.Add(47);
           // hslist.Remove(56);
            foreach (var s in hslist)
            {
                Console.WriteLine(s);
            }
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("gjkg", 5);
            dict.Add("fgikd", 7);
            dict.Add("vbgskad", 6);
            foreach (var s in dict.Keys)
            {
                Console.WriteLine(s);
                Console.WriteLine(dict[s]);
            }
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            Console.WriteLine("enter no of employees");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("name" + " " + "salary");
            
            for (int i = 0; i < n; i++)
            {

                string s = Console.ReadLine();
                int k = int.Parse(Console.ReadLine());
                dict2.Add(s,k);
            }
            int hsalary = 0;
            string hname = "";

            foreach(KeyValuePair<string,int> x in dict2)
            {
                if (x.Value > hsalary)
                {
                    hsalary = x.Value;
                    hname = x.Key;
                    
                }
                
            }
            Console.WriteLine("the heighst paid salary is" + hname);

            Console.ReadLine();
       


        }
    }
}
