using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }

        public static bool isPrime(int a )
        {
            int i = 2;



            while (i <= Math.Sqrt(a))
            {
                if (a % i == 0)
                {
                    return false;
                }
                i++;
            }
            
            return true;
        }
    }
}
