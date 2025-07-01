using Inheritance.Models;

Employee employee1 = new Employee("Sina", 29, 100);
employee1.ShowPersonalInfo();

Developer developer =  new Developer("Emre",35,200,"C#");
developer.ShowPersonalInfo();

SeniorDeveloper seniorDeveloper = new SeniorDeveloper("Bekar", 45, 600, false);
seniorDeveloper.ShowPersonalInfo();


List<Employee> employees = new List<Employee>();
employees.Add(employee1);
employees.Add(developer);
employees.Add(seniorDeveloper);

foreach (Employee employee in employees)
{
    employee.ShowPersonalInfo();
    Console.WriteLine("###################");
}



