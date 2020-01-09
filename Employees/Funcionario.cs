using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    class Funcionario
    {
        public int id { get; private set; }
        public string name { get; set; }
        public double salary { get; private set; }

        public Funcionario(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void IncreaseSalary (double percentage)
        {
            this.salary = salary + salary * (percentage / 100);
        }

    }
}
