using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._3._1
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = "Kobyła ma mały bok";
            string s1 = "Kobyła ma mały bok.";
            string s2 = "Ka jak .";

            Console.WriteLine("Ivan".IsPalindrome());
            Console.WriteLine(s2);
            Console.WriteLine(s2.IsPalindrome());
            Console.WriteLine(s);
            Console.WriteLine(s.IsPalindrome());
            Console.WriteLine(s1);
            Console.WriteLine(s1.IsPalindrome());
            Console.ReadKey();
        }
    }

    public static class ExpansionMethod
    {
        public static bool IsPalindrome(this String strinp)
        {
            string word = strinp.Replace(" ", string.Empty);
            word = word.Trim(new Char[] { ' ', ',', '.' });
            
            string reversed = new string(word.Reverse().ToArray());
            return String.Equals(word, reversed, comparisonType: StringComparison.OrdinalIgnoreCase);
        }
    }
}
