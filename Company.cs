using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set;}
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();


        public void ListEmployees()
        {
            foreach (Employee Employee in Employees)
            {
                Console.WriteLine($"{Employee.FirstName} {Employee.LastName} works for {this.Name} as {Employee.Title} since {Employee.StartDate}");
            }
        }


        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company (string name, DateTime date)
        {
            Name = name;
            CreatedOn = date;
        }
    }
}