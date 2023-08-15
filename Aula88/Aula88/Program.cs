using System;

namespace Aula88
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG";

            string s = original.ToUpper();
            string s1 = original.ToLower();
            string s2 = original.Trim();
            string s3 = original.Substring(3);
            string s4 = original.Substring(3, 5);
            string s5 = original.Replace('a', 'w');
            int n1 = original.IndexOf("ab");
            int n2 = original.LastIndexOf("ab");

            Console.WriteLine("Original: " + original + "\nUpper Case: " + s);
            Console.WriteLine("Lower case: " + s1 + "\nTrim: " + s2);
            Console.WriteLine("Index of('ab'): " + n1 + "\nLast index of('ab'): " + n2);
            Console.WriteLine("Substring(3): " + s3 + "\nSubstring(3, 5): " + s4);
            Console.WriteLine("Replace('a', 'w'): " + s5 + "\n");
            
        }
    }
}