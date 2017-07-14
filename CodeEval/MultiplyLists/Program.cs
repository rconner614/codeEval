using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorElement
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
                string[] firsts = line.Split('|')[0].Trim().Split(' ');
                string[] seconds = line.Split('|')[1].Trim().Split(' ');
                string output = null;
                int count = 0;
                foreach (var first in firsts)
                {
                    output = output + Convert.ToString(Convert.ToInt32(first) * Convert.ToInt32(seconds[count])) + ' ';
                    count += 1;
                }
                output += '\n';
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
