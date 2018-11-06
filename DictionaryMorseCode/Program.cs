using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryMorseCode
{
    public class Morse
    {

        public static Dictionary<char, string> morseCode = new Dictionary<char, string>
            {
                {'A',".-"},
                { 'B'," -..."},
                { 'C',"-.-." },
                {'D',"-.." },
                {'E',"." },
                {'F',"..-." },
                {'G',"--." },
                {'H',"...." },
                {'I',".." },
                {'J',".---" },
                {'K',"-.-" },
                {'L',".-.." },
                {'M',"--" },
                {'N',"-."},
                {'O',"---" },
                {'P',".--." },
                {'Q',"--.-"},
                {'R',".-." },
                {'S',"..."},
                {'T',"-" },
                {'U',"..-" },
                {'V',"...-" },
                {'W',".--" },
                {'X',"-..-" },
                {'Y',"-.--"},
                {'Z',"--.."},


                { '0',"-----" },
                {'1',".----"},
                {'2',"..---"},
                {'3',"...--" },
                {'4',"....-" },
                {'5',"....." },
                {'6',"-...." },
                {'7',"--..." },
                {'8',"---.." },
                {'9',"----." },

            };




        static void Main(string[] args)
        {         
           
            string msg = "hello world";
            Console.WriteLine(Morse.Tx(msg));
            int x,y, a, A, b, B;
            
        }

        public static string Tx(string x)
        {
            string result = "";
            char[] letters = x.ToUpper().ToCharArray();

            foreach (char y in letters)
            {
                if(y==' ')
                {
                    result += "   ";
                }
                else
                result += morseCode[y]+" ";
            }

            return result;
        }
     
    


    }
}
