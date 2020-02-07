using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class calculator
    {
        int val1;
        int val2;

        public int Val1 { get => val1; set => val1 = value; }
        public int Val2 { get => val2; set => val2 = value; }
        public calculator()
        {

        }
        public calculator(int val1, int val2)
        {
            this.val1 = val1;
            this.val2 = val2;


        }
        //cal by value type
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);

        }
        //call by reference
        public void swap(ref int va1, ref int va2)
        {
            int temp = va1;
            va1 = va2;
            va2 = temp;
            Console.WriteLine(va1);
            Console.WriteLine(va2);
        }

        public int Add1(int num1, int num2)
        {
            return num1 + num2;

        }
        public void substract(int num1, int num2, out int result)
        {
            result = num1 - num2;
        }
    }
}
