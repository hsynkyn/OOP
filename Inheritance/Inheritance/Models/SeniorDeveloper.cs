using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class SeniorDeveloper : Employee
    {
        public SeniorDeveloper(string name, int age, double salary, bool isRetired) : base(name, age, salary)
        {
            IsRetired = isRetired;
        }
        public bool IsRetired { get; set; }
    }
}
