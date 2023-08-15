using System;
using System.Collections.Generic;

namespace Aula77
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            
            list.Add("Nathan");
            list.Add("Sara");
            list.Add("Gabi");
            list.Add("Armando");
            list.Add("Arnaldo");
            list.Insert(2, "Daniel");

            foreach (string pessoas in list)
            {
                Console.WriteLine(pessoas);
            }
            
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int p1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + p1);
            
            int p2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + p2);

            List<string> list2 = list.FindAll(x => x.Length == 4);
            foreach (string pessoa in list2)
            {
                Console.WriteLine(pessoa + "\n");
            }

            list.RemoveAll(x => x[0] == 'A');
            list.RemoveAt(3);
            list.RemoveRange(1, 2);
            foreach (string teste in list) 
            {
                Console.WriteLine(teste);
            }
        }
    }
}