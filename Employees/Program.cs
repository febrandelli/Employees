using System;
using System.Collections.Generic;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> list = new List<Funcionario> { };
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                Funcionario employee = new Funcionario(id, name, salary);
                list.Add(employee);
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            Funcionario employeeIncrease = list.Find(x => x.id == idIncrease);
            if (employeeIncrease == null)
            {
                Console.WriteLine("This id does not exist!");
                Console.WriteLine("");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                employeeIncrease.IncreaseSalary(percentage);
                Console.WriteLine("");
            }
            Console.WriteLine("Update list of employees:");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.id},{item.name},{item.salary}");
            }
        }
    }
}
