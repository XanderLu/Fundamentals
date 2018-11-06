using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(19940207));
            
            int x = 333838832;
            int y = 512345616;
            int n = (x * y) % 10;
            Console.WriteLine(n);
        }

        public static double Reverse(int a)
        {
            double result = 0;           
            double b=1;                     
            double X =a.ToString().Length-1;

            while (a!=0)
            {
                b = Math.Pow(10, X--);                
                result += a % 10 * b;

                a -= a % 10;
                a /= 10;                             
            }
            return result;
            // This is my solution which is stupid.
            while (a != 0)
            {
                result = result * 10;
                a = a / 10;
            }

        }

    }
}
