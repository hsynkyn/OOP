using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Manager : Employee
    {
        public Manager(string name, int age, double salary, string department) : base(name, age, salary)
        {
            Department = department;
        }

        public string Department { get; set; }
    }
}
