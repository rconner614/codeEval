using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollercoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = "data.txt";
            if (args.Length > 0)
                f = args[0];
            string[] lines = System.IO.File.ReadAllText(f).Split('\n');
            foreach (string line in lines)
            {
                int count = 0;
                string output = string.Empty;
                foreach (char c in line)
                {
                    output = output + (Char.IsLetter(c) ? ((count % 2 == 0 )? char.ToUpper(c) : char.ToLower(c)) : c);
                    //if char is an alphabetic character && count is even, capitalize the char || count is odd, lowercase char || not an alpha, do nothing
                    count += Char.IsLetter(c) ? 1 : 0;
                }
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
