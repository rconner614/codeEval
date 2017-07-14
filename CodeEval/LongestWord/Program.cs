using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
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
                string output = string.Empty;
                int count = 0;
                string[] words = line.Split(' ');
                foreach (var word in words)
                {
                    output = output.Length >= word.Length ? output : word;
                    count += 1;
                }
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
