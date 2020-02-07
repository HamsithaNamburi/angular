using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpe_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //     message();
            // greet();
            // numbers();
            // evenorodd();
            // fourthone();
            //fifth();
            //eight();
            //factr();
            //tenth();
            //eleven();
            //  twele();
            //thirteen();
            //len();
         //   rev();
         //   comp();
            palindrome();
            Console.ReadKey();

        }
        /* public static void message()
           {
               Console.WriteLine("welcome to the world of c# sharpe");
           }
           public static void greet()
           {
               string s = Console.ReadLine();
               Console.WriteLine("Hi" + " " + s);
               Console.WriteLine("welcome to the world of c# sharpe");

           }
           public static void numbers()
           {
               int i = int.Parse(Console.ReadLine());
               int j = int.Parse(Console.ReadLine());
               for (int k = i; k <= j; k++)
               {
                   Console.WriteLine(k);
               }

           }
           public static void evenorodd()
           {
               int i = int.Parse(Console.ReadLine());
               if (i % 2 == 0)
               {
                   Console.WriteLine("even");

               }
               else
                   Console.WriteLine("odd");
           }
           public static void fourthone()

           {
               int count = 0, odd = 0;
               int n = int.Parse(Console.ReadLine());

               int[] array = new int[n];
               for (int i = 0; i < n; i++)

               {

                   array[i] = int.Parse(Console.ReadLine());


                   if (array[i] % 2 == 0)
                   {
                       count = count + 1;

                   }
                   else
                       odd = odd + 1;

               }
               Console.WriteLine("no of evens" + count);
               Console.WriteLine("no of odds" + odd);




           }
           public static void fifth()
           {
               int i = int.Parse(Console.ReadLine());
           int f = (i * 9 / 5) + 32;
               Console.WriteLine(f);

           }
           public static void eight()
           {
               int n = 25;


               for (int i = 0; i <=n;i++)

               {


                   int j = i * i;

                   Console.WriteLine(j);


               }


           }
           public static void factr()
           {
               int j = int.Parse(Console.ReadLine());
           int fcat = 1;
               for(int i = 1; i < j; i++)
               {
                   fcat = fcat * i;
               }
               Console.WriteLine("factorial of given number" + fcat);


           }
           public static void tenth()
           {
               int a = 0, b = 1, temp;
                for(int i=0;i<=40;i++)
               {
                   Console.WriteLine(a);
               temp = a + b;
                   a = b;
                   b = temp;

               }
           } 
           public static void eleven()
           {
               int j= int.Parse(Console.ReadLine());
               for (int i = 1; i <= 20; i++)
               {
                   Console.WriteLine(i + "*" + j + "=" + (i * j));
               }
           }
        public static void twele()
        {
            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
            public static void thirteen()
            { 
                int i = int.Parse(Console.ReadLine());
                int j= int.Parse(Console.ReadLine());
                int k= int.Parse(Console.ReadLine());
                if (i > j && i > k)
                {
                    Console.WriteLine(i);
                }
                else if (j > k)
                {
                    Console.WriteLine(j);
                }
                else
                    Console.WriteLine(k);

            }
        public static void len()
        {
            string s = Console.ReadLine();
            int len = s.Length;
            Console.WriteLine(len);


        }
        public static void rev()
        {
            string s = Console.ReadLine();
            string rev = " ";
            int len = s.Length;
            int l = len - 1;
            for (; l >= 0; l--)
            {
                rev = rev + s[l];

            }
            Console.WriteLine(rev);


        }
        public static void comp()
        {
            string s = Console.ReadLine();
            string j = Console.ReadLine();
            int len1 = s.Length;
            int len2 = j.Length;

            if (len1 == len2)
            {
                Console.WriteLine("same");

                for (int i = 0; i < len1; i++)
                {
                    for (int k = 0; k < len2; k++)
                    {
                        while (s[i] == j[k])
                        {
                            if (i == '\0' && k == '\0')
                            {
                                Console.WriteLine("same");
                                break;
                            }
                            else
                                Console.WriteLine("different");
                        }
                    }
                }

            } else

                Console.WriteLine("different");
        }*/

        public static void palindrome()
        {
            string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            int h = s.Length;
            int i = h - 1;


       while(i>=0)     //String Reverse  
            {
                revs =revs+ s[i].ToString();
                i--;
            }
            if (s==revs) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            Console.ReadKey();
        }

            }

        }
    



