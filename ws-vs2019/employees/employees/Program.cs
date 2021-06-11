using System;
using System.Collections.Generic;
using System.Globalization;

namespace employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<employee> list = new List<employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id: ");
                int ident = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = (Console.ReadLine());
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new employee(ident, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            int search = int.Parse(Console.ReadLine());

            employee emp = list.Find(x => x.Ident == search);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
