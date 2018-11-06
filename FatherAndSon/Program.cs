using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatherAndSon
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(WhatYear(37,24));
            Console.ReadKey();
            
        }
        // How many year later will the father's age be the twice of the son's age;
        public static int WhatYear(int father, int son)
        {
            int year = 0;
            if (son > father / 2)
            {
                while (father != son * 2)
                {
                    father--; son--; year--;                   
                }
            }

            else
            {
                while (father != son * 2)
                {
                    father++; son++; year++;                   
                }
            }
            return year;
        }
    }
}
