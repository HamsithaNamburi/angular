using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionexample
{
    class Program
    {
        static void Main(string[] args)
        {
        
          /*try
          {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num / 2);
                //onsole.ReadLine();
                try
                {
                    int[] a = new int[] { 1, 2, 3 };
                    Console.WriteLine(a[4]);
                   
                }
             
            catch(IndexOutOfRangeException e)
             {
                 Console.WriteLine("dfdgdg");
              }
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Source);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Source);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Source);
            }
            finally
            {
                Console.WriteLine("program ended");
            }
            }
        }
    }
