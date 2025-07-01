using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Employee
    {
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void ShowPersonalInfo()
        {
            Console.WriteLine($"Ad: {Name}\nYaş: {Age}\nMaaş: {Salary}");
        }

    }
}
