using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like... taking all of the properties of Company and putting them in Acme.
            Company AcmeInc = new Company("Achme, Inc.", new DateTime(1997, 05, 27));


            // Create three employees
            Employee Turner = new Employee();
            Turner.FirstName = "Turner";
            Turner.LastName = "Moss";
            Turner.Title = "CEO";
            Turner.StartDate = new DateTime(2022, 02, 15);

            Employee Aaron = new Employee();
            Aaron.FirstName = "Aaron";
            Aaron.LastName = "Moss";
            Aaron.Title = "CEO";
            Aaron.StartDate = new DateTime(2022, 02, 15);

            Employee Drew = new Employee();
            Drew.FirstName = "Drew";
            Drew.LastName = "Moss";
            Drew.Title = "CEO";
            Drew.StartDate = new DateTime(2022, 02, 15);

            List<Employee> allEmployees = new List<Employee>()
            {
                Turner, Aaron, Drew
            };


            // Assign the employees to the company
            AcmeInc.Employees = allEmployees;
            foreach (var Employee in AcmeInc.Employees)
            {
                Console.WriteLine(Employee.FirstName);
            }

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            AcmeInc.ListEmployees();

        }
    }
}
