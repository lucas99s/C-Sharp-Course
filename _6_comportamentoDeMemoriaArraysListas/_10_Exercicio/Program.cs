using System;
using System.Collections.Generic;

namespace _10_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List <Employee> list = new List<Employee>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i+1}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will hava salary increase: ");
            int search = int.Parse(Console.ReadLine());

            Employee empId = list.Find(x => x.Id == search);
            if(empId != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                empId.IncreaseSalary(percentage);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
