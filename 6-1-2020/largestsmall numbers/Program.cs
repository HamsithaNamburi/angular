using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//finding largest and smallest numbers from a set 
namespace largestsmall_numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter no.of inputs");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int high, low;
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            high = 0;
            low = num[0];
            for(int i = 0;i < n; i++){
                if (num[i] > high)
                    high = num[i];
                if(num[i]<low)
                low = num[i];


            }

            Console.WriteLine(high + "\n" + low);     

        }
    }
}
