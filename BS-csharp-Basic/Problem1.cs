using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_csharp_Basic
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            //problem-1
            Console.WriteLine("Hello World");
            

            //problem-2
            int val = 10000;
            long mx = 10000000000;
            double dval = 3.59;
            char ch = 'B';
            string st = "brainstation-23";
            Console.WriteLine($"{val} {mx} {dval} {ch} {st}");

            //Problem1-3
            int x = 2147483647;
            try
            {
                int y = checked(x+1);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //problem-4
            string str1 = "123";
            int num1=Int32.Parse(str1);

            string str2 = "10000000000";
            long num2=Int64.Parse(str2);

            string str3 = "123.50";
            double num3=Double.Parse(str3);

            int num4 = 23;
            string str4 = num4.ToString();

            string str5 = "true";
            bool flag = bool.Parse(str5);

            bool flag1=true;
            string str6 = flag1.ToString();

            int num5 = 100;
            long num6 =num5;

            char ch1 = 'A';
            int num7 = ch1;

            int num8 = 25;
            char ch2 = (char)(num8 + 'A'); 


            Console.WriteLine($"string to int {num1}\nstring to long {num2}\nstring to double {num3}\n" +
                $"int to string {str4}\nstring to bool {flag}\nchar to ASCII {num7}\n"+
                $"ASCII to char {ch2}");


            //problem-5
            int x1 = 4, y1 = 8;
            Console.WriteLine($"{x1 * y1} {x1 / y1} {x1%y1} {x1|y1} {x1^y1} {x1&y1}");

            //Problem-6
            int year = 2022;
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is leap year");
            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine($"{year} is leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }

            //Problem-7
            if(5<6 || 10 < 5)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }

            //problem-8
            year = 2004;
            string leap = (year % 400) == 0 ? "leap year" : (year % 4 == 0 && year % 100 != 0) ? "leap year" : "not leap year";
            Console.WriteLine(leap);

            //problem-9
            //This is Single comment
            /*This is Multiline comment*/

            //problem-10
            int[]ar=new int[100];
            for(int i = 1; i <= 100; i++)
            {
                ar[i-1]=i;
                if (i == 95) continue;
                Console.Write(i + " ");
                if (i == 99) break;
            }
            Console.WriteLine();

            int cnt = 0;
            while (cnt <= 100)
            {
                ++cnt;
                if (cnt == 95) continue;
                Console.Write(cnt + " ");
                if (cnt == 99) break;   
            }
            Console.WriteLine();

            cnt = 0;
            do
            {
                ++cnt;
                if (cnt == 95) continue;
                Console.Write(cnt + " ");
                if (cnt == 99) break;
            } while (cnt <= 100);

            foreach (int i in ar)
            {
                if (i == 95) continue;
                Console.Write(i+" ");
                if (i == 99) break;
            }
            Console.ReadKey();
        }
    }
}
