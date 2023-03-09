using System;
using System.Collections.Generic;
using _5_Exercicio.Entities;

namespace _5_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employee = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if(outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine());
                    Employee.Add(new OutsourcedEmployee(additional, name, hours, valuePerHour));
                }
                else
                {
                    Employee.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(var emp in Employee)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment():F2}");
            }
        }
    }
}
