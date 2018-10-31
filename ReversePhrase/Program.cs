using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReversePhrase
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;

            Console.WriteLine("Enter a phrase to reverse: ");
            x = Console.ReadLine();
            string text = String.Join(" ", Regex.Split(x, @"(\W+)").Reverse().ToArray());
             

            Console.WriteLine(text);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
