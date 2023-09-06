using aula140.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace aula140
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }   
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}