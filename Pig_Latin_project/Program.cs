using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            int i = 0;
            int result1 = 0;
            bool bool2 = false;
            bool bool1 = false;         
            string cnstring;
            string remstring;
            Console.WriteLine("Enter a line to be translates:");         
            string cword = Console.ReadLine();

            while (!bool1 && !bool2 )
            {
                if (cword[i] != 'a' && cword[i] != 'e' && cword[i] != 'i' && cword[i] != 'o' && cword[i] != 'u' &&
                    cword[i] != 'A' && cword[i] != 'E' && cword[i] != 'I' && cword[i] != 'O' && cword[i] != 'U')
                {
                    if (cword[i + 1] == 'a' || cword[i + 1] == 'e' || cword[i + 1] == 'i' || cword[i + 1] == 'o' || cword[i + 1] == 'u' ||
                        cword[i + 1] == 'A' || cword[i + 1] == 'E' || cword[i + 1] == 'I' || cword[i + 1] == 'O' || cword[i + 1] == 'U')
                        
                    {
                        result1 = i;
                        bool1 = true;
                    }
                    else
                    {
                        i++;
                    }
                } 
                else
                {
                    bool2 = true;
                }
            }
        
                if (bool2 == true)
                {
                    Console.WriteLine("output :" + cword + "way");
                }
                else
                {
                    cnstring = cword.Substring(0, (result1 + 1));
                    remstring = cword.Substring(result1 + 1);        
                    Console.WriteLine("output :" + remstring + cnstring + "ay");
                }
            }
        }

    }


    




