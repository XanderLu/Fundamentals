using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabnacco
{
    class Program
    {
        static void Main(string[] args)
        {
            HAHA(25);
        }
        static Array HAHA(int a)
        {
            int[]result = new int[a];
            result[0] = 0;
            result[1] = 1;

            for (int i = 2; i < a; i++)
            {
                result[i] = result[i - 1] + result[i - 2]; 
            }

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

            return result;
        }

    }
}
