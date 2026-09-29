using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }

    public Employee(string name, string department, int salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class q4
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Amit", "IT", 100000),
            new Employee("Rahul", "IT", 95000),
            new Employee("Priya", "HR", 85000),
            new Employee("Kiran", "Sales", 120000)
        };

        Dictionary<string, int> departmentSalary =
            new Dictionary<string, int>();

        foreach (Employee emp in employees)
        {
            if (departmentSalary.ContainsKey(emp.Department))
            {
                departmentSalary[emp.Department] += emp.Salary;
            }
            else
            {
                departmentSalary[emp.Department] = emp.Salary;
            }
        }

        string highestDepartment = "";
        int highestSalary = 0;

        foreach (var item in departmentSalary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");

            if (item.Value > highestSalary)
            {
                highestSalary = item.Value;
                highestDepartment = item.Key;
            }
        }

        Console.WriteLine(
            $"Highest paying: {highestDepartment}"
        );
    }
}