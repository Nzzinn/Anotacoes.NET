using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employee = employees.Find(x => x.Id == searchId);

            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                employee.IncreaseSalary(percentage);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}