using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Developer : Employee
    {
        public Developer(string name, int age, double salary, string softwareLanguage) : base(name, age, salary)
        {
            SoftwareLanguage = softwareLanguage;
        }
        public string SoftwareLanguage { get; set; }
    }
}
