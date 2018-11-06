using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }

        
        public static string Factorial(int n)
        {
            int[] res = new int[500];
            string result = "";

            res[0] = 1;
            int res_size = 1;


            for (int x = 2; x <= n; x++)
                res_size = multiply(x, res,
                                    res_size);


            for (int i = res_size - 1; i >= 0; i--)
            {
                result += res[i];
            }
            return result;
        }


        static int multiply(int x, int[] res,
                            int res_size)
        {
            int carry = 0; 


            for (int i = 0; i < res_size; i++)
            {
                int prod = res[i] * x + carry;
                res[i] = prod % 10;

                carry = prod / 10;
            }


            while (carry != 0)
            {
                res[res_size] = carry % 10;
                carry = carry / 10;
                res_size++;
            }
            return res_size;
        }
    }


}
