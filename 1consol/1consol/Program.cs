using System;
using System.Text.RegularExpressions;

namespace _1consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\tВведите строку (все англ. слова заменятся на :\'...\' ): \n\t");
            string str = Console.ReadLine();
            string rex = "[a-zA-Z]+";
            string str2 = Regex.Replace(str, rex, "...");
            Console.Write($"\n\tРезультат: {str2}");
        }
    }
}
