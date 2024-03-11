using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employess
            //At least two employees should have the first name "Joe".
            List<Employee> campus = new List<Employee>()
            {
                new Employee() {ID = 1, firstName = "Joe", lastName = "Schmo"},
                new Employee() {ID = 2, firstName = "Joe", lastName = "Thomas"},
                new Employee() {ID = 3, firstName = "JimBob", lastName = "Coot"},
                new Employee() {ID = 4, firstName = "Danny", lastName = "Dimes"},
                new Employee() {ID = 5, firstName = "SaQuads", lastName = "Barkley"},
                new Employee() {ID = 6, firstName = "George", lastName = "Title"},
                new Employee() {ID = 7, firstName = "Joe", lastName = "Joesephson"},
                new Employee() {ID = 8, firstName = "Maria", lastName = "Schmo"},
                new Employee() {ID = 9, firstName = "Maria", lastName = "Rodriguez"},
                new Employee() {ID = 10, firstName = "Stephanie", lastName = "Stevens"},
            };
            //Using a foreach loop, create a new list of all employess with the first name "Joe".
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Do the same thing again, but this time with a lambda empression.
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();
            //Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> bigId = campus.Where(x => x.ID > 5).ToList();
            Console.ReadLine();
        }
    }
}
