using System;
using System.Globalization;

namespace ExercicioVetor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student[] s = new Student[10];
            
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Email: ");
                string email = Console.ReadLine();
                
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine() + "\n");

                s[room] = new Student(name, email);
            }
            
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (s[i] != null)
                {
                    Console.WriteLine(i + ": " + s[i]);
                }
            }
        }
    }
}