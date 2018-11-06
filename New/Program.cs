using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    class RomanNumberals
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Transform(48));
            
        }
        public static new Dictionary<int, string> romanN = new Dictionary<int, string>()
        {
            {1,"I" },{5,"V" },{10,"X" },{50,"L"},{40,"LX"},{4,"IV"},{20,"XX" },{30,"XXX" },{9,"IX" }     
        };
        
        
        static string Transform(int a)
        {
            string result = " ";
            int x, y;
            x = a % 10;
            y = a - x;

            while(a > 0)
            {
                if (a > 10)
                {
                    result += romanN[y];
                    a -= y;
                }
                
                if(a>0 && a <= 3)
                {
                    a -= 1;
                    result += romanN[1];
                }
                if( a == 4)
                {
                    result += romanN[4];

                }
                if(a>4 && a < 9)
                {
                    result += romanN[5];
                    a -= 5;                   
                }
                if (a == 9)
                {
                    result += romanN[9];
                    a -= 9;
                }
            }
            return result;

        }
        

        static string BetterTransform(int a)
        {
            int[] number = {1,4,5,9,10,40,50,90,100,400,500,900,1000 };
            string[] romanNum = { "I", "IV", "V", "X", "XL", "L", "XC", "C", "CD", "D", "CM","M"};
            string result = "";
            int i = number.Length - 1;
            while(a > 0)
            {
                if(a>= number[i])
                {
                    result += romanN[i];
                }
                i--;
            } 
            return result;
        }

    }
}
