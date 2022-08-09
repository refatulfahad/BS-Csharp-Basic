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
            Console.ReadKey();
        }
    }
}
